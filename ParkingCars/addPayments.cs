using System;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class addPayments : Form
    {
        public addPayments()
        {
            InitializeComponent();
            NumberCars.DataSource = parkingDataSet.Cars;
            NumberCars.DisplayMember = "CarsNumber";
            NumberCars.ValueMember = "CarsNumber";
            NumberPlace.DataSource = parkingBindingSource;
            NumberPlace.DisplayMember = "ParkingNamber";
            NumberPlace.ValueMember = "ParkingNamber";
        }

        private void AddPayment_Click(object sender, EventArgs e)
        {
            parkingDataSet.PaymentsChecksParking.Rows.Add(textBox1.Text,DateP.Value,Summ.Text,NumberPlace.Text,NumberCars.Text);
            paymentsChecksParkingTableAdapter.Update(parkingDataSet.PaymentsChecksParking);
            MessageBox.Show("Добавлено");
        }

       

        private void addPayments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.parkingDataSet.Cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.CarsParking". При необходимости она может быть перемещена или удалена.
            this.carsParkingTableAdapter.Fill(this.parkingDataSet.CarsParking);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Parking". При необходимости она может быть перемещена или удалена.
            this.parkingTableAdapter.Fill(this.parkingDataSet.Parking);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.PaymentsChecksParking". При необходимости она может быть перемещена или удалена.
            this.paymentsChecksParkingTableAdapter.Fill(this.parkingDataSet.PaymentsChecksParking);
            
        }
    }
}
