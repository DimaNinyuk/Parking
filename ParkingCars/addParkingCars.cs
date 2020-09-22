using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class addParkingCars : Form
    {
        public addParkingCars()
        {
            InitializeComponent();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            var parkingChange = parkingDataSet.Parking.Where(w=>w.ParkingNamber == int.Parse(NumberPlace.SelectedValue.ToString())).First();
            parkingChange["Status"] = "Нет на месте";
            parkingChange["CarsNumber"] = NumerCars.Text;
            parkingTableAdapter.Update(parkingChange);
            int parkingNumber = parkingDataSet.Parking.Where(s => s.CarsNumber == NumerCars.Text).Select(s => s.ParkingNamber).First();
            parkingDataSet.CarsParking.Rows.Add(DateTime.Now, "01.01.2001 0:00:00", NumerCars.Text, parkingNumber, login.IdWorkers);
            carsParkingTableAdapter.Update(parkingDataSet.CarsParking);
            var updateParking = parkingDataSet.Parking.Where(s => s.CarsNumber == NumerCars.Text).First();
            updateParking["Status"] = "Нет на месте";
            parkingTableAdapter.Update(updateParking);
            MessageBox.Show("Добавлено!!!");
        
        }

       

        private void addParkingCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkingDataSet.CarsParking' table. You can move, or remove it, as needed.
            this.carsParkingTableAdapter.Fill(this.parkingDataSet.CarsParking);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Parking". При необходимости она может быть перемещена или удалена.
            this.parkingTableAdapter.Fill(this.parkingDataSet.Parking);
            parkingBindingSource.Filter = "Status = 'Свободное'";
            NumberPlace.DataSource = parkingBindingSource;
            NumberPlace.DisplayMember = "ParkingNamber";
            NumberPlace.ValueMember = "ParkingNamber";

           

        }
    }
}
