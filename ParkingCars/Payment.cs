using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void buttonSumMonth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Доход в этом месяце: " + parkingDataSet.selectAllPaymentMonth.Select(s=>s.Вся_сумма).FirstOrDefault()+" руб."); ;
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
                for (j = 0; j < ViewPayments.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = ViewPayments.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < ViewPayments.Rows.Count; i++)
                {
                    for (j = 0; j < ViewPayments.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = ViewPayments[j, i].Value == null ? "" : ViewPayments[j, i].Value;
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

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.selectAllPaymentMonth". При необходимости она может быть перемещена или удалена.
            this.selectAllPaymentMonthTableAdapter.Fill(this.parkingDataSet.selectAllPaymentMonth);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.selectAllPayments". При необходимости она может быть перемещена или удалена.
            this.selectAllPaymentsTableAdapter.Fill(this.parkingDataSet.selectAllPayments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectAllPaymentsBindingSource.Filter = "ParkingNamber='"+CarsNumber.Text+"'";
            ViewPayments.DataSource = selectAllPaymentsBindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewPayments.DataSource = this.parkingDataSet.selectAllPayments;
        }
    }
}
