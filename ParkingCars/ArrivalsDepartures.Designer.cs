namespace ParkingCars
{
    partial class ArrivalsDepartures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrivalsDepartures));
            this.ViewArrivalDeparture = new System.Windows.Forms.DataGridView();
            this.dateTimeDepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeEntryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parkingNamberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsParkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.DateS = new System.Windows.Forms.DateTimePicker();
            this.DateP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.carsParkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.CarsParkingTableAdapter();
            this.tableAdapterManager = new ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewArrivalDeparture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsParkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewArrivalDeparture
            // 
            this.ViewArrivalDeparture.AllowUserToAddRows = false;
            this.ViewArrivalDeparture.AllowUserToDeleteRows = false;
            this.ViewArrivalDeparture.AutoGenerateColumns = false;
            this.ViewArrivalDeparture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewArrivalDeparture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTimeDepartureDataGridViewTextBoxColumn,
            this.dateTimeEntryDataGridViewTextBoxColumn,
            this.carsNumberDataGridViewTextBoxColumn,
            this.parkingNamberDataGridViewTextBoxColumn,
            this.operatorIdDataGridViewTextBoxColumn});
            this.ViewArrivalDeparture.DataSource = this.carsParkingBindingSource;
            this.ViewArrivalDeparture.Location = new System.Drawing.Point(12, 127);
            this.ViewArrivalDeparture.Name = "ViewArrivalDeparture";
            this.ViewArrivalDeparture.ReadOnly = true;
            this.ViewArrivalDeparture.Size = new System.Drawing.Size(551, 367);
            this.ViewArrivalDeparture.TabIndex = 7;
            // 
            // dateTimeDepartureDataGridViewTextBoxColumn
            // 
            this.dateTimeDepartureDataGridViewTextBoxColumn.DataPropertyName = "DateTimeDeparture";
            this.dateTimeDepartureDataGridViewTextBoxColumn.HeaderText = "Дата и время выезда";
            this.dateTimeDepartureDataGridViewTextBoxColumn.Name = "dateTimeDepartureDataGridViewTextBoxColumn";
            this.dateTimeDepartureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateTimeEntryDataGridViewTextBoxColumn
            // 
            this.dateTimeEntryDataGridViewTextBoxColumn.DataPropertyName = "DateTimeEntry";
            this.dateTimeEntryDataGridViewTextBoxColumn.HeaderText = "Дата и время заезда";
            this.dateTimeEntryDataGridViewTextBoxColumn.Name = "dateTimeEntryDataGridViewTextBoxColumn";
            this.dateTimeEntryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carsNumberDataGridViewTextBoxColumn
            // 
            this.carsNumberDataGridViewTextBoxColumn.DataPropertyName = "CarsNumber";
            this.carsNumberDataGridViewTextBoxColumn.HeaderText = "Номер машины";
            this.carsNumberDataGridViewTextBoxColumn.Name = "carsNumberDataGridViewTextBoxColumn";
            this.carsNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parkingNamberDataGridViewTextBoxColumn
            // 
            this.parkingNamberDataGridViewTextBoxColumn.DataPropertyName = "ParkingNamber";
            this.parkingNamberDataGridViewTextBoxColumn.HeaderText = "Номер паркови";
            this.parkingNamberDataGridViewTextBoxColumn.Name = "parkingNamberDataGridViewTextBoxColumn";
            this.parkingNamberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operatorIdDataGridViewTextBoxColumn
            // 
            this.operatorIdDataGridViewTextBoxColumn.DataPropertyName = "OperatorId";
            this.operatorIdDataGridViewTextBoxColumn.HeaderText = "Код оператора";
            this.operatorIdDataGridViewTextBoxColumn.Name = "operatorIdDataGridViewTextBoxColumn";
            this.operatorIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carsParkingBindingSource
            // 
            this.carsParkingBindingSource.DataMember = "CarsParking";
            this.carsParkingBindingSource.DataSource = this.parkingDataSet;
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DateS
            // 
            this.DateS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DateS.Location = new System.Drawing.Point(105, 31);
            this.DateS.Name = "DateS";
            this.DateS.Size = new System.Drawing.Size(235, 31);
            this.DateS.TabIndex = 8;
            // 
            // DateP
            // 
            this.DateP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.DateP.Location = new System.Drawing.Point(110, 94);
            this.DateP.Name = "DateP";
            this.DateP.Size = new System.Drawing.Size(237, 31);
            this.DateP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(105, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата с";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дата по";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(392, 46);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(87, 45);
            this.Search.TabIndex = 12;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Report
            // 
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Location = new System.Drawing.Point(12, 55);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(87, 45);
            this.Report.TabIndex = 13;
            this.Report.Text = "Отчет";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // carsParkingTableAdapter
            // 
            this.carsParkingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarsParkingTableAdapter = this.carsParkingTableAdapter;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = null;
            this.tableAdapterManager.PaymentsChecksParkingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksTableAdapter = null;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.allList_Click);
            // 
            // ArrivalsDepartures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingCars.Properties.Resources.Без_названия;
            this.ClientSize = new System.Drawing.Size(568, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateP);
            this.Controls.Add(this.DateS);
            this.Controls.Add(this.ViewArrivalDeparture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArrivalsDepartures";
            this.Text = "Заезды и выезды";
            this.Load += new System.EventHandler(this.ArrivalsDepartures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewArrivalDeparture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsParkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewArrivalDeparture;
        private System.Windows.Forms.DateTimePicker DateS;
        private System.Windows.Forms.DateTimePicker DateP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Report;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource carsParkingBindingSource;
        private ParkingDataSetTableAdapters.CarsParkingTableAdapter carsParkingTableAdapter;
        private ParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeEntryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingNamberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}