using System;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class ArrivalsDepartures : Form
    {
        public ArrivalsDepartures()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            carsParkingBindingSource.Filter = "((DateTimeDeparture >= '"+DateS.Value+ "' AND DateTimeDeparture <= '"+DateP.Value+ "') OR (DateTimeDeparture = '"+ DateS.Value + "') OR (DateTimeDeparture = '"+ DateP.Value + "'))";
            ViewArrivalDeparture.DataSource = carsParkingBindingSource;
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
                for (j = 0; j < ViewArrivalDeparture.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = ViewArrivalDeparture.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < ViewArrivalDeparture.Rows.Count; i++)
                {
                    for (j = 0; j < ViewArrivalDeparture.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = ViewArrivalDeparture[j, i].Value == null ? "" : ViewArrivalDeparture[j, i].Value;
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

        private void ArrivalsDepartures_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.CarsParking". При необходимости она может быть перемещена или удалена.
            this.carsParkingTableAdapter.Fill(this.parkingDataSet.CarsParking);

        }

        private void allList_Click(object sender, EventArgs e)
        {
            ViewArrivalDeparture.DataSource = this.parkingDataSet.CarsParking;
        }
    }
}
