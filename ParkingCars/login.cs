using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ParkingCars
{
    public partial class login : Form
    {
        public static int IdWorkers { get; set; }
        public login()
        {
            InitializeComponent();
            
        }

        private void logins(object sender, EventArgs e)
        {
            string a = null;
            IdWorkers = parkingDataSet.Works.Where(p => p.email == Email.Text && p.password == Password.Text && p.Position == Position.Text).Select(s => s.OperatorId).FirstOrDefault();
            a = parkingDataSet.Works.Where(p => p.email == Email.Text && p.password == Password.Text && p.Position == Position.Text).Select(s => s.Position).FirstOrDefault()?.ToString();
            if (a == "Администратор")
            {
                MainAdmin f = (MainAdmin)Application.OpenForms["MainAdmin"];
                if (f == null)
                {
                    f = new MainAdmin();
                    f.Show();
                }
                else
                    f.Activate();
               
            }
            else
            if (a == "Оператор")
            {
                MainOperator f = (MainOperator)Application.OpenForms["MainOperator"];
                if (f == null)
                {
                    f = new MainOperator();
                    f.Show();
                }
                else
                    f.Activate();
            }
            else
            {
                MessageBox.Show("Нет такого пользователя!!!");
            }
            
                
                
            

        }


        private void login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "parkingDataSet.Works". При необходимости она может быть перемещена или удалена.
            this.worksTableAdapter.Fill(this.parkingDataSet.Works);

        }
    }
}
