using System;

namespace Microsoft
{
    internal class Office
    {
        internal class Interop
        {
            internal class Excel
            {
                internal class Application
                {
                    public object Workbooks { get; internal set; }
                }

                internal class Workbook
                {
                }

                internal class Worksheet
                {
                    internal void PasteSpecial(Range xlr, object missing1, object missing2, object missing3, object missing4, object missing5, bool v)
                    {
                        throw new NotImplementedException();
                    }
                }

                internal class Range
                {
                }
            }
        }
    }
}