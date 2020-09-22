namespace ParkingCars
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.Start = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.ComboBox();
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.worksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worksTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.WorksTableAdapter();
            this.tableAdapterManager = new ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(178, 196);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(106, 45);
            this.Start.TabIndex = 9;
            this.Start.Text = "Войти";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.logins);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(168, 143);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(257, 31);
            this.Password.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(168, 81);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(257, 31);
            this.Email.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Должность";
            // 
            // Position
            // 
            this.Position.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "Администратор",
            "Оператор"});
            this.Position.Location = new System.Drawing.Point(168, 16);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(257, 33);
            this.Position.TabIndex = 11;
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worksBindingSource
            // 
            this.worksBindingSource.DataMember = "Works";
            this.worksBindingSource.DataSource = this.parkingDataSet;
            // 
            // worksTableAdapter
            // 
            this.worksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsParkingTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = null;
            this.tableAdapterManager.PaymentsChecksParkingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksTableAdapter = this.worksTableAdapter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingCars.Properties.Resources.Без_названия;
            this.ClientSize = new System.Drawing.Size(458, 266);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Position;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource worksBindingSource;
        private ParkingDataSetTableAdapters.WorksTableAdapter worksTableAdapter;
        private ParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

