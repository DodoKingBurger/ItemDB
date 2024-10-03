namespace ItemDB
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tb_FIO = new System.Windows.Forms.TextBox();
			this.tb_Name = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.listView_Data = new System.Windows.Forms.ListView();
			this.ch_SerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_DecimalNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageDB = new System.Windows.Forms.TabPage();
			this.groupBoxAddRecord = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbAdd_CodeRegistr = new System.Windows.Forms.TextBox();
			this.bt_Add = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbAdd_CodeClass = new System.Windows.Forms.TextBox();
			this.label_DataAdd = new System.Windows.Forms.Label();
			this.label_DecimalNumber = new System.Windows.Forms.Label();
			this.label_Add_Info = new System.Windows.Forms.Label();
			this.label_Add_FIO = new System.Windows.Forms.Label();
			this.label_Add_Name = new System.Windows.Forms.Label();
			this.tbAdd_FIO = new System.Windows.Forms.TextBox();
			this.tbAdd_Name = new System.Windows.Forms.TextBox();
			this.groupBoxFilter = new System.Windows.Forms.GroupBox();
			this.bt_Reload = new System.Windows.Forms.Button();
			this.label_View_FIO = new System.Windows.Forms.Label();
			this.label_View_Name = new System.Windows.Forms.Label();
			this.flowLayoutPanel1.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPageDB.SuspendLayout();
			this.groupBoxAddRecord.SuspendLayout();
			this.groupBoxFilter.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_FIO
			// 
			this.tb_FIO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tb_FIO.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tb_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_FIO.Location = new System.Drawing.Point(22, 106);
			this.tb_FIO.Multiline = true;
			this.tb_FIO.Name = "tb_FIO";
			this.tb_FIO.Size = new System.Drawing.Size(279, 39);
			this.tb_FIO.TabIndex = 2;
			this.tb_FIO.UseWaitCursor = true;
			this.tb_FIO.TextChanged += new System.EventHandler(this.tb_FIO_TextChanged);
			// 
			// tb_Name
			// 
			this.tb_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tb_Name.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb_Name.Location = new System.Drawing.Point(22, 41);
			this.tb_Name.Multiline = true;
			this.tb_Name.Name = "tb_Name";
			this.tb_Name.Size = new System.Drawing.Size(279, 39);
			this.tb_Name.TabIndex = 1;
			this.tb_Name.UseWaitCursor = true;
			this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.listView_Data);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(935, 905);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// listView_Data
			// 
			this.listView_Data.AllowColumnReorder = true;
			this.listView_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView_Data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_SerialNumber,
            this.ch_DecimalNumber,
            this.ch_Name,
            this.ch_FIO,
            this.ch_Data});
			this.listView_Data.Cursor = System.Windows.Forms.Cursors.Default;
			this.listView_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView_Data.FullRowSelect = true;
			this.listView_Data.GridLines = true;
			this.listView_Data.HideSelection = false;
			this.listView_Data.Location = new System.Drawing.Point(3, 3);
			this.listView_Data.MaximumSize = new System.Drawing.Size(924, 897);
			this.listView_Data.MinimumSize = new System.Drawing.Size(924, 897);
			this.listView_Data.Name = "listView_Data";
			this.listView_Data.Size = new System.Drawing.Size(924, 897);
			this.listView_Data.TabIndex = 0;
			this.listView_Data.TileSize = new System.Drawing.Size(200, 100);
			this.listView_Data.UseCompatibleStateImageBehavior = false;
			this.listView_Data.View = System.Windows.Forms.View.Details;
			this.listView_Data.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_Data_ColumnWidthChanging);
			// 
			// ch_SerialNumber
			// 
			this.ch_SerialNumber.Text = "П/Н";
			this.ch_SerialNumber.Width = 77;
			// 
			// ch_DecimalNumber
			// 
			this.ch_DecimalNumber.Text = "Децимальный номер";
			this.ch_DecimalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ch_DecimalNumber.Width = 302;
			// 
			// ch_Name
			// 
			this.ch_Name.Text = "Наименование";
			this.ch_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ch_Name.Width = 214;
			// 
			// ch_FIO
			// 
			this.ch_FIO.Text = "ФИО";
			this.ch_FIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ch_FIO.Width = 178;
			// 
			// ch_Data
			// 
			this.ch_Data.Text = "Дата ";
			this.ch_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ch_Data.Width = 171;
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageDB);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1478, 944);
			this.tabControlMain.TabIndex = 5;
			// 
			// tabPageDB
			// 
			this.tabPageDB.Controls.Add(this.groupBoxAddRecord);
			this.tabPageDB.Controls.Add(this.groupBoxFilter);
			this.tabPageDB.Controls.Add(this.flowLayoutPanel1);
			this.tabPageDB.Location = new System.Drawing.Point(4, 29);
			this.tabPageDB.Name = "tabPageDB";
			this.tabPageDB.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDB.Size = new System.Drawing.Size(1470, 911);
			this.tabPageDB.TabIndex = 0;
			this.tabPageDB.Text = "База Данных";
			this.tabPageDB.UseVisualStyleBackColor = true;
			// 
			// groupBoxAddRecord
			// 
			this.groupBoxAddRecord.Controls.Add(this.label3);
			this.groupBoxAddRecord.Controls.Add(this.label2);
			this.groupBoxAddRecord.Controls.Add(this.tbAdd_CodeRegistr);
			this.groupBoxAddRecord.Controls.Add(this.bt_Add);
			this.groupBoxAddRecord.Controls.Add(this.label1);
			this.groupBoxAddRecord.Controls.Add(this.tbAdd_CodeClass);
			this.groupBoxAddRecord.Controls.Add(this.label_DataAdd);
			this.groupBoxAddRecord.Controls.Add(this.label_DecimalNumber);
			this.groupBoxAddRecord.Controls.Add(this.label_Add_Info);
			this.groupBoxAddRecord.Controls.Add(this.label_Add_FIO);
			this.groupBoxAddRecord.Controls.Add(this.label_Add_Name);
			this.groupBoxAddRecord.Controls.Add(this.tbAdd_FIO);
			this.groupBoxAddRecord.Controls.Add(this.tbAdd_Name);
			this.groupBoxAddRecord.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxAddRecord.Location = new System.Drawing.Point(938, 3);
			this.groupBoxAddRecord.Name = "groupBoxAddRecord";
			this.groupBoxAddRecord.Size = new System.Drawing.Size(529, 705);
			this.groupBoxAddRecord.TabIndex = 6;
			this.groupBoxAddRecord.TabStop = false;
			this.groupBoxAddRecord.Text = "Создания новой записи";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(182, 60);
			this.label3.TabIndex = 17;
			this.label3.Text = "Если пустой,\r\nто дается следующий \r\nкод автоматически.\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(200, 264);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(325, 58);
			this.label2.TabIndex = 16;
			this.label2.Text = "Код порядкового \r\nрегистрационного номера";
			// 
			// tbAdd_CodeRegistr
			// 
			this.tbAdd_CodeRegistr.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbAdd_CodeRegistr.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tbAdd_CodeRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbAdd_CodeRegistr.Location = new System.Drawing.Point(23, 264);
			this.tbAdd_CodeRegistr.Multiline = true;
			this.tbAdd_CodeRegistr.Name = "tbAdd_CodeRegistr";
			this.tbAdd_CodeRegistr.Size = new System.Drawing.Size(151, 39);
			this.tbAdd_CodeRegistr.TabIndex = 15;
			this.tbAdd_CodeRegistr.UseWaitCursor = true;
			this.tbAdd_CodeRegistr.TextChanged += new System.EventHandler(this.tbAdd_CodeRegistr_TextChanged);
			// 
			// bt_Add
			// 
			this.bt_Add.Cursor = System.Windows.Forms.Cursors.Cross;
			this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bt_Add.Location = new System.Drawing.Point(21, 388);
			this.bt_Add.Name = "bt_Add";
			this.bt_Add.Size = new System.Drawing.Size(151, 45);
			this.bt_Add.TabIndex = 14;
			this.bt_Add.Text = "Добавить";
			this.bt_Add.UseVisualStyleBackColor = true;
			this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(200, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(309, 58);
			this.label1.TabIndex = 13;
			this.label1.Text = "Код классификационной \r\nхарактеристики";
			// 
			// tbAdd_CodeClass
			// 
			this.tbAdd_CodeClass.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbAdd_CodeClass.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tbAdd_CodeClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbAdd_CodeClass.Location = new System.Drawing.Point(23, 183);
			this.tbAdd_CodeClass.Multiline = true;
			this.tbAdd_CodeClass.Name = "tbAdd_CodeClass";
			this.tbAdd_CodeClass.Size = new System.Drawing.Size(151, 39);
			this.tbAdd_CodeClass.TabIndex = 12;
			this.tbAdd_CodeClass.UseWaitCursor = true;
			this.tbAdd_CodeClass.TextChanged += new System.EventHandler(this.tbAdd_CodeClass_TextChanged);
			// 
			// label_DataAdd
			// 
			this.label_DataAdd.AutoSize = true;
			this.label_DataAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_DataAdd.Location = new System.Drawing.Point(17, 591);
			this.label_DataAdd.Name = "label_DataAdd";
			this.label_DataAdd.Size = new System.Drawing.Size(319, 29);
			this.label_DataAdd.TabIndex = 11;
			this.label_DataAdd.Text = "от - ____________________";
			// 
			// label_DecimalNumber
			// 
			this.label_DecimalNumber.AutoSize = true;
			this.label_DecimalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_DecimalNumber.Location = new System.Drawing.Point(16, 532);
			this.label_DecimalNumber.Name = "label_DecimalNumber";
			this.label_DecimalNumber.Size = new System.Drawing.Size(325, 29);
			this.label_DecimalNumber.TabIndex = 10;
			this.label_DecimalNumber.Text = "________________________";
			// 
			// label_Add_Info
			// 
			this.label_Add_Info.AutoSize = true;
			this.label_Add_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Add_Info.Location = new System.Drawing.Point(16, 460);
			this.label_Add_Info.Name = "label_Add_Info";
			this.label_Add_Info.Size = new System.Drawing.Size(315, 58);
			this.label_Add_Info.TabIndex = 9;
			this.label_Add_Info.Text = "Последний присвоенный \r\nдецимальный номер";
			// 
			// label_Add_FIO
			// 
			this.label_Add_FIO.AutoSize = true;
			this.label_Add_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Add_FIO.Location = new System.Drawing.Point(326, 119);
			this.label_Add_FIO.Name = "label_Add_FIO";
			this.label_Add_FIO.Size = new System.Drawing.Size(70, 29);
			this.label_Add_FIO.TabIndex = 8;
			this.label_Add_FIO.Text = "ФИО";
			// 
			// label_Add_Name
			// 
			this.label_Add_Name.AutoSize = true;
			this.label_Add_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Add_Name.Location = new System.Drawing.Point(326, 54);
			this.label_Add_Name.Name = "label_Add_Name";
			this.label_Add_Name.Size = new System.Drawing.Size(189, 29);
			this.label_Add_Name.TabIndex = 7;
			this.label_Add_Name.Text = "Наименование";
			// 
			// tbAdd_FIO
			// 
			this.tbAdd_FIO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbAdd_FIO.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tbAdd_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbAdd_FIO.Location = new System.Drawing.Point(22, 119);
			this.tbAdd_FIO.Multiline = true;
			this.tbAdd_FIO.Name = "tbAdd_FIO";
			this.tbAdd_FIO.Size = new System.Drawing.Size(279, 39);
			this.tbAdd_FIO.TabIndex = 6;
			this.tbAdd_FIO.UseWaitCursor = true;
			// 
			// tbAdd_Name
			// 
			this.tbAdd_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tbAdd_Name.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tbAdd_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbAdd_Name.Location = new System.Drawing.Point(22, 54);
			this.tbAdd_Name.Multiline = true;
			this.tbAdd_Name.Name = "tbAdd_Name";
			this.tbAdd_Name.Size = new System.Drawing.Size(279, 39);
			this.tbAdd_Name.TabIndex = 5;
			this.tbAdd_Name.UseWaitCursor = true;
			// 
			// groupBoxFilter
			// 
			this.groupBoxFilter.Controls.Add(this.bt_Reload);
			this.groupBoxFilter.Controls.Add(this.label_View_FIO);
			this.groupBoxFilter.Controls.Add(this.label_View_Name);
			this.groupBoxFilter.Controls.Add(this.tb_FIO);
			this.groupBoxFilter.Controls.Add(this.tb_Name);
			this.groupBoxFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBoxFilter.Location = new System.Drawing.Point(938, 709);
			this.groupBoxFilter.Name = "groupBoxFilter";
			this.groupBoxFilter.Size = new System.Drawing.Size(529, 199);
			this.groupBoxFilter.TabIndex = 5;
			this.groupBoxFilter.TabStop = false;
			this.groupBoxFilter.Text = "Пойск ";
			// 
			// bt_Reload
			// 
			this.bt_Reload.AutoSize = true;
			this.bt_Reload.Image = global::ItemDB.Properties.Resources.Reload;
			this.bt_Reload.Location = new System.Drawing.Point(22, 151);
			this.bt_Reload.Name = "bt_Reload";
			this.bt_Reload.Size = new System.Drawing.Size(34, 34);
			this.bt_Reload.TabIndex = 5;
			this.bt_Reload.UseVisualStyleBackColor = true;
			this.bt_Reload.Click += new System.EventHandler(this.bt_Reload_Click);
			// 
			// label_View_FIO
			// 
			this.label_View_FIO.AutoSize = true;
			this.label_View_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_View_FIO.Location = new System.Drawing.Point(326, 106);
			this.label_View_FIO.Name = "label_View_FIO";
			this.label_View_FIO.Size = new System.Drawing.Size(70, 29);
			this.label_View_FIO.TabIndex = 4;
			this.label_View_FIO.Text = "ФИО";
			// 
			// label_View_Name
			// 
			this.label_View_Name.AutoSize = true;
			this.label_View_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_View_Name.Location = new System.Drawing.Point(326, 37);
			this.label_View_Name.Name = "label_View_Name";
			this.label_View_Name.Size = new System.Drawing.Size(195, 58);
			this.label_View_Name.TabIndex = 3;
			this.label_View_Name.Text = "Наименование \r\nдатчика";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1478, 944);
			this.Controls.Add(this.tabControlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Item DB";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tabControlMain.ResumeLayout(false);
			this.tabPageDB.ResumeLayout(false);
			this.groupBoxAddRecord.ResumeLayout(false);
			this.groupBoxAddRecord.PerformLayout();
			this.groupBoxFilter.ResumeLayout(false);
			this.groupBoxFilter.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tb_FIO;
		private System.Windows.Forms.TextBox tb_Name;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.TabPage tabPageDB;
		private System.Windows.Forms.GroupBox groupBoxFilter;
		private System.Windows.Forms.GroupBox groupBoxAddRecord;
		private System.Windows.Forms.Button bt_Reload;
		private System.Windows.Forms.Label label_View_FIO;
		private System.Windows.Forms.Label label_View_Name;
		private System.Windows.Forms.Label label_DataAdd;
		private System.Windows.Forms.Label label_DecimalNumber;
		private System.Windows.Forms.Label label_Add_Info;
		private System.Windows.Forms.Label label_Add_FIO;
		private System.Windows.Forms.Label label_Add_Name;
		private System.Windows.Forms.TextBox tbAdd_FIO;
		private System.Windows.Forms.TextBox tbAdd_Name;
		private System.Windows.Forms.ListView listView_Data;
		private System.Windows.Forms.ColumnHeader ch_SerialNumber;
		private System.Windows.Forms.ColumnHeader ch_DecimalNumber;
		private System.Windows.Forms.ColumnHeader ch_Name;
		private System.Windows.Forms.ColumnHeader ch_FIO;
		private System.Windows.Forms.ColumnHeader ch_Data;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbAdd_CodeClass;
		private System.Windows.Forms.Button bt_Add;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbAdd_CodeRegistr;
	}
}

