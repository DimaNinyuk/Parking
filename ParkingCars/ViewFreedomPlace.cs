using System;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class ViewFreedomPlace : Form
    {
        public ViewFreedomPlace()
        {
            InitializeComponent();
        }

        private void ViewFreedomPlace_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Parking". При необходимости она может быть перемещена или удалена.
            this.parkingTableAdapter.Fill(this.parkingDataSet.Parking);
            parkingBindingSource.Filter = "Status = 'Свободное'";
            ViewFreedomPlacies.DataSource = parkingBindingSource;

        }
    }
}
