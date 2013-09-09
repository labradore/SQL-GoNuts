// Guids.cs
// MUST match guids.h
using System;

namespace RobEllis.SQLFormatter
{
    static class GuidList
    {
        public const string guidSQLFormatterPkgString = "4ddbd29a-f8a5-4db9-aaaa-7c9a79ecd0ba";
        public const string guidSQLFormatterCmdSetString = "80d0ea8c-3bf0-4b8a-afa5-c7f12d54361d";

        public static readonly Guid guidSQLFormatterCmdSet = new Guid(guidSQLFormatterCmdSetString);
    };
}