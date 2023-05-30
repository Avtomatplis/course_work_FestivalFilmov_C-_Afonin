namespace course_work_FestivalFilmov_Afonin
{
    partial class GuestFestivalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestFestivalForm));
            this.ButtonCloseGuestTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteGuest = new System.Windows.Forms.Button();
            this.ButtonDeleteGuest = new System.Windows.Forms.Button();
            this.ButtonCreateGuest = new System.Windows.Forms.Button();
            this.TextBoxCountGuest = new System.Windows.Forms.TextBox();
            this.labelCountGuest = new System.Windows.Forms.Label();
            this.dataGridViewGuestTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFilterGuest = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxKolvoSearchGuest = new System.Windows.Forms.TextBox();
            this.labelKolvoSearchGuest = new System.Windows.Forms.Label();
            this.TextBoxSearchGuest = new System.Windows.Forms.TextBox();
            this.ButtonResetGuest = new System.Windows.Forms.Button();
            this.ButtonSearchGuest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxSearchGuest = new System.Windows.Forms.ComboBox();
            this.labelSearchGuest = new System.Windows.Forms.Label();
            this.ComboBoxFilterGuest = new System.Windows.Forms.ComboBox();
            this.TextBoxFilterGuest = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFilterShowGuest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCloseGuestTable
            // 
            this.ButtonCloseGuestTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseGuestTable.BackColor = System.Drawing.Color.Cornsilk;
            this.ButtonCloseGuestTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonCloseGuestTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseGuestTable.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.ButtonCloseGuestTable.Location = new System.Drawing.Point(848, 609);
            this.ButtonCloseGuestTable.Name = "ButtonCloseGuestTable";
            this.ButtonCloseGuestTable.Size = new System.Drawing.Size(136, 48);
            this.ButtonCloseGuestTable.TabIndex = 13;
            this.ButtonCloseGuestTable.Text = "Закрыть форму";
            this.ButtonCloseGuestTable.UseVisualStyleBackColor = false;
            this.ButtonCloseGuestTable.Click += new System.EventHandler(this.ButtonCloseGuestTable_Click);
            // 
            // ButtonAllDeleteGuest
            // 
            this.ButtonAllDeleteGuest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonAllDeleteGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonAllDeleteGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAllDeleteGuest.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonAllDeleteGuest.Location = new System.Drawing.Point(11, 92);
            this.ButtonAllDeleteGuest.Name = "ButtonAllDeleteGuest";
            this.ButtonAllDeleteGuest.Size = new System.Drawing.Size(129, 54);
            this.ButtonAllDeleteGuest.TabIndex = 12;
            this.ButtonAllDeleteGuest.Text = "Удалить всех гостей";
            this.ButtonAllDeleteGuest.UseVisualStyleBackColor = false;
            this.ButtonAllDeleteGuest.Click += new System.EventHandler(this.ButtonAllDeleteGuest_Click);
            // 
            // ButtonDeleteGuest
            // 
            this.ButtonDeleteGuest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonDeleteGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonDeleteGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteGuest.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonDeleteGuest.Location = new System.Drawing.Point(159, 26);
            this.ButtonDeleteGuest.Name = "ButtonDeleteGuest";
            this.ButtonDeleteGuest.Size = new System.Drawing.Size(123, 55);
            this.ButtonDeleteGuest.TabIndex = 11;
            this.ButtonDeleteGuest.Text = "Удалить гостя";
            this.ButtonDeleteGuest.UseVisualStyleBackColor = false;
            this.ButtonDeleteGuest.Click += new System.EventHandler(this.ButtonDeleteGuest_Click);
            // 
            // ButtonCreateGuest
            // 
            this.ButtonCreateGuest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonCreateGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonCreateGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateGuest.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonCreateGuest.Location = new System.Drawing.Point(11, 26);
            this.ButtonCreateGuest.Name = "ButtonCreateGuest";
            this.ButtonCreateGuest.Size = new System.Drawing.Size(129, 55);
            this.ButtonCreateGuest.TabIndex = 10;
            this.ButtonCreateGuest.Text = "Добавить гостя";
            this.ButtonCreateGuest.UseVisualStyleBackColor = false;
            this.ButtonCreateGuest.Click += new System.EventHandler(this.ButtonCreateGuest_Click);
            // 
            // TextBoxCountGuest
            // 
            this.TextBoxCountGuest.Location = new System.Drawing.Point(169, 154);
            this.TextBoxCountGuest.Name = "TextBoxCountGuest";
            this.TextBoxCountGuest.Size = new System.Drawing.Size(113, 25);
            this.TextBoxCountGuest.TabIndex = 9;
            // 
            // labelCountGuest
            // 
            this.labelCountGuest.AutoSize = true;
            this.labelCountGuest.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.labelCountGuest.ForeColor = System.Drawing.Color.Crimson;
            this.labelCountGuest.Location = new System.Drawing.Point(8, 157);
            this.labelCountGuest.Name = "labelCountGuest";
            this.labelCountGuest.Size = new System.Drawing.Size(141, 17);
            this.labelCountGuest.TabIndex = 8;
            this.labelCountGuest.Text = "Количество гостей";
            // 
            // dataGridViewGuestTable
            // 
            this.dataGridViewGuestTable.AllowUserToAddRows = false;
            this.dataGridViewGuestTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGuestTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGuestTable.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewGuestTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGuestTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridViewGuestTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGuestTable.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewGuestTable.Name = "dataGridViewGuestTable";
            this.dataGridViewGuestTable.ReadOnly = true;
            this.dataGridViewGuestTable.RowHeadersVisible = false;
            this.dataGridViewGuestTable.RowHeadersWidth = 51;
            this.dataGridViewGuestTable.RowTemplate.Height = 24;
            this.dataGridViewGuestTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuestTable.Size = new System.Drawing.Size(966, 323);
            this.dataGridViewGuestTable.TabIndex = 7;
            this.dataGridViewGuestTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuestTable_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя гостя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия гостя";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Электронная почта гостя";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Номер места гостя";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // labelFilterGuest
            // 
            this.labelFilterGuest.AutoSize = true;
            this.labelFilterGuest.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.labelFilterGuest.ForeColor = System.Drawing.Color.Crimson;
            this.labelFilterGuest.Location = new System.Drawing.Point(6, 29);
            this.labelFilterGuest.Name = "labelFilterGuest";
            this.labelFilterGuest.Size = new System.Drawing.Size(132, 17);
            this.labelFilterGuest.TabIndex = 9;
            this.labelFilterGuest.Text = "Фильтрация поля";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.TextBoxKolvoSearchGuest);
            this.groupBox3.Controls.Add(this.labelKolvoSearchGuest);
            this.groupBox3.Controls.Add(this.TextBoxSearchGuest);
            this.groupBox3.Controls.Add(this.ButtonResetGuest);
            this.groupBox3.Controls.Add(this.ButtonSearchGuest);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.ComboBoxSearchGuest);
            this.groupBox3.Controls.Add(this.labelSearchGuest);
            this.groupBox3.Controls.Add(this.ComboBoxFilterGuest);
            this.groupBox3.Controls.Add(this.labelFilterGuest);
            this.groupBox3.Controls.Add(this.TextBoxFilterGuest);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(418, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 197);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск и Фильтрация";
            // 
            // TextBoxKolvoSearchGuest
            // 
            this.TextBoxKolvoSearchGuest.Location = new System.Drawing.Point(257, 148);
            this.TextBoxKolvoSearchGuest.Name = "TextBoxKolvoSearchGuest";
            this.TextBoxKolvoSearchGuest.ReadOnly = true;
            this.TextBoxKolvoSearchGuest.Size = new System.Drawing.Size(85, 25);
            this.TextBoxKolvoSearchGuest.TabIndex = 33;
            this.TextBoxKolvoSearchGuest.Visible = false;
            // 
            // labelKolvoSearchGuest
            // 
            this.labelKolvoSearchGuest.AutoSize = true;
            this.labelKolvoSearchGuest.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.labelKolvoSearchGuest.ForeColor = System.Drawing.Color.Crimson;
            this.labelKolvoSearchGuest.Location = new System.Drawing.Point(6, 151);
            this.labelKolvoSearchGuest.Name = "labelKolvoSearchGuest";
            this.labelKolvoSearchGuest.Size = new System.Drawing.Size(232, 17);
            this.labelKolvoSearchGuest.TabIndex = 32;
            this.labelKolvoSearchGuest.Text = "Количество найденных записей";
            this.labelKolvoSearchGuest.Visible = false;
            // 
            // TextBoxSearchGuest
            // 
            this.TextBoxSearchGuest.Enabled = false;
            this.TextBoxSearchGuest.Location = new System.Drawing.Point(165, 106);
            this.TextBoxSearchGuest.Name = "TextBoxSearchGuest";
            this.TextBoxSearchGuest.Size = new System.Drawing.Size(177, 25);
            this.TextBoxSearchGuest.TabIndex = 31;
            this.TextBoxSearchGuest.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtonResetGuest
            // 
            this.ButtonResetGuest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonResetGuest.Enabled = false;
            this.ButtonResetGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonResetGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResetGuest.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonResetGuest.Location = new System.Drawing.Point(377, 129);
            this.ButtonResetGuest.Name = "ButtonResetGuest";
            this.ButtonResetGuest.Size = new System.Drawing.Size(173, 44);
            this.ButtonResetGuest.TabIndex = 30;
            this.ButtonResetGuest.Text = "Сбросить поиск";
            this.ButtonResetGuest.UseVisualStyleBackColor = false;
            this.ButtonResetGuest.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonSearchGuest
            // 
            this.ButtonSearchGuest.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonSearchGuest.Enabled = false;
            this.ButtonSearchGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonSearchGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchGuest.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonSearchGuest.Location = new System.Drawing.Point(377, 69);
            this.ButtonSearchGuest.Name = "ButtonSearchGuest";
            this.ButtonSearchGuest.Size = new System.Drawing.Size(173, 44);
            this.ButtonSearchGuest.TabIndex = 29;
            this.ButtonSearchGuest.Text = "Найти";
            this.ButtonSearchGuest.UseVisualStyleBackColor = false;
            this.ButtonSearchGuest.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "по";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 3);
            this.panel1.TabIndex = 16;
            // 
            // ComboBoxSearchGuest
            // 
            this.ComboBoxSearchGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearchGuest.FormattingEnabled = true;
            this.ComboBoxSearchGuest.Items.AddRange(new object[] {
            "имени",
            "фамилии",
            "поиск по почте",
            "номеру места"});
            this.ComboBoxSearchGuest.Location = new System.Drawing.Point(165, 69);
            this.ComboBoxSearchGuest.Name = "ComboBoxSearchGuest";
            this.ComboBoxSearchGuest.Size = new System.Drawing.Size(177, 25);
            this.ComboBoxSearchGuest.TabIndex = 12;
            this.ComboBoxSearchGuest.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelSearchGuest
            // 
            this.labelSearchGuest.AutoSize = true;
            this.labelSearchGuest.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.labelSearchGuest.ForeColor = System.Drawing.Color.Crimson;
            this.labelSearchGuest.Location = new System.Drawing.Point(61, 77);
            this.labelSearchGuest.Name = "labelSearchGuest";
            this.labelSearchGuest.Size = new System.Drawing.Size(74, 17);
            this.labelSearchGuest.TabIndex = 10;
            this.labelSearchGuest.Text = "Поиск по";
            // 
            // ComboBoxFilterGuest
            // 
            this.ComboBoxFilterGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterGuest.FormattingEnabled = true;
            this.ComboBoxFilterGuest.Items.AddRange(new object[] {
            "имени",
            "фамилии",
            "электронной почте",
            "номеру места"});
            this.ComboBoxFilterGuest.Location = new System.Drawing.Point(165, 21);
            this.ComboBoxFilterGuest.Name = "ComboBoxFilterGuest";
            this.ComboBoxFilterGuest.Size = new System.Drawing.Size(177, 25);
            this.ComboBoxFilterGuest.TabIndex = 11;
            this.ComboBoxFilterGuest.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TextBoxFilterGuest
            // 
            this.TextBoxFilterGuest.Enabled = false;
            this.TextBoxFilterGuest.Location = new System.Drawing.Point(377, 23);
            this.TextBoxFilterGuest.Name = "TextBoxFilterGuest";
            this.TextBoxFilterGuest.Size = new System.Drawing.Size(173, 25);
            this.TextBoxFilterGuest.TabIndex = 7;
            this.TextBoxFilterGuest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TextBoxFilterGuest.Enter += new System.EventHandler(this.TextBoxFilterGuest_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.TextBoxCountGuest);
            this.groupBox2.Controls.Add(this.labelCountGuest);
            this.groupBox2.Controls.Add(this.ButtonCreateGuest);
            this.groupBox2.Controls.Add(this.ButtonAllDeleteGuest);
            this.groupBox2.Controls.Add(this.ButtonDeleteGuest);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(15, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 203);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Взаимодействие";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewGuestTable);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 352);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гости фестиваля фильмов";
            // 
            // labelFilterShowGuest
            // 
            this.labelFilterShowGuest.AutoSize = true;
            this.labelFilterShowGuest.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilterShowGuest.Location = new System.Drawing.Point(12, 11);
            this.labelFilterShowGuest.Name = "labelFilterShowGuest";
            this.labelFilterShowGuest.Size = new System.Drawing.Size(302, 18);
            this.labelFilterShowGuest.TabIndex = 22;
            this.labelFilterShowGuest.Text = "Внимание! Фильтрация применена!";
            this.labelFilterShowGuest.Visible = false;
            // 
            // GuestFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(991, 664);
            this.Controls.Add(this.labelFilterShowGuest);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonCloseGuestTable);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestFestivalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о гостях фестиваля";
            this.Load += new System.EventHandler(this.GuestFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuestTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseGuestTable;
        private System.Windows.Forms.Button ButtonAllDeleteGuest;
        private System.Windows.Forms.Button ButtonDeleteGuest;
        private System.Windows.Forms.Button ButtonCreateGuest;
        private System.Windows.Forms.TextBox TextBoxCountGuest;
        private System.Windows.Forms.Label labelCountGuest;
        private System.Windows.Forms.DataGridView dataGridViewGuestTable;
        private System.Windows.Forms.Label labelFilterGuest;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBoxSearchGuest;
        private System.Windows.Forms.Label labelSearchGuest;
        private System.Windows.Forms.ComboBox ComboBoxFilterGuest;
        private System.Windows.Forms.TextBox TextBoxFilterGuest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonResetGuest;
        private System.Windows.Forms.Button ButtonSearchGuest;
        private System.Windows.Forms.TextBox TextBoxSearchGuest;
        private System.Windows.Forms.TextBox TextBoxKolvoSearchGuest;
        private System.Windows.Forms.Label labelKolvoSearchGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label labelFilterShowGuest;
    }
}