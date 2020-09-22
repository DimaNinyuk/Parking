namespace ParkingCars
{
    partial class MainOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainOperator));
            this.CarsNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Vezd = new System.Windows.Forms.Button();
            this.Viezd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewFreedomPlaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разместитьНаПарковкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьПлатежаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingDataSet = new ParkingCars.ParkingDataSet();
            this.parkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.ParkingTableAdapter();
            this.tableAdapterManager = new ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager();
            this.carsParkingTableAdapter = new ParkingCars.ParkingDataSetTableAdapters.CarsParkingTableAdapter();
            this.carsParkingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsParkingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CarsNumber
            // 
            this.CarsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsNumber.Location = new System.Drawing.Point(203, 38);
            this.CarsNumber.Name = "CarsNumber";
            this.CarsNumber.Size = new System.Drawing.Size(257, 31);
            this.CarsNumber.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер машины";
            // 
            // Vezd
            // 
            this.Vezd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vezd.Location = new System.Drawing.Point(115, 111);
            this.Vezd.Name = "Vezd";
            this.Vezd.Size = new System.Drawing.Size(106, 31);
            this.Vezd.TabIndex = 10;
            this.Vezd.Text = "Выезд";
            this.Vezd.UseVisualStyleBackColor = true;
            this.Vezd.Click += new System.EventHandler(this.buttonVezd_Click);
            // 
            // Viezd
            // 
            this.Viezd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Viezd.Location = new System.Drawing.Point(276, 110);
            this.Viezd.Name = "Viezd";
            this.Viezd.Size = new System.Drawing.Size(106, 32);
            this.Viezd.TabIndex = 11;
            this.Viezd.Text = "Заезд";
            this.Viezd.UseVisualStyleBackColor = true;
            this.Viezd.Click += new System.EventHandler(this.buttonViezd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewFreedomPlaceToolStripMenuItem,
            this.разместитьНаПарковкуToolStripMenuItem,
            this.записьПлатежаToolStripMenuItem,
            this.просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "Опции";
            // 
            // ViewFreedomPlaceToolStripMenuItem
            // 
            this.ViewFreedomPlaceToolStripMenuItem.Name = "ViewFreedomPlaceToolStripMenuItem";
            this.ViewFreedomPlaceToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.ViewFreedomPlaceToolStripMenuItem.Text = "Просмотр свободных мест";
            this.ViewFreedomPlaceToolStripMenuItem.Click += new System.EventHandler(this.ViewFreedomPlaceToolStripMenuItem_Click);
            // 
            // разместитьНаПарковкуToolStripMenuItem
            // 
            this.разместитьНаПарковкуToolStripMenuItem.Name = "разместитьНаПарковкуToolStripMenuItem";
            this.разместитьНаПарковкуToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.разместитьНаПарковкуToolStripMenuItem.Text = "Разместить на парковку";
            this.разместитьНаПарковкуToolStripMenuItem.Click += new System.EventHandler(this.addParkingToolStripMenuItem_Click);
            // 
            // записьПлатежаToolStripMenuItem
            // 
            this.записьПлатежаToolStripMenuItem.Name = "записьПлатежаToolStripMenuItem";
            this.записьПлатежаToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.записьПлатежаToolStripMenuItem.Text = "Запись платежа";
            this.записьПлатежаToolStripMenuItem.Click += new System.EventHandler(this.addPaymentToolStripMenuItem_Click);
            // 
            // просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem
            // 
            this.просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem.Name = "просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem";
            this.просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem.Text = "Просмотр даты и время заезда и выезда на автостоянку";
            this.просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem.Click += new System.EventHandler(this.VievVizdViezdToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.tableAdapterManager.CarsParkingTableAdapter = this.carsParkingTableAdapter;
            this.tableAdapterManager.CarsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.ParkingTableAdapter = this.parkingTableAdapter;
            this.tableAdapterManager.PaymentsChecksParkingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ParkingCars.ParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorksTableAdapter = null;
            // 
            // carsParkingTableAdapter
            // 
            this.carsParkingTableAdapter.ClearBeforeFill = true;
            // 
            // carsParkingBindingSource
            // 
            this.carsParkingBindingSource.DataMember = "CarsParking";
            this.carsParkingBindingSource.DataSource = this.parkingDataSet;
            // 
            // MainOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkingCars.Properties.Resources.Без_названия;
            this.ClientSize = new System.Drawing.Size(488, 172);
            this.Controls.Add(this.Viezd);
            this.Controls.Add(this.Vezd);
            this.Controls.Add(this.CarsNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainOperator";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainOperator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsParkingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CarsNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Vezd;
        private System.Windows.Forms.Button Viezd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ViewFreedomPlaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разместитьНаПарковкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьПлатежаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрДатыИВремяЗаездаИВыездаНаАвтостоянкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private ParkingDataSet parkingDataSet;
        private System.Windows.Forms.BindingSource parkingBindingSource;
        private ParkingDataSetTableAdapters.ParkingTableAdapter parkingTableAdapter;
        private ParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ParkingDataSetTableAdapters.CarsParkingTableAdapter carsParkingTableAdapter;
        private System.Windows.Forms.BindingSource carsParkingBindingSource;
    }
}