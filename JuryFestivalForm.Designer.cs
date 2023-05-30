namespace course_work_FestivalFilmov_Afonin
{
    partial class JuryFestivalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuryFestivalForm));
            this.ButtonCloseJuryTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteJury = new System.Windows.Forms.Button();
            this.ButtonDeleteJury = new System.Windows.Forms.Button();
            this.ButtonCreateJury = new System.Windows.Forms.Button();
            this.TextBoxCountJury = new System.Windows.Forms.TextBox();
            this.labelCountJury = new System.Windows.Forms.Label();
            this.dataGridViewJuryTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxKolvoSearhJury = new System.Windows.Forms.TextBox();
            this.labelKolvoSearchJury = new System.Windows.Forms.Label();
            this.TextBoxSearchJury = new System.Windows.Forms.TextBox();
            this.ButtonResetSearchJury = new System.Windows.Forms.Button();
            this.ButtonSearchJury = new System.Windows.Forms.Button();
            this.labelFilterJury = new System.Windows.Forms.Label();
            this.ComboBoxSearchJury = new System.Windows.Forms.ComboBox();
            this.labelSearchJury = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxFilterJury = new System.Windows.Forms.TextBox();
            this.ComboBoxFilterJury = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFilterShowJury = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuryTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCloseJuryTable
            // 
            this.ButtonCloseJuryTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseJuryTable.BackColor = System.Drawing.Color.Cornsilk;
            this.ButtonCloseJuryTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonCloseJuryTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseJuryTable.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.ButtonCloseJuryTable.Location = new System.Drawing.Point(870, 557);
            this.ButtonCloseJuryTable.Name = "ButtonCloseJuryTable";
            this.ButtonCloseJuryTable.Size = new System.Drawing.Size(140, 48);
            this.ButtonCloseJuryTable.TabIndex = 13;
            this.ButtonCloseJuryTable.Text = "Закрыть форму";
            this.ButtonCloseJuryTable.UseVisualStyleBackColor = false;
            this.ButtonCloseJuryTable.Click += new System.EventHandler(this.ButtonCloseJuryTable_Click);
            // 
            // ButtonAllDeleteJury
            // 
            this.ButtonAllDeleteJury.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonAllDeleteJury.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonAllDeleteJury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAllDeleteJury.Location = new System.Drawing.Point(6, 85);
            this.ButtonAllDeleteJury.Name = "ButtonAllDeleteJury";
            this.ButtonAllDeleteJury.Size = new System.Drawing.Size(135, 54);
            this.ButtonAllDeleteJury.TabIndex = 12;
            this.ButtonAllDeleteJury.Text = "Удалить всех членов жюри";
            this.ButtonAllDeleteJury.UseVisualStyleBackColor = false;
            this.ButtonAllDeleteJury.Click += new System.EventHandler(this.ButtonAllDeleteJury_Click);
            // 
            // ButtonDeleteJury
            // 
            this.ButtonDeleteJury.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonDeleteJury.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonDeleteJury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteJury.Location = new System.Drawing.Point(165, 21);
            this.ButtonDeleteJury.Name = "ButtonDeleteJury";
            this.ButtonDeleteJury.Size = new System.Drawing.Size(134, 57);
            this.ButtonDeleteJury.TabIndex = 11;
            this.ButtonDeleteJury.Text = "Удалить члена жюри";
            this.ButtonDeleteJury.UseVisualStyleBackColor = false;
            this.ButtonDeleteJury.Click += new System.EventHandler(this.ButtonDeleteJury_Click);
            // 
            // ButtonCreateJury
            // 
            this.ButtonCreateJury.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonCreateJury.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonCreateJury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateJury.Location = new System.Drawing.Point(6, 21);
            this.ButtonCreateJury.Name = "ButtonCreateJury";
            this.ButtonCreateJury.Size = new System.Drawing.Size(135, 57);
            this.ButtonCreateJury.TabIndex = 10;
            this.ButtonCreateJury.Text = "Добавить члена жюри";
            this.ButtonCreateJury.UseVisualStyleBackColor = false;
            this.ButtonCreateJury.Click += new System.EventHandler(this.ButtonCreateJury_Click);
            // 
            // TextBoxCountJury
            // 
            this.TextBoxCountJury.Location = new System.Drawing.Point(197, 136);
            this.TextBoxCountJury.Name = "TextBoxCountJury";
            this.TextBoxCountJury.ReadOnly = true;
            this.TextBoxCountJury.Size = new System.Drawing.Size(102, 25);
            this.TextBoxCountJury.TabIndex = 9;
            // 
            // labelCountJury
            // 
            this.labelCountJury.AutoSize = true;
            this.labelCountJury.ForeColor = System.Drawing.Color.Crimson;
            this.labelCountJury.Location = new System.Drawing.Point(-1, 142);
            this.labelCountJury.Name = "labelCountJury";
            this.labelCountJury.Size = new System.Drawing.Size(185, 17);
            this.labelCountJury.TabIndex = 8;
            this.labelCountJury.Text = "Количество членов жюри";
            // 
            // dataGridViewJuryTable
            // 
            this.dataGridViewJuryTable.AllowUserToAddRows = false;
            this.dataGridViewJuryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewJuryTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewJuryTable.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewJuryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJuryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewJuryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewJuryTable.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewJuryTable.Name = "dataGridViewJuryTable";
            this.dataGridViewJuryTable.ReadOnly = true;
            this.dataGridViewJuryTable.RowHeadersVisible = false;
            this.dataGridViewJuryTable.RowHeadersWidth = 51;
            this.dataGridViewJuryTable.RowTemplate.Height = 24;
            this.dataGridViewJuryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJuryTable.Size = new System.Drawing.Size(984, 296);
            this.dataGridViewJuryTable.TabIndex = 7;
            this.dataGridViewJuryTable.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJuryTable_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя члена жюри";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Фамилия члена жюри";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Должность члена жюри";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCountJury);
            this.groupBox2.Controls.Add(this.TextBoxCountJury);
            this.groupBox2.Controls.Add(this.ButtonCreateJury);
            this.groupBox2.Controls.Add(this.ButtonAllDeleteJury);
            this.groupBox2.Controls.Add(this.ButtonDeleteJury);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(11, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 165);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Взаимодействие";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TextBoxKolvoSearhJury);
            this.groupBox3.Controls.Add(this.labelKolvoSearchJury);
            this.groupBox3.Controls.Add(this.TextBoxSearchJury);
            this.groupBox3.Controls.Add(this.ButtonResetSearchJury);
            this.groupBox3.Controls.Add(this.ButtonSearchJury);
            this.groupBox3.Controls.Add(this.labelFilterJury);
            this.groupBox3.Controls.Add(this.ComboBoxSearchJury);
            this.groupBox3.Controls.Add(this.labelSearchJury);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.TextBoxFilterJury);
            this.groupBox3.Controls.Add(this.ComboBoxFilterJury);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(418, 372);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 179);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск и фильтрация";
            // 
            // TextBoxKolvoSearhJury
            // 
            this.TextBoxKolvoSearhJury.Location = new System.Drawing.Point(243, 140);
            this.TextBoxKolvoSearhJury.Name = "TextBoxKolvoSearhJury";
            this.TextBoxKolvoSearhJury.ReadOnly = true;
            this.TextBoxKolvoSearhJury.Size = new System.Drawing.Size(107, 25);
            this.TextBoxKolvoSearhJury.TabIndex = 29;
            this.TextBoxKolvoSearhJury.Visible = false;
            // 
            // labelKolvoSearchJury
            // 
            this.labelKolvoSearchJury.AutoSize = true;
            this.labelKolvoSearchJury.ForeColor = System.Drawing.Color.Crimson;
            this.labelKolvoSearchJury.Location = new System.Drawing.Point(5, 144);
            this.labelKolvoSearchJury.Name = "labelKolvoSearchJury";
            this.labelKolvoSearchJury.Size = new System.Drawing.Size(232, 17);
            this.labelKolvoSearchJury.TabIndex = 28;
            this.labelKolvoSearchJury.Text = "Количество найденных записей";
            this.labelKolvoSearchJury.Visible = false;
            this.labelKolvoSearchJury.Click += new System.EventHandler(this.labelKolvoSearchJury_Click);
            // 
            // TextBoxSearchJury
            // 
            this.TextBoxSearchJury.Enabled = false;
            this.TextBoxSearchJury.Location = new System.Drawing.Point(158, 98);
            this.TextBoxSearchJury.Name = "TextBoxSearchJury";
            this.TextBoxSearchJury.Size = new System.Drawing.Size(183, 25);
            this.TextBoxSearchJury.TabIndex = 27;
            this.TextBoxSearchJury.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtonResetSearchJury
            // 
            this.ButtonResetSearchJury.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonResetSearchJury.Enabled = false;
            this.ButtonResetSearchJury.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonResetSearchJury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResetSearchJury.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonResetSearchJury.Location = new System.Drawing.Point(395, 118);
            this.ButtonResetSearchJury.Name = "ButtonResetSearchJury";
            this.ButtonResetSearchJury.Size = new System.Drawing.Size(168, 47);
            this.ButtonResetSearchJury.TabIndex = 26;
            this.ButtonResetSearchJury.Text = "Сбросить поиск";
            this.ButtonResetSearchJury.UseVisualStyleBackColor = false;
            this.ButtonResetSearchJury.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonSearchJury
            // 
            this.ButtonSearchJury.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonSearchJury.Enabled = false;
            this.ButtonSearchJury.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonSearchJury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearchJury.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.ButtonSearchJury.Location = new System.Drawing.Point(395, 67);
            this.ButtonSearchJury.Name = "ButtonSearchJury";
            this.ButtonSearchJury.Size = new System.Drawing.Size(168, 41);
            this.ButtonSearchJury.TabIndex = 25;
            this.ButtonSearchJury.Text = "Найти";
            this.ButtonSearchJury.UseVisualStyleBackColor = false;
            this.ButtonSearchJury.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFilterJury
            // 
            this.labelFilterJury.AutoSize = true;
            this.labelFilterJury.ForeColor = System.Drawing.Color.Crimson;
            this.labelFilterJury.Location = new System.Drawing.Point(6, 28);
            this.labelFilterJury.Name = "labelFilterJury";
            this.labelFilterJury.Size = new System.Drawing.Size(132, 17);
            this.labelFilterJury.TabIndex = 23;
            this.labelFilterJury.Text = "Фильтрация поля";
            // 
            // ComboBoxSearchJury
            // 
            this.ComboBoxSearchJury.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSearchJury.FormattingEnabled = true;
            this.ComboBoxSearchJury.Items.AddRange(new object[] {
            "имени члена жюри",
            "фамилии члена жюри"});
            this.ComboBoxSearchJury.Location = new System.Drawing.Point(157, 67);
            this.ComboBoxSearchJury.Name = "ComboBoxSearchJury";
            this.ComboBoxSearchJury.Size = new System.Drawing.Size(184, 25);
            this.ComboBoxSearchJury.TabIndex = 19;
            this.ComboBoxSearchJury.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // labelSearchJury
            // 
            this.labelSearchJury.AutoSize = true;
            this.labelSearchJury.ForeColor = System.Drawing.Color.Crimson;
            this.labelSearchJury.Location = new System.Drawing.Point(32, 71);
            this.labelSearchJury.Name = "labelSearchJury";
            this.labelSearchJury.Size = new System.Drawing.Size(74, 17);
            this.labelSearchJury.TabIndex = 18;
            this.labelSearchJury.Text = "Поиск по";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 3);
            this.panel1.TabIndex = 17;
            // 
            // TextBoxFilterJury
            // 
            this.TextBoxFilterJury.Enabled = false;
            this.TextBoxFilterJury.Location = new System.Drawing.Point(376, 25);
            this.TextBoxFilterJury.Name = "TextBoxFilterJury";
            this.TextBoxFilterJury.Size = new System.Drawing.Size(198, 25);
            this.TextBoxFilterJury.TabIndex = 2;
            this.TextBoxFilterJury.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TextBoxFilterJury.Enter += new System.EventHandler(this.TextBoxFilterJury_Enter);
            // 
            // ComboBoxFilterJury
            // 
            this.ComboBoxFilterJury.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterJury.FormattingEnabled = true;
            this.ComboBoxFilterJury.Items.AddRange(new object[] {
            "имени члена жюри",
            "фамилии члена жюри",
            "должности члена жюри"});
            this.ComboBoxFilterJury.Location = new System.Drawing.Point(157, 25);
            this.ComboBoxFilterJury.Name = "ComboBoxFilterJury";
            this.ComboBoxFilterJury.Size = new System.Drawing.Size(184, 25);
            this.ComboBoxFilterJury.TabIndex = 1;
            this.ComboBoxFilterJury.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewJuryTable);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(11, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 325);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Члены жюри";
            // 
            // labelFilterShowJury
            // 
            this.labelFilterShowJury.AutoSize = true;
            this.labelFilterShowJury.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilterShowJury.Location = new System.Drawing.Point(10, 20);
            this.labelFilterShowJury.Name = "labelFilterShowJury";
            this.labelFilterShowJury.Size = new System.Drawing.Size(302, 18);
            this.labelFilterShowJury.TabIndex = 21;
            this.labelFilterShowJury.Text = "Внимание! Фильтрация применена!";
            this.labelFilterShowJury.Visible = false;
            // 
            // JuryFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1013, 608);
            this.Controls.Add(this.labelFilterShowJury);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ButtonCloseJuryTable);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JuryFestivalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о членах жюри";
            this.Load += new System.EventHandler(this.JuryFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJuryTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseJuryTable;
        private System.Windows.Forms.Button ButtonAllDeleteJury;
        private System.Windows.Forms.Button ButtonDeleteJury;
        private System.Windows.Forms.Button ButtonCreateJury;
        private System.Windows.Forms.TextBox TextBoxCountJury;
        private System.Windows.Forms.Label labelCountJury;
        private System.Windows.Forms.DataGridView dataGridViewJuryTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComboBoxSearchJury;
        private System.Windows.Forms.Label labelSearchJury;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxFilterJury;
        private System.Windows.Forms.ComboBox ComboBoxFilterJury;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFilterJury;
        private System.Windows.Forms.Button ButtonResetSearchJury;
        private System.Windows.Forms.Button ButtonSearchJury;
        private System.Windows.Forms.TextBox TextBoxSearchJury;
        private System.Windows.Forms.TextBox TextBoxKolvoSearhJury;
        private System.Windows.Forms.Label labelKolvoSearchJury;
        private System.Windows.Forms.Label labelFilterShowJury;
    }
}