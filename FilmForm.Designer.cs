namespace course_work_FestivalFilmov_Afonin
{
    partial class FilmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmForm));
            this.labelNameFilm = new System.Windows.Forms.Label();
            this.TextBoxNameFilm = new System.Windows.Forms.TextBox();
            this.labelRatingFilm = new System.Windows.Forms.Label();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.labelNominationFilm = new System.Windows.Forms.Label();
            this.ComboBoxNominationFilm = new System.Windows.Forms.ComboBox();
            this.NumericUpDownTicketPrice = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxRatingFilm = new System.Windows.Forms.ComboBox();
            this.labelPrimerNameFilm = new System.Windows.Forms.Label();
            this.labelHintNominationFilm = new System.Windows.Forms.Label();
            this.labelHintRatingFilm = new System.Windows.Forms.Label();
            this.ButtonCreateFilm = new System.Windows.Forms.Button();
            this.ButtonCloseFilmForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameFilm
            // 
            this.labelNameFilm.AutoSize = true;
            this.labelNameFilm.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameFilm.Location = new System.Drawing.Point(48, 71);
            this.labelNameFilm.Name = "labelNameFilm";
            this.labelNameFilm.Size = new System.Drawing.Size(143, 20);
            this.labelNameFilm.TabIndex = 0;
            this.labelNameFilm.Text = "Название фильма";
            // 
            // TextBoxNameFilm
            // 
            this.TextBoxNameFilm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxNameFilm.Location = new System.Drawing.Point(429, 65);
            this.TextBoxNameFilm.Name = "TextBoxNameFilm";
            this.TextBoxNameFilm.Size = new System.Drawing.Size(145, 22);
            this.TextBoxNameFilm.TabIndex = 1;
            this.TextBoxNameFilm.TextChanged += new System.EventHandler(this.TextBoxNameFilm_TextChanged);
            this.TextBoxNameFilm.Leave += new System.EventHandler(this.TextBoxNameFilm_Leave);
            // 
            // labelRatingFilm
            // 
            this.labelRatingFilm.AutoSize = true;
            this.labelRatingFilm.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelRatingFilm.Location = new System.Drawing.Point(48, 203);
            this.labelRatingFilm.Name = "labelRatingFilm";
            this.labelRatingFilm.Size = new System.Drawing.Size(128, 20);
            this.labelRatingFilm.TabIndex = 2;
            this.labelRatingFilm.Text = "Оценка фильма";
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelTicketPrice.Location = new System.Drawing.Point(48, 158);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(308, 20);
            this.labelTicketPrice.TabIndex = 3;
            this.labelTicketPrice.Text = "Цена билета на фильм(от 100 до 1000)";
            // 
            // labelNominationFilm
            // 
            this.labelNominationFilm.AutoSize = true;
            this.labelNominationFilm.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNominationFilm.Location = new System.Drawing.Point(48, 113);
            this.labelNominationFilm.Name = "labelNominationFilm";
            this.labelNominationFilm.Size = new System.Drawing.Size(157, 20);
            this.labelNominationFilm.TabIndex = 4;
            this.labelNominationFilm.Text = "Номинация фильма";
            // 
            // ComboBoxNominationFilm
            // 
            this.ComboBoxNominationFilm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ComboBoxNominationFilm.FormattingEnabled = true;
            this.ComboBoxNominationFilm.Items.AddRange(new object[] {
            "Самый романтичный",
            "Самый смешной"});
            this.ComboBoxNominationFilm.Location = new System.Drawing.Point(429, 108);
            this.ComboBoxNominationFilm.Name = "ComboBoxNominationFilm";
            this.ComboBoxNominationFilm.Size = new System.Drawing.Size(145, 24);
            this.ComboBoxNominationFilm.TabIndex = 5;
            this.ComboBoxNominationFilm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNominationFilm_SelectedIndexChanged);
            // 
            // NumericUpDownTicketPrice
            // 
            this.NumericUpDownTicketPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NumericUpDownTicketPrice.Location = new System.Drawing.Point(429, 156);
            this.NumericUpDownTicketPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownTicketPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDownTicketPrice.Name = "NumericUpDownTicketPrice";
            this.NumericUpDownTicketPrice.Size = new System.Drawing.Size(145, 22);
            this.NumericUpDownTicketPrice.TabIndex = 6;
            this.NumericUpDownTicketPrice.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ComboBoxRatingFilm
            // 
            this.ComboBoxRatingFilm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ComboBoxRatingFilm.FormattingEnabled = true;
            this.ComboBoxRatingFilm.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ComboBoxRatingFilm.Location = new System.Drawing.Point(429, 203);
            this.ComboBoxRatingFilm.Name = "ComboBoxRatingFilm";
            this.ComboBoxRatingFilm.Size = new System.Drawing.Size(145, 24);
            this.ComboBoxRatingFilm.TabIndex = 7;
            this.ComboBoxRatingFilm.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRatingFilm_SelectedIndexChanged);
            // 
            // labelPrimerNameFilm
            // 
            this.labelPrimerNameFilm.AutoSize = true;
            this.labelPrimerNameFilm.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrimerNameFilm.Location = new System.Drawing.Point(599, 70);
            this.labelPrimerNameFilm.Name = "labelPrimerNameFilm";
            this.labelPrimerNameFilm.Size = new System.Drawing.Size(0, 17);
            this.labelPrimerNameFilm.TabIndex = 8;
            this.labelPrimerNameFilm.TextChanged += new System.EventHandler(this.labelPrimerNameFilm_TextChanged);
            // 
            // labelHintNominationFilm
            // 
            this.labelHintNominationFilm.AutoSize = true;
            this.labelHintNominationFilm.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelHintNominationFilm.Location = new System.Drawing.Point(599, 115);
            this.labelHintNominationFilm.Name = "labelHintNominationFilm";
            this.labelHintNominationFilm.Size = new System.Drawing.Size(0, 17);
            this.labelHintNominationFilm.TabIndex = 9;
            // 
            // labelHintRatingFilm
            // 
            this.labelHintRatingFilm.AutoSize = true;
            this.labelHintRatingFilm.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelHintRatingFilm.Location = new System.Drawing.Point(599, 208);
            this.labelHintRatingFilm.Name = "labelHintRatingFilm";
            this.labelHintRatingFilm.Size = new System.Drawing.Size(0, 17);
            this.labelHintRatingFilm.TabIndex = 10;
            // 
            // ButtonCreateFilm
            // 
            this.ButtonCreateFilm.BackColor = System.Drawing.Color.SeaShell;
            this.ButtonCreateFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ButtonCreateFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateFilm.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.ButtonCreateFilm.Location = new System.Drawing.Point(429, 273);
            this.ButtonCreateFilm.Name = "ButtonCreateFilm";
            this.ButtonCreateFilm.Size = new System.Drawing.Size(137, 44);
            this.ButtonCreateFilm.TabIndex = 11;
            this.ButtonCreateFilm.Text = "Добавить фильм";
            this.ButtonCreateFilm.UseVisualStyleBackColor = false;
            this.ButtonCreateFilm.Click += new System.EventHandler(this.ButtonCreateFilm_Click);
            // 
            // ButtonCloseFilmForm
            // 
            this.ButtonCloseFilmForm.BackColor = System.Drawing.Color.SeaShell;
            this.ButtonCloseFilmForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonCloseFilmForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseFilmForm.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.ButtonCloseFilmForm.Location = new System.Drawing.Point(52, 270);
            this.ButtonCloseFilmForm.Name = "ButtonCloseFilmForm";
            this.ButtonCloseFilmForm.Size = new System.Drawing.Size(133, 44);
            this.ButtonCloseFilmForm.TabIndex = 12;
            this.ButtonCloseFilmForm.Text = "Закрыть форму";
            this.ButtonCloseFilmForm.UseVisualStyleBackColor = false;
            this.ButtonCloseFilmForm.Click += new System.EventHandler(this.ButtonCloseFilmForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(137, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Добавление фильма";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::course_work_FestivalFilmov_Afonin.Properties.Resources.попкорн_фильм;
            this.pictureBox3.Location = new System.Drawing.Point(72, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 55);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::course_work_FestivalFilmov_Afonin.Properties.Resources.попкорн_фильм;
            this.pictureBox2.Location = new System.Drawing.Point(363, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 55);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::course_work_FestivalFilmov_Afonin.Properties.Resources.добавить_фильм_;
            this.pictureBox1.Location = new System.Drawing.Point(826, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 128);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(957, 353);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCloseFilmForm);
            this.Controls.Add(this.ButtonCreateFilm);
            this.Controls.Add(this.labelHintRatingFilm);
            this.Controls.Add(this.labelHintNominationFilm);
            this.Controls.Add(this.labelPrimerNameFilm);
            this.Controls.Add(this.ComboBoxRatingFilm);
            this.Controls.Add(this.NumericUpDownTicketPrice);
            this.Controls.Add(this.ComboBoxNominationFilm);
            this.Controls.Add(this.labelNominationFilm);
            this.Controls.Add(this.labelTicketPrice);
            this.Controls.Add(this.labelRatingFilm);
            this.Controls.Add(this.TextBoxNameFilm);
            this.Controls.Add(this.labelNameFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление фильма";
            this.Load += new System.EventHandler(this.FilmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownTicketPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameFilm;
        private System.Windows.Forms.TextBox TextBoxNameFilm;
        private System.Windows.Forms.Label labelRatingFilm;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.Label labelNominationFilm;
        private System.Windows.Forms.ComboBox ComboBoxNominationFilm;
        private System.Windows.Forms.NumericUpDown NumericUpDownTicketPrice;
        private System.Windows.Forms.ComboBox ComboBoxRatingFilm;
        private System.Windows.Forms.Label labelPrimerNameFilm;
        private System.Windows.Forms.Label labelHintNominationFilm;
        private System.Windows.Forms.Label labelHintRatingFilm;
        private System.Windows.Forms.Button ButtonCreateFilm;
        private System.Windows.Forms.Button ButtonCloseFilmForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}