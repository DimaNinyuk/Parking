namespace ParkingCars
{
    partial class ViewFreedomPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFreedomPlace));
            this.ViewFreedomPlacies = new System.Windows.Forms.DataGridView();
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.ParkingTableAdapter();
            this.tableAdapterManager = new ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager();
            this.parkingNamberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFreedomPlacies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewFreedomPlacies
            // 
            this.ViewFreedomPlacies.AllowUserToAddRows = false;
            this.ViewFreedomPlacies.AllowUserToDeleteRows = false;
            this.ViewFreedomPlacies.AutoGenerateColumns = false;
            this.ViewFreedomPlacies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFreedomPlacies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkingNamberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.carsNumberDataGridViewTextBoxColumn});
            this.ViewFreedomPlacies.DataSource = this.parkingBindingSource;
            this.ViewFreedomPlacies.Location = new System.Drawing.Point(12, 12);
            this.ViewFreedomPlacies.Name = "ViewFreedomPlacies";
            this.ViewFreedomPlacies.ReadOnly = true;
            this.ViewFreedomPlacies.Size = new System.Drawing.Size(347, 367);
            this.ViewFreedomPlacies.TabIndex = 7;
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
            // parkingNamberDataGridViewTextBoxColumn
            // 
            this.parkingNamberDataGridViewTextBoxColumn.DataPropertyName = "ParkingNamber";
            this.parkingNamberDataGridViewTextBoxColumn.HeaderText = "Номер парковки";
            this.parkingNamberDataGridViewTextBoxColumn.Name = "parkingNamberDataGridViewTextBoxColumn";
            this.parkingNamberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carsNumberDataGridViewTextBoxColumn
            // 
            this.carsNumberDataGridViewTextBoxColumn.DataPropertyName = "CarsNumber";
            this.carsNumberDataGridViewTextBoxColumn.HeaderText = "Номер машины";
            this.carsNumberDataGridViewTextBoxColumn.Name = "carsNumberDataGridViewTextBoxColumn";
            this.carsNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewFreedomPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingCars.Properties.Resources.Без_названия;
            this.ClientSize = new System.Drawing.Size(366, 391);
            this.Controls.Add(this.ViewFreedomPlacies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewFreedomPlace";
            this.Text = "Просмотр свободных мест";
            this.Load += new System.EventHandler(this.ViewFreedomPlace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewFreedomPlacies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewFreedomPlacies;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private ParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private ParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkingNamberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsNumberDataGridViewTextBoxColumn;
    }
}