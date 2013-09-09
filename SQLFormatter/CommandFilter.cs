using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.Utilities;

using System.Linq;

namespace RobEllis.SQLFormatter
{
    [Export(typeof(IVsTextViewCreationListener))]
    [ContentType("code")]
    [TextViewRole(PredefinedTextViewRoles.Editable)]
    class VsTextViewCreationListener : IVsTextViewCreationListener
    {
        [Import]
        IVsEditorAdaptersFactoryService AdaptersFactory = null;

        public void VsTextViewCreated(IVsTextView textViewAdapter)
        {
            var wpfTextView = AdaptersFactory.GetWpfTextView(textViewAdapter);
            if (wpfTextView == null)
            {
                Debug.Fail("Unable to get IWpfTextView from text view adapter");
                return;
            }

            CommandFilter filter = new CommandFilter(wpfTextView);

            IOleCommandTarget next;
            if (ErrorHandler.Succeeded(textViewAdapter.AddCommandFilter(filter, out next)))
                filter.Next = next;
        }
    }

    class CommandFilter : IOleCommandTarget
    {
        IWpfTextView _view;

        public CommandFilter(IWpfTextView view)
        {
            _view = view;
        }

        internal IOleCommandTarget Next { get; set; }

        public int Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
        {
            if (pguidCmdGroup == GuidList.guidSQLFormatterCmdSet &&
                nCmdID == PkgCmdIDList.cmdIdFormatSql)
            {
                ShowSelection();
                return VSConstants.S_OK;
            }

            return Next.Exec(ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
        }

        public int QueryStatus(ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
        {
            if (pguidCmdGroup == GuidList.guidSQLFormatterCmdSet &&
                prgCmds[0].cmdID == PkgCmdIDList.cmdIdFormatSql)
            {
                if (CursorIsOnStringLiteral)
                    prgCmds[0].cmdf = (uint)(OLECMDF.OLECMDF_ENABLED | OLECMDF.OLECMDF_SUPPORTED);
                else
                    prgCmds[0].cmdf = (uint)(OLECMDF.OLECMDF_SUPPORTED);

                return VSConstants.S_OK;
            }

            return Next.QueryStatus(ref pguidCmdGroup, cCmds, prgCmds, pCmdText);
        }

        private bool CursorIsOnStringLiteral
        {
            get
            {
                // TODO: check if caret is within string literal
                return _view.Caret.Position.BufferPosition.GetContainingLine().GetText().Contains("\"");
            }
        }

        private void ShowSelection()
        {
            string c = _view.TextBuffer.CurrentSnapshot.GetText(_view.Selection.SelectedSpans[0]);
            //string txt = _view.Selection.SelectedSpans.ToString();
            MessageBox.Show(c);
        }
    }
}