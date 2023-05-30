namespace course_work_FestivalFilmov_Afonin
{
    partial class FilmFestivalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmFestivalForm));
            this.dataGridViewFilmTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCountFilm = new System.Windows.Forms.Label();
            this.TextBoxCountFilm = new System.Windows.Forms.TextBox();
            this.ButtonCreateFilm = new System.Windows.Forms.Button();
            this.ButtonDeleteFilm = new System.Windows.Forms.Button();
            this.ButtonAllDeleteFilm = new System.Windows.Forms.Button();
            this.ButtonCloseFilmTable = new System.Windows.Forms.Button();
            this.TextBoxFilterFilm = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxFilterFilm = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxKolvoSearchFilm = new System.Windows.Forms.TextBox();
            this.labelKolvoSearch = new System.Windows.Forms.Label();
            this.ButtonResetSearchFilm = new System.Windows.Forms.Button();
            this.ButtonSearhFilm = new System.Windows.Forms.Button();
            this.TextBoxSearchFilm = new System.Windows.Forms.TextBox();
            this.labelSearchFilm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFilterShowFilm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFilmTable
            // 
            this.dataGridViewFilmTable.AllowUserToAddRows = false;
            this.dataGridViewFilmTable.AllowUserToResizeColumns = false;
            this.dataGridViewFilmTable.AllowUserToResizeRows = false;
            this.dataGridViewFilmTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilmTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFilmTable.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridViewFilmTable.ColumnHeadersHeight = 29;
            this.dataGridViewFilmTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewFilmTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFilmTable.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewFilmTable.Name = "dataGridViewFilmTable";
            this.dataGridViewFilmTable.ReadOnly = true;
            this.dataGridViewFilmTable.RowHeadersVisible = false;
            this.dataGridViewFilmTable.RowHeadersWidth = 51;
            this.dataGridViewFilmTable.RowTemplate.Height = 24;
            this.dataGridViewFilmTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilmTable.Size = new System.Drawing.Size(915, 325);
            this.dataGridViewFilmTable.TabIndex = 0;
            this.dataGridViewFilmTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFilmTable_CellContentClick);
            this.dataGridViewFilmTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFilmTable_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название фильма";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номинация фильма";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена билета на фильм";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Оценка фильма";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // labelCountFilm
            // 
            this.labelCountFilm.AutoSize = true;
            this.labelCountFilm.ForeColor = System.Drawing.Color.Crimson;
            this.labelCountFilm.Location = new System.Drawing.Point(8, 175);
            this.labelCountFilm.Name = "labelCountFilm";
            this.labelCountFilm.Size = new System.Drawing.Size(155, 17);
            this.labelCountFilm.TabIndex = 1;
            this.labelCountFilm.Text = "Количество фильмов";
            // 
            // TextBoxCountFilm
            // 
            this.TextBoxCountFilm.Location = new System.Drawing.Point(172, 172);
            this.TextBoxCountFilm.Name = "TextBoxCountFilm";
            this.TextBoxCountFilm.ReadOnly = true;
            this.TextBoxCountFilm.Size = new System.Drawing.Size(104, 25);
            this.TextBoxCountFilm.TabIndex = 2;
            // 
            // ButtonCreateFilm
            // 
            this.ButtonCreateFilm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonCreateFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonCreateFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateFilm.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateFilm.Location = new System.Drawing.Point(11, 26);
            this.ButtonCreateFilm.Name = "ButtonCreateFilm";
            this.ButtonCreateFilm.Size = new System.Drawing.Size(136, 58);
            this.ButtonCreateFilm.TabIndex = 3;
            this.ButtonCreateFilm.Text = "Добавить фильм";
            this.ButtonCreateFilm.UseVisualStyleBackColor = false;
            this.ButtonCreateFilm.Click += new System.EventHandler(this.ButtonCreateFilm_Click);
            // 
            // ButtonDeleteFilm
            // 
            this.ButtonDeleteFilm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonDeleteFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonDeleteFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteFilm.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteFilm.Location = new System.Drawing.Point(153, 26);
            this.ButtonDeleteFilm.Name = "ButtonDeleteFilm";
            this.ButtonDeleteFilm.Size = new System.Drawing.Size(123, 58);
            this.ButtonDeleteFilm.TabIndex = 4;
            this.ButtonDeleteFilm.Text = "Удалить фильм";
            this.ButtonDeleteFilm.UseVisualStyleBackColor = false;
            this.ButtonDeleteFilm.Click += new System.EventHandler(this.ButtonDeleteFilm_Click);
            // 
            // ButtonAllDeleteFilm
            // 
            this.ButtonAllDeleteFilm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonAllDeleteFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonAllDeleteFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAllDeleteFilm.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAllDeleteFilm.Location = new System.Drawing.Point(14, 100);
            this.ButtonAllDeleteFilm.Name = "ButtonAllDeleteFilm";
            this.ButtonAllDeleteFilm.Size = new System.Drawing.Size(132, 52);
            this.ButtonAllDeleteFilm.TabIndex = 5;
            this.ButtonAllDeleteFilm.Text = "Удалить все фильмы";
            this.ButtonAllDeleteFilm.UseVisualStyleBackColor = false;
            this.ButtonAllDeleteFilm.Click += new System.EventHandler(this.ButtonAllDeleteFilm_Click);
            // 
            // ButtonCloseFilmTable
            // 
            this.ButtonCloseFilmTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseFilmTable.BackColor = System.Drawing.Color.Cornsilk;
            this.ButtonCloseFilmTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonCloseFilmTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseFilmTable.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCloseFilmTable.Location = new System.Drawing.Point(802, 614);
            this.ButtonCloseFilmTable.Name = "ButtonCloseFilmTable";
            this.ButtonCloseFilmTable.Size = new System.Drawing.Size(133, 48);
            this.ButtonCloseFilmTable.TabIndex = 6;
            this.ButtonCloseFilmTable.Text = "Закрыть форму";
            this.ButtonCloseFilmTable.UseVisualStyleBackColor = false;
            this.ButtonCloseFilmTable.Click += new System.EventHandler(this.ButtonCloseFilmTable_Click);
            // 
            // TextBoxFilterFilm
            // 
            this.TextBoxFilterFilm.Location = new System.Drawing.Point(348, 23);
            this.TextBoxFilterFilm.Name = "TextBoxFilterFilm";
            this.TextBoxFilterFilm.Size = new System.Drawing.Size(202, 25);
            this.TextBoxFilterFilm.TabIndex = 7;
            this.TextBoxFilterFilm.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TextBoxFilterFilm.Enter += new System.EventHandler(this.TextBoxFilterFilm_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фильтрация поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // ComboBoxFilterFilm
            // 
            this.ComboBoxFilterFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFilterFilm.FormattingEnabled = true;
            this.ComboBoxFilterFilm.Items.AddRange(new object[] {
            "названию фильма",
            "номинации фильма",
            "цене билета",
            "оценке фильма"});
            this.ComboBoxFilterFilm.Location = new System.Drawing.Point(152, 23);
            this.ComboBoxFilterFilm.Name = "ComboBoxFilterFilm";
            this.ComboBoxFilterFilm.Size = new System.Drawing.Size(189, 25);
            this.ComboBoxFilterFilm.TabIndex = 11;
            this.ComboBoxFilterFilm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFilterFilm_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridViewFilmTable);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 335);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильмы фестиваля";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.ButtonCreateFilm);
            this.groupBox2.Controls.Add(this.ButtonDeleteFilm);
            this.groupBox2.Controls.Add(this.ButtonAllDeleteFilm);
            this.groupBox2.Controls.Add(this.TextBoxCountFilm);
            this.groupBox2.Controls.Add(this.labelCountFilm);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(1, 411);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 221);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Взаимодействие";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.TextBoxKolvoSearchFilm);
            this.groupBox3.Controls.Add(this.labelKolvoSearch);
            this.groupBox3.Controls.Add(this.ButtonResetSearchFilm);
            this.groupBox3.Controls.Add(this.ButtonSearhFilm);
            this.groupBox3.Controls.Add(this.TextBoxSearchFilm);
            this.groupBox3.Controls.Add(this.labelSearchFilm);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ComboBoxFilterFilm);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TextBoxFilterFilm);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(372, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 197);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск и Фильтрация";
            // 
            // TextBoxKolvoSearchFilm
            // 
            this.TextBoxKolvoSearchFilm.Location = new System.Drawing.Point(244, 145);
            this.TextBoxKolvoSearchFilm.Name = "TextBoxKolvoSearchFilm";
            this.TextBoxKolvoSearchFilm.ReadOnly = true;
            this.TextBoxKolvoSearchFilm.Size = new System.Drawing.Size(136, 25);
            this.TextBoxKolvoSearchFilm.TabIndex = 22;
            this.TextBoxKolvoSearchFilm.Visible = false;
            this.TextBoxKolvoSearchFilm.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelKolvoSearch
            // 
            this.labelKolvoSearch.AutoSize = true;
            this.labelKolvoSearch.ForeColor = System.Drawing.Color.Crimson;
            this.labelKolvoSearch.Location = new System.Drawing.Point(6, 148);
            this.labelKolvoSearch.Name = "labelKolvoSearch";
            this.labelKolvoSearch.Size = new System.Drawing.Size(232, 17);
            this.labelKolvoSearch.TabIndex = 21;
            this.labelKolvoSearch.Text = "Количество найденных записей";
            this.labelKolvoSearch.Visible = false;
            // 
            // ButtonResetSearchFilm
            // 
            this.ButtonResetSearchFilm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonResetSearchFilm.Enabled = false;
            this.ButtonResetSearchFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonResetSearchFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResetSearchFilm.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResetSearchFilm.Location = new System.Drawing.Point(385, 128);
            this.ButtonResetSearchFilm.Name = "ButtonResetSearchFilm";
            this.ButtonResetSearchFilm.Size = new System.Drawing.Size(165, 45);
            this.ButtonResetSearchFilm.TabIndex = 20;
            this.ButtonResetSearchFilm.Text = "Сбросить поиск";
            this.ButtonResetSearchFilm.UseVisualStyleBackColor = false;
            this.ButtonResetSearchFilm.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonSearhFilm
            // 
            this.ButtonSearhFilm.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonSearhFilm.Enabled = false;
            this.ButtonSearhFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ButtonSearhFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearhFilm.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearhFilm.Location = new System.Drawing.Point(385, 72);
            this.ButtonSearhFilm.Name = "ButtonSearhFilm";
            this.ButtonSearhFilm.Size = new System.Drawing.Size(165, 44);
            this.ButtonSearhFilm.TabIndex = 19;
            this.ButtonSearhFilm.Text = "Найти";
            this.ButtonSearhFilm.UseVisualStyleBackColor = false;
            this.ButtonSearhFilm.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxSearchFilm
            // 
            this.TextBoxSearchFilm.Location = new System.Drawing.Point(215, 77);
            this.TextBoxSearchFilm.Name = "TextBoxSearchFilm";
            this.TextBoxSearchFilm.Size = new System.Drawing.Size(164, 25);
            this.TextBoxSearchFilm.TabIndex = 18;
            this.TextBoxSearchFilm.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelSearchFilm
            // 
            this.labelSearchFilm.AutoSize = true;
            this.labelSearchFilm.ForeColor = System.Drawing.Color.Crimson;
            this.labelSearchFilm.Location = new System.Drawing.Point(6, 80);
            this.labelSearchFilm.Name = "labelSearchFilm";
            this.labelSearchFilm.Size = new System.Drawing.Size(200, 17);
            this.labelSearchFilm.TabIndex = 17;
            this.labelSearchFilm.Text = "Поиск по названию фильма";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 3);
            this.panel1.TabIndex = 16;
            // 
            // labelFilterShowFilm
            // 
            this.labelFilterShowFilm.AutoSize = true;
            this.labelFilterShowFilm.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilterShowFilm.Location = new System.Drawing.Point(15, 24);
            this.labelFilterShowFilm.Name = "labelFilterShowFilm";
            this.labelFilterShowFilm.Size = new System.Drawing.Size(302, 18);
            this.labelFilterShowFilm.TabIndex = 19;
            this.labelFilterShowFilm.Text = "Внимание! Фильтрация применена!";
            this.labelFilterShowFilm.Visible = false;
            // 
            // FilmFestivalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(945, 667);
            this.Controls.Add(this.labelFilterShowFilm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonCloseFilmTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FilmFestivalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о фильмах фестиваля";
            this.Load += new System.EventHandler(this.FilmFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilmTable;
        private System.Windows.Forms.Label labelCountFilm;
        private System.Windows.Forms.TextBox TextBoxCountFilm;
        private System.Windows.Forms.Button ButtonCreateFilm;
        private System.Windows.Forms.Button ButtonDeleteFilm;
        private System.Windows.Forms.Button ButtonAllDeleteFilm;
        private System.Windows.Forms.Button ButtonCloseFilmTable;
        private System.Windows.Forms.TextBox TextBoxFilterFilm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxFilterFilm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxSearchFilm;
        private System.Windows.Forms.Label labelSearchFilm;
        private System.Windows.Forms.Button ButtonSearhFilm;
        private System.Windows.Forms.Button ButtonResetSearchFilm;
        private System.Windows.Forms.TextBox TextBoxKolvoSearchFilm;
        private System.Windows.Forms.Label labelKolvoSearch;
        private System.Windows.Forms.Label labelFilterShowFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}