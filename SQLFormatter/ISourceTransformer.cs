using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobEllis.SQLFormatter
{
    public interface ISourceTransformer
    {
        string Transform(string source);
        string SourceText { get; set; }
        string ResultText { get; }
    }

    public interface ISQLTransformer : ISourceTransformer
    {
        bool UseInlineVariables { get; set; }
        string NewLineText { get; set; }
    }
}
