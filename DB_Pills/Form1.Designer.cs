namespace DB_Pills
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codepillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namepillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applyingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproducerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pillsnameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_PILLSDataSet = new DB_Pills.DB_PILLSDataSet();
            this.pills_nameTableAdapter = new DB_Pills.DB_PILLSDataSetTableAdapters.Pills_nameTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.codepillDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeproviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codedeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new DB_Pills.DB_PILLSDataSetTableAdapters.ProvidersTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.codeproviderDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savednameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOleaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adressTableAdapter = new DB_Pills.DB_PILLSDataSetTableAdapters.AdressTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСТаблицамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблеткиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адресаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillsnameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PILLSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepillDataGridViewTextBoxColumn,
            this.namepillDataGridViewTextBoxColumn,
            this.applyingDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.nameproducerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pillsnameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codepillDataGridViewTextBoxColumn
            // 
            this.codepillDataGridViewTextBoxColumn.DataPropertyName = "Code_pill";
            this.codepillDataGridViewTextBoxColumn.HeaderText = "Code_pill";
            this.codepillDataGridViewTextBoxColumn.Name = "codepillDataGridViewTextBoxColumn";
            // 
            // namepillDataGridViewTextBoxColumn
            // 
            this.namepillDataGridViewTextBoxColumn.DataPropertyName = "name_pill";
            this.namepillDataGridViewTextBoxColumn.HeaderText = "name_pill";
            this.namepillDataGridViewTextBoxColumn.Name = "namepillDataGridViewTextBoxColumn";
            // 
            // applyingDataGridViewTextBoxColumn
            // 
            this.applyingDataGridViewTextBoxColumn.DataPropertyName = "applying";
            this.applyingDataGridViewTextBoxColumn.HeaderText = "applying";
            this.applyingDataGridViewTextBoxColumn.Name = "applyingDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameproducerDataGridViewTextBoxColumn
            // 
            this.nameproducerDataGridViewTextBoxColumn.DataPropertyName = "name_producer";
            this.nameproducerDataGridViewTextBoxColumn.HeaderText = "name_producer";
            this.nameproducerDataGridViewTextBoxColumn.Name = "nameproducerDataGridViewTextBoxColumn";
            // 
            // pillsnameBindingSource
            // 
            this.pillsnameBindingSource.DataMember = "Pills_name";
            this.pillsnameBindingSource.DataSource = this.dB_PILLSDataSet;
            // 
            // dB_PILLSDataSet
            // 
            this.dB_PILLSDataSet.DataSetName = "DB_PILLSDataSet";
            this.dB_PILLSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pills_nameTableAdapter
            // 
            this.pills_nameTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codepillDataGridViewTextBoxColumn1,
            this.codeproviderDataGridViewTextBoxColumn,
            this.datedeliveryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.codedeliveryDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.providersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 184);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(647, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // codepillDataGridViewTextBoxColumn1
            // 
            this.codepillDataGridViewTextBoxColumn1.DataPropertyName = "Code_pill";
            this.codepillDataGridViewTextBoxColumn1.HeaderText = "Code_pill";
            this.codepillDataGridViewTextBoxColumn1.Name = "codepillDataGridViewTextBoxColumn1";
            // 
            // codeproviderDataGridViewTextBoxColumn
            // 
            this.codeproviderDataGridViewTextBoxColumn.DataPropertyName = "Code_provider";
            this.codeproviderDataGridViewTextBoxColumn.HeaderText = "Code_provider";
            this.codeproviderDataGridViewTextBoxColumn.Name = "codeproviderDataGridViewTextBoxColumn";
            // 
            // datedeliveryDataGridViewTextBoxColumn
            // 
            this.datedeliveryDataGridViewTextBoxColumn.DataPropertyName = "Date_delivery";
            this.datedeliveryDataGridViewTextBoxColumn.HeaderText = "Date_delivery";
            this.datedeliveryDataGridViewTextBoxColumn.Name = "datedeliveryDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // codedeliveryDataGridViewTextBoxColumn
            // 
            this.codedeliveryDataGridViewTextBoxColumn.DataPropertyName = "Code_delivery";
            this.codedeliveryDataGridViewTextBoxColumn.HeaderText = "Code_delivery";
            this.codedeliveryDataGridViewTextBoxColumn.Name = "codedeliveryDataGridViewTextBoxColumn";
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.dB_PILLSDataSet;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeproviderDataGridViewTextBoxColumn1,
            this.savednameDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.fIOleaderDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.adressBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(11, 340);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(648, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // codeproviderDataGridViewTextBoxColumn1
            // 
            this.codeproviderDataGridViewTextBoxColumn1.DataPropertyName = "Code_provider";
            this.codeproviderDataGridViewTextBoxColumn1.HeaderText = "Code_provider";
            this.codeproviderDataGridViewTextBoxColumn1.Name = "codeproviderDataGridViewTextBoxColumn1";
            // 
            // savednameDataGridViewTextBoxColumn
            // 
            this.savednameDataGridViewTextBoxColumn.DataPropertyName = "Saved_name";
            this.savednameDataGridViewTextBoxColumn.HeaderText = "Saved_name";
            this.savednameDataGridViewTextBoxColumn.Name = "savednameDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Full_name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // fIOleaderDataGridViewTextBoxColumn
            // 
            this.fIOleaderDataGridViewTextBoxColumn.DataPropertyName = "FIO_leader";
            this.fIOleaderDataGridViewTextBoxColumn.HeaderText = "FIO_leader";
            this.fIOleaderDataGridViewTextBoxColumn.Name = "fIOleaderDataGridViewTextBoxColumn";
            // 
            // adressBindingSource
            // 
            this.adressBindingSource.DataMember = "Adress";
            this.adressBindingSource.DataSource = this.dB_PILLSDataSet;
            // 
            // adressTableAdapter
            // 
            this.adressTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТаблицамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСТаблицамиToolStripMenuItem
            // 
            this.работаСТаблицамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблеткиToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.адресаToolStripMenuItem});
            this.работаСТаблицамиToolStripMenuItem.Name = "работаСТаблицамиToolStripMenuItem";
            this.работаСТаблицамиToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.работаСТаблицамиToolStripMenuItem.Text = "Работа с таблицами";
            // 
            // таблеткиToolStripMenuItem
            // 
            this.таблеткиToolStripMenuItem.Name = "таблеткиToolStripMenuItem";
            this.таблеткиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.таблеткиToolStripMenuItem.Text = "Таблетки";
            this.таблеткиToolStripMenuItem.Click += new System.EventHandler(this.таблеткиToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // адресаToolStripMenuItem
            // 
            this.адресаToolStripMenuItem.Name = "адресаToolStripMenuItem";
            this.адресаToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.адресаToolStripMenuItem.Text = "Адреса";
            this.адресаToolStripMenuItem.Click += new System.EventHandler(this.адресаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "БД Таблетки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillsnameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_PILLSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_PILLSDataSet dB_PILLSDataSet;
        private System.Windows.Forms.BindingSource pillsnameBindingSource;
        private DB_PILLSDataSetTableAdapters.Pills_nameTableAdapter pills_nameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namepillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applyingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproducerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private DB_PILLSDataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codepillDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codedeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource adressBindingSource;
        private DB_PILLSDataSetTableAdapters.AdressTableAdapter adressTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproviderDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn savednameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOleaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСТаблицамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблеткиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адресаToolStripMenuItem;
    }
}

