using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Excel;
using System.CodeDom.Compiler;
using System;

namespace CRM
{
    public partial class Contact : Form
    {
        PaginaPrincipala linkInapoi;

        public Contact(PaginaPrincipala parinte)
        {
            InitializeComponent();
            linkInapoi = parinte;
        }

        private void Contact_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'structuriDeDate.InformatiiComplete' table. You can move, or remove it, as needed.
            this.informatiiCompleteTableAdapter.Fill(this.structuriDeDate.InformatiiComplete);
        }

        private void Back_Click(object sender, System.EventArgs e)
        {
            linkInapoi.Show();
            this.Hide();
        }

        private void Export_Click(object sender, System.EventArgs e)
        {



            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        
























        /////////////////////////////////////incercarea 2/////////////

        //Microsoft.Office.Interop.Excel._Application app =
        //    new Microsoft.Office.Interop.Excel.Application();
        //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        //worksheet = workbook.Sheets["Sheet1"];
        //worksheet = workbook.ActiveSheet;
        //worksheet.Name = "Toti Angajatii";

        //for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
        //{

        //    worksheet.Cells[1,i]=dataGridView1.Columns[i-1].HeaderText;
        //}

        //for (int i = 0; i < dataGridView1.Rows.Count + 1; i++)
        //{
        //    for (int j = 0; j < dataGridView1.Columns.Count ; j++)
        //    {

        //        worksheet.Cells[i + 2, j + 1] = 
        //            dataGridView1.Rows[i].Cells[j].Value.ToString();

        //    }
        //}

        //var saveFileDialoge = new SaveFileDialog();
        //saveFileDialoge.FileName = "Excel_exportContacte";
        //saveFileDialoge.DefaultExt = ".xlsx";

        //if(saveFileDialoge.ShowDialog()==DialogResult.OK)
        //{
        //    workbook.SaveAs(saveFileDialoge.FileName,
        //        Type.Missing, Type.Missing, Type.Missing, Type.Missing,
        //        Type.Missing,Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
        //        Type.Missing, Type.Missing, Type.Missing
        //        , Type.Missing, Type.Missing);
        //}
        //app.Quit();


        ////////////////////////////////////prima incercare///////


        //saveFileDialog1.InitialDirectory = "C:";
        //saveFileDialog1.Title = "Salveaza ca fila Excel";
        //saveFileDialog1.FileName = "Excel_exportContacte";
        //saveFileDialog1.Filter = "ExcelFiles(2016)|*.xlsx";

        //if (saveFileDialog1.ShowDialog() != DialogResult.Cancel) {

        //    Microsoft.Office.Interop.Excel.Application ExcelApp = 
        //        new Microsoft.Office.Interop.Excel.Application();


        //    ExcelApp.Application.Workbooks.Add(  );
        //    //schimb propietati Workbook
        //    ExcelApp.Columns.ColumnWidth = 20;
        //    //Storing
        //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)

        //    {
        //        ExcelApp.Cells[1, i] = 
        //            dataGridView1.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
        //    {
        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        {
        //            ExcelApp.Cells[i + 2, j + 1] =
        //                dataGridView1.Rows[i].Cells[j].Value.ToString();
        //        }
        //    }

        //    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
        //    ExcelApp.ActiveWorkbook.Saved = true;
        //    ExcelApp.Quit();



    }
    }
}
