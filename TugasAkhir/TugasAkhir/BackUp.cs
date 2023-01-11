using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir
{
    internal class BackUp
    {
        DataGridView namaDgv;

        public BackUp(DataGridView namaDgv)
        {
            this.namaDgv = namaDgv;
            kirimExcel();
        }

        private void copyAlltoClipboard()
        {
            this.namaDgv.SelectAll();
            DataObject dataObj = this.namaDgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        public void kirimExcel()
        {
            DataObject copyData = this.namaDgv.GetClipboardContent();
            if (copyData != null) Clipboard.SetDataObject(copyData);
            {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlapp.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook xlwbook;
                Microsoft.Office.Interop.Excel.Worksheet xlsheet;
                object missedData = System.Reflection.Missing.Value;
                xlwbook = xlapp.Workbooks.Add(missedData);
                xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlwbook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
                xlr.Select();

                xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }

        }
    }
}
