namespace ParkingCars
{
    partial class Debtor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debtor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Report = new System.Windows.Forms.Button();
            this.CarsNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.selectDebortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectDebortTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.selectDebortTableAdapter();
            this.tableAdapterManager = new ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager();
            this.количествонужныйплатежейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоплатежейDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.долгDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDebortBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.количествонужныйплатежейDataGridViewTextBoxColumn,
            this.количествоплатежейDataGridViewTextBoxColumn,
            this.долгDataGridViewTextBoxColumn,
            this.carsNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectDebortBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(519, 367);
            this.dataGridView1.TabIndex = 7;
            // 
            // Report
            // 
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.Location = new System.Drawing.Point(524, 13);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(103, 45);
            this.Report.TabIndex = 11;
            this.Report.Text = "Отчет";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // CarsNumber
            // 
            this.CarsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsNumber.Location = new System.Drawing.Point(211, 20);
            this.CarsNumber.Name = "CarsNumber";
            this.CarsNumber.Size = new System.Drawing.Size(125, 31);
            this.CarsNumber.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер телефона";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.Location = new System.Drawing.Point(342, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(85, 45);
            this.Search.TabIndex = 16;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(433, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.allList_Click);
            // 
            // parkingDataSet
            // 
            this.parkingDataSet.DataSetName = "ParkingDataSet";
            this.parkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectDebortBindingSource
            // 
            this.selectDebortBindingSource.DataMember = "selectDebort";
            this.selectDebortBindingSource.DataSource = this.parkingDataSet;
            // 
            // selectDebortTableAdapter
            // 
            this.selectDebortTableAdapter.ClearBeforeFill = true;
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
            // количествонужныйплатежейDataGridViewTextBoxColumn
            // 
            this.количествонужныйплатежейDataGridViewTextBoxColumn.DataPropertyName = "Количество_нужный_платежей";
            this.количествонужныйплатежейDataGridViewTextBoxColumn.HeaderText = "Количество_нужный_платежей";
            this.количествонужныйплатежейDataGridViewTextBoxColumn.Name = "количествонужныйплатежейDataGridViewTextBoxColumn";
            this.количествонужныйплатежейDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоплатежейDataGridViewTextBoxColumn
            // 
            this.количествоплатежейDataGridViewTextBoxColumn.DataPropertyName = "Количество_платежей";
            this.количествоплатежейDataGridViewTextBoxColumn.HeaderText = "Количество_платежей";
            this.количествоплатежейDataGridViewTextBoxColumn.Name = "количествоплатежейDataGridViewTextBoxColumn";
            this.количествоплатежейDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // долгDataGridViewTextBoxColumn
            // 
            this.долгDataGridViewTextBoxColumn.DataPropertyName = "Долг";
            this.долгDataGridViewTextBoxColumn.HeaderText = "Долг";
            this.долгDataGridViewTextBoxColumn.Name = "долгDataGridViewTextBoxColumn";
            this.долгDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carsNumberDataGridViewTextBoxColumn
            // 
            this.carsNumberDataGridViewTextBoxColumn.DataPropertyName = "CarsNumber";
            this.carsNumberDataGridViewTextBoxColumn.HeaderText = "CarsNumber";
            this.carsNumberDataGridViewTextBoxColumn.Name = "carsNumberDataGridViewTextBoxColumn";
            this.carsNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Debtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingCars.Properties.Resources.Без_названия;
            this.ClientSize = new System.Drawing.Size(640, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CarsNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Debtor";
            this.Text = "Debtor";
            this.Load += new System.EventHandler(this.Debtor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectDebortBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.TextBox CarsNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button2;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource selectDebortBindingSource;
        private ParkingDataSetTableAdapters.selectDebortTableAdapter selectDebortTableAdapter;
        private ParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествонужныйплатежейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоплатежейDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn долгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsNumberDataGridViewTextBoxColumn;
    }
}