namespace ParkingCars
{
    partial class addPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPayments));
            this.label5 = new System.Windows.Forms.Label();
            this.Summ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberPlace = new System.Windows.Forms.ComboBox();
            this.NumberCars = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddPayment = new System.Windows.Forms.Button();
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.paymentsChecksParkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsChecksParkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.PaymentsChecksParkingTableAdapter();
            this.tableAdapterManager = new ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager();
            this.carsParkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.CarsParkingTableAdapter();
            this.parkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.ParkingTableAdapter();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsParkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DateP = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsChecksParkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsParkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата";
            // 
            // Summ
            // 
            this.Summ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summ.Location = new System.Drawing.Point(199, 73);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(257, 31);
            this.Summ.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Сумма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Номер места";
            // 
            // NumberPlace
            // 
            this.NumberPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.NumberPlace.FormattingEnabled = true;
            this.NumberPlace.Location = new System.Drawing.Point(199, 125);
            this.NumberPlace.Name = "NumberPlace";
            this.NumberPlace.Size = new System.Drawing.Size(257, 33);
            this.NumberPlace.TabIndex = 16;
            // 
            // NumberCars
            // 
            this.NumberCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.NumberCars.FormattingEnabled = true;
            this.NumberCars.Location = new System.Drawing.Point(199, 176);
            this.NumberCars.Name = "NumberCars";
            this.NumberCars.Size = new System.Drawing.Size(257, 33);
            this.NumberCars.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Номер машины";
            // 
            // AddPayment
            // 
            this.AddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPayment.Location = new System.Drawing.Point(138, 284);
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Size = new System.Drawing.Size(211, 45);
            this.AddPayment.TabIndex = 19;
            this.AddPayment.Text = "Добавить";
            this.AddPayment.UseVisualStyleBackColor = true;
            this.AddPayment.Click += new System.EventHandler(this.AddPayment_Click);
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsChecksParkingBindingSource
            // 
            this.paymentsChecksParkingBindingSource.DataMember = "PaymentsChecksParking";
            this.paymentsChecksParkingBindingSource.DataSource = this.parkingDataSet;
            // 
            // paymentsChecksParkingTableAdapter
            // 
            this.paymentsChecksParkingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsParkingTableAdapter = this.carsParkingTableAdapter;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = this.parkingTableAdapter;
            this.tableAdapterManager.PaymentsChecksParkingTableAdapter = this.paymentsChecksParkingTableAdapter;
            this.tableAdapterManager.UpdateOrder = ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksTableAdapter = null;
            // 
            // carsParkingTableAdapter
            // 
            this.carsParkingTableAdapter.ClearBeforeFill = true;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "Parking";
            this.parkingBindingSource.DataSource = this.parkingDataSet;
            // 
            // carsParkingBindingSource
            // 
            this.carsParkingBindingSource.DataMember = "CarsParking";
            this.carsParkingBindingSource.DataSource = this.parkingDataSet;
            // 
            // DateP
            // 
            this.DateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DateP.Location = new System.Drawing.Point(199, 20);
            this.DateP.Name = "DateP";
            this.DateP.Size = new System.Drawing.Size(257, 31);
            this.DateP.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(199, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 31);
            this.textBox1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Номер счета";
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.parkingDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // addPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingCars.Properties.Resources.Без_названия;
            this.ClientSize = new System.Drawing.Size(485, 355);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateP);
            this.Controls.Add(this.AddPayment);
            this.Controls.Add(this.NumberCars);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberPlace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addPayments";
            this.Text = "Добавление платежа";
            this.Load += new System.EventHandler(this.addPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsChecksParkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsParkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Summ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumberPlace;
        private System.Windows.Forms.ComboBox NumberCars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddPayment;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource paymentsChecksParkingBindingSource;
        private ParkingDataSetTableAdapters.PaymentsChecksParkingTableAdapter paymentsChecksParkingTableAdapter;
        private ParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private ParkingDataSetTableAdapters.CarsParkingTableAdapter carsParkingTableAdapter;
        private System.Windows.Forms.BindingSource carsParkingBindingSource;
        private System.Windows.Forms.DateTimePicker DateP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private ParkingDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
    }
}