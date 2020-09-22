using System;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class Debtor : Form
    {
        public Debtor()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            selectDebortBindingSource.Filter = "CarsNumber='" + CarsNumber.Text + "'";
            
            dataGridView1.DataSource = selectDebortBindingSource;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      

        private void allList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.parkingDataSet.selectDebort;
        }

        private void Debtor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkingDataSet.selectDebort' table. You can move, or remove it, as needed.
            this.selectDebortTableAdapter.Fill(this.parkingDataSet.selectDebort);

        }
    }
}
