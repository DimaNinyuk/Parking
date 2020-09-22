using System;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void pay(object sender, EventArgs e)
        {
            Payment fn = (Payment)Application.OpenForms["Payment"];
            if (fn == null)
            {
                Payment f = new Payment();
                f.Show();
            }
            else
                fn.Activate();
        }

        private void debors(object sender, EventArgs e)
        {
            Debtor fn = (Debtor)Application.OpenForms["Debtor"];
            if (fn == null)
            {
                Debtor f = new Debtor();
                f.Show();
            }
            else
                fn.Activate();
        }

        private void arivalsDeparrtures(object sender, EventArgs e)
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

        private void selectCars(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = true;
            
            VievTabl.DataSource = carsBindingSource;
            VievTabl.Columns["CarsNumber"].HeaderText = "Номер машины";
            VievTabl.Columns["Color"].HeaderText = "Цвет";
            VievTabl.Columns["Brand"].HeaderText = "Марка";
            VievTabl.Columns["ClientId"].HeaderText = "Код клиента";
            VievTabl.Columns["DateRegister"].HeaderText = "Дата регистрации";
            bindingNavigator1.BindingSource = carsBindingSource;

        }

        private void selectClients(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = true;
            VievTabl.DataSource = clientsBindingSource;
            VievTabl.Columns["ClientId"].HeaderText = "Код клиента";
            VievTabl.Columns["Surname"].HeaderText = "Фамилия";
            VievTabl.Columns["Name"].HeaderText = "Имя";
            VievTabl.Columns["MiddleName"].HeaderText = "Отчество";
            VievTabl.Columns["Phone"].HeaderText = "Телефон";
            bindingNavigator1.BindingSource = clientsBindingSource;
        }

        private void selectOperstors(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = true;
            worksBindingSource.Filter = "Position='Оператор'";
            VievTabl.DataSource = worksBindingSource;
            VievTabl.Columns["OperatorId"].HeaderText = "Код оператора";
            VievTabl.Columns["Surname"].HeaderText = "Фамилия";
            VievTabl.Columns["Name"].HeaderText = "Имя";
            VievTabl.Columns["MiddleName"].HeaderText = "Отчество";
            VievTabl.Columns["Phone"].HeaderText = "Телефон";
            VievTabl.Columns["email"].HeaderText = "email";
            VievTabl.Columns["password"].HeaderText = "Пароль";
            VievTabl.Columns["Position"].HeaderText = "Должность";
            bindingNavigator1.BindingSource = worksBindingSource;
        }

        private void selectParking(object sender, EventArgs e)
        {
            bindingNavigator1.Enabled = true;
            VievTabl.DataSource = parkingBindingSource;
            VievTabl.Columns["ParkingNamber"].HeaderText = "Номер парковки";
            VievTabl.Columns["Status"].HeaderText = "Статус";
            VievTabl.Columns["CarsNumber"].HeaderText = "Номер машины";
            bindingNavigator1.BindingSource = parkingBindingSource;
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Works". При необходимости она может быть перемещена или удалена.
            this.worksTableAdapter.Fill(this.parkingDataSet.Works);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Parking". При необходимости она может быть перемещена или удалена.
            this.parkingTableAdapter.Fill(this.parkingDataSet.Parking);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.parkingDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.parkingDataSet.Cars);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Works". При необходимости она может быть перемещена или удалена.
            this.worksTableAdapter.Update(this.parkingDataSet.Works);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Parking". При необходимости она может быть перемещена или удалена.
            this.parkingTableAdapter.Update(this.parkingDataSet.Parking);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Update(this.parkingDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Update(this.parkingDataSet.Cars);
        }
    }
}
