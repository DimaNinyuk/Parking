using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class MainOperator : Form
    {
        public MainOperator()
        {
            InitializeComponent();
        }

        public ViewFreedomPlace ViewFreedomPlace
        {
            get => default;
            set
            {
            }
        }

        private void ViewFreedomPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFreedomPlace fn = (ViewFreedomPlace)Application.OpenForms["ViewFreedomPlace"];
            if (fn == null)
            {
                ViewFreedomPlace f = new ViewFreedomPlace();
                f.Show();
            }
            else
            fn.Activate();
            
        }

        private void addParkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addParkingCars fn = (addParkingCars)Application.OpenForms["addParkingCars"];
           
            if (fn == null) 
            {
                addParkingCars f = new addParkingCars();
                f.Show();
            }
            else
               fn.Activate(); 
            
           
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPayments fn = (addPayments)Application.OpenForms["addPayments"];
            if (fn == null)
            {
                addPayments f = new addPayments();
                f.Show();
            }
            else
                fn.Activate();
           
        }

        private void VievVizdViezdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrivalsDepartures fn = (ArrivalsDepartures)Application.OpenForms["ArrivalsDepartures"];
            if (fn == null)
            {
                ArrivalsDepartures f = new ArrivalsDepartures();
                f.Show();
            }
            else
                fn.Activate();
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVezd_Click(object sender, EventArgs e)
        {
            int parkingNumber = parkingDataSet.Parking.Where(s => s.CarsNumber == CarsNumber.Text).Select(s => s.ParkingNamber).First();
            parkingDataSet.CarsParking.Rows.Add(DateTime.Now,"01.01.2001 0:00:00",CarsNumber.Text,parkingNumber,login.IdWorkers);
            carsParkingTableAdapter.Update(parkingDataSet.CarsParking);
            var updateParking = parkingDataSet.Parking.Where(s => s.CarsNumber == CarsNumber.Text).First();
            updateParking["Status"] = "Нет на месте";
            parkingTableAdapter.Update(updateParking);
            MessageBox.Show("Добавлено!!!");
        }

        private void buttonViezd_Click(object sender, EventArgs e)
        {
            int parkingNumber = parkingDataSet.Parking.Where(s => s.CarsNumber == CarsNumber.Text).Select(s => s.ParkingNamber).First();
            var updateParkingCars = parkingDataSet.CarsParking.Where(s => s.CarsNumber == CarsNumber.Text && s.DateTimeEntry.ToString() == "01.01.2001 0:00:00").First();
            updateParkingCars["DateTimeEntry"] =  DateTime.Now;
            carsParkingTableAdapter.Update(updateParkingCars);
            var updateParking = parkingDataSet.Parking.Where(s => s.CarsNumber == CarsNumber.Text).First();
            updateParking["Status"] = "В гараже";
            parkingTableAdapter.Update(updateParking);
            MessageBox.Show("Добавлено!!!");
        }


        private void MainOperator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.CarsParking". При необходимости она может быть перемещена или удалена.
            this.carsParkingTableAdapter.Fill(this.parkingDataSet.CarsParking);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Parking". При необходимости она может быть перемещена или удалена.
            this.parkingTableAdapter.Fill(this.parkingDataSet.Parking);

        }
    }
}
