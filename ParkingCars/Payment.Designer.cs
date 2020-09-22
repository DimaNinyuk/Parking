namespace ParkingCars
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.ViewPayments = new System.Windows.Forms.DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingNamberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectAllPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.Report = new System.Windows.Forms.Button();
            this.selectAllPaymentsTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.selectAllPaymentsTableAdapter();
            this.tableAdapterManager = new ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager();
            this.selectAllPaymentMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectAllPaymentMonthTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.selectAllPaymentMonthTableAdapter();
            this.CarsNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllPaymentMonthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPayments
            // 
            this.ViewPayments.AllowUserToAddRows = false;
            this.ViewPayments.AllowUserToDeleteRows = false;
            this.ViewPayments.AutoGenerateColumns = false;
            this.ViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.parkingNamberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.ViewPayments.DataSource = this.selectAllPaymentsBindingSource;
            this.ViewPayments.Location = new System.Drawing.Point(50, 83);
            this.ViewPayments.Name = "ViewPayments";
            this.ViewPayments.ReadOnly = true;
            this.ViewPayments.Size = new System.Drawing.Size(850, 367);
            this.ViewPayments.TabIndex = 13;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "Код клиента";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkingNamberDataGridViewTextBoxColumn
            // 
            this.parkingNamberDataGridViewTextBoxColumn.DataPropertyName = "ParkingNamber";
            this.parkingNamberDataGridViewTextBoxColumn.HeaderText = "Номер парковки";
            this.parkingNamberDataGridViewTextBoxColumn.Name = "parkingNamberDataGridViewTextBoxColumn";
            this.parkingNamberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // selectAllPaymentsBindingSource
            // 
            this.selectAllPaymentsBindingSource.DataMember = "selectAllPayments";
            this.selectAllPaymentsBindingSource.DataSource = this.parkingDataSet;
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report
            // 
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Location = new System.Drawing.Point(120, 15);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(175, 45);
            this.Report.TabIndex = 14;
            this.Report.Text = "Отчет";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // selectAllPaymentsTableAdapter
            // 
            this.selectAllPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsParkingTableAdapter = null;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ParkingTableAdapter = null;
            this.tableAdapterManager.PaymentsChecksParkingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksTableAdapter = null;
            // 
            // selectAllPaymentMonthBindingSource
            // 
            this.selectAllPaymentMonthBindingSource.DataMember = "selectAllPaymentMonth";
            this.selectAllPaymentMonthBindingSource.DataSource = this.parkingDataSet;
            // 
            // selectAllPaymentMonthTableAdapter
            // 
            this.selectAllPaymentMonthTableAdapter.ClearBeforeFill = true;
            // 
            // CarsNumber
            // 
            this.CarsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsNumber.Location = new System.Drawing.Point(486, 19);
            this.CarsNumber.Name = "CarsNumber";
            this.CarsNumber.Size = new System.Drawing.Size(119, 31);
            this.CarsNumber.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(303, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер парковки";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(611, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(702, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingCars.Properties.Resources.Без_названия;
            this.ClientSize = new System.Drawing.Size(953, 467);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CarsNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.ViewPayments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectAllPaymentMonthBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ViewPayments;
        private System.Windows.Forms.Button Report;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource selectAllPaymentsBindingSource;
        private ParkingDataSetTableAdapters.selectAllPaymentsTableAdapter selectAllPaymentsTableAdapter;
        private ParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingNamberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource selectAllPaymentMonthBindingSource;
        private ParkingDataSetTableAdapters.selectAllPaymentMonthTableAdapter selectAllPaymentMonthTableAdapter;
        private System.Windows.Forms.TextBox CarsNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}