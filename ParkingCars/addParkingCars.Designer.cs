namespace ParkingCars
{
    partial class addParkingCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addParkingCars));
            this.NumerCars = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.Button();
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.ParkingTableAdapter();
            this.tableAdapterManager = new ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager();
            this.NumberPlace = new System.Windows.Forms.ComboBox();
            this.carsParkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsParkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.CarsParkingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsParkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NumerCars
            // 
            this.NumerCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumerCars.Location = new System.Drawing.Point(200, 19);
            this.NumerCars.Name = "NumerCars";
            this.NumerCars.Size = new System.Drawing.Size(257, 31);
            this.NumerCars.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Номер машины";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Номер места";
            // 
            // Select
            // 
            this.Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Select.Location = new System.Drawing.Point(146, 150);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(211, 45);
            this.Select.TabIndex = 13;
            this.Select.Text = "Разместить";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingBindingSource
            // 
            this.parkingBindingSource.DataMember = "Parking";
            this.parkingBindingSource.DataSource = this.parkingDataSet;
            // 
            // parkingTableAdapter
            // 
            this.parkingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsParkingTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = this.parkingTableAdapter;
            this.tableAdapterManager.PaymentsChecksParkingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksTableAdapter = null;
            // 
            // NumberPlace
            // 
            this.NumberPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.NumberPlace.FormattingEnabled = true;
            this.NumberPlace.Location = new System.Drawing.Point(200, 79);
            this.NumberPlace.Name = "NumberPlace";
            this.NumberPlace.Size = new System.Drawing.Size(257, 33);
            this.NumberPlace.TabIndex = 14;
            // 
            // carsParkingBindingSource
            // 
            this.carsParkingBindingSource.DataMember = "CarsParking";
            this.carsParkingBindingSource.DataSource = this.parkingDataSet;
            // 
            // carsParkingTableAdapter
            // 
            this.carsParkingTableAdapter.ClearBeforeFill = true;
            // 
            // addParkingCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingCars.Properties.Resources.Без_названия;
            this.ClientSize = new System.Drawing.Size(478, 228);
            this.Controls.Add(this.NumberPlace);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumerCars);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addParkingCars";
            this.Text = "Разместить на парковку";
            this.Load += new System.EventHandler(this.addParkingCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsParkingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumerCars;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Select;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private ParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private ParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox NumberPlace;
        private System.Windows.Forms.BindingSource carsParkingBindingSource;
        private ParkingDataSetTableAdapters.CarsParkingTableAdapter carsParkingTableAdapter;
    }
}