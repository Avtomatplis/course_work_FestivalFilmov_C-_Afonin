using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class FilmForm : Form
    {
        public static string NameFilmForm = "";
        public static string NominationFilmForm = "";
        public static int TicketPriceForm = 0;
        public static string RatingFilmForm = "";

        public FilmForm()
        {
            InitializeComponent();
        }

        public FilmForm(string name, string nomination, int price, string rating)
        {
            InitializeComponent();
            ButtonCreateFilm.Text = "Изменить фильм";
            NameFilmForm = name;
            NominationFilmForm = nomination;
            TicketPriceForm = price;
            RatingFilmForm = rating;
            FillData();
        }

        private void FillData()
        {
            TextBoxNameFilm.Text = NameFilmForm;
            ComboBoxNominationFilm.SelectedIndex =  NameFilmForm.Equals("Самый романтичный") ? 0 : 1;
            NumericUpDownTicketPrice.Value = TicketPriceForm;
            ComboBoxRatingFilm.SelectedItem = RatingFilmForm;
        }

        private void ButtonCreateFilm_Click(object sender, EventArgs e)
        {
            
            if (
               CheckOnCorrectComboBoxNominationFilm(ComboBoxNominationFilm) &&
                CheckOnCorrectComboBoxRatingFilm(ComboBoxRatingFilm) && !string.IsNullOrEmpty(TextBoxNameFilm.Text))
            {
                NominationFilmForm = ComboBoxNominationFilm.SelectedItem as string;
                RatingFilmForm = ComboBoxRatingFilm.SelectedItem as string;
                TicketPriceForm = (int)NumericUpDownTicketPrice.Value;

                Close();
            }
            else
            {
                ButtonCreateFilm.Enabled=false;
            }
        }
        bool CheckOnCorrectTextBoxNameFilm(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
              Regex.IsMatch(tb.Text, @"^[^A-Za-z]*$")
           || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelPrimerNameFilm.Text = "Неверные данные!\nПожалуйста, введите корректные данные!\n" +
            "Примеры ввода: Любовь и голуби, 1+1")
           != "Неверные данные!\nПожалуйста, введите корректные данные!\n"+
            "Примеры ввода: Любовь и голуби, 1+1";

        bool CheckOnCorrectComboBoxNominationFilm(ComboBox cb) => !(cb.SelectedItem is null)
            || (cb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelHintNominationFilm.Text = "Пожалуйста, выберите одну из номинаций!")
            != "Пожалуйста, выберите одну из номинаций!";
        bool CheckOnCorrectComboBoxRatingFilm(ComboBox cb) => !(cb.SelectedItem is null)
           || (cb.BackColor = Color.MistyRose) != Color.MistyRose
          || (labelHintRatingFilm.Text = "Пожалуйста, поставте фильму оценку!")
           != "Пожалуйста, поставте фильму оценку!";
        private void ButtonCloseFilmForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FilmForm_Load(object sender, EventArgs e)
        {
            ButtonCreateFilm.Enabled = false;
            this.ControlBox = false;
        }

        private void labelPrimerNameFilm_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNameFilm_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxNameFilm(TextBoxNameFilm))
            {
                NameFilmForm = TextBoxNameFilm.Text;
                labelPrimerNameFilm.Text = "";
                TextBoxNameFilm.BackColor = Color.White;
                ButtonCreateFilm.Enabled = true;
            }
            else
            {
                ButtonCreateFilm.Enabled = false;
            }
        }

        private void TextBoxNameFilm_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxNominationFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHintNominationFilm.Text = "";
            ComboBoxNominationFilm.BackColor = Color.White;
            ButtonCreateFilm.Enabled = true;
        }

        private void ComboBoxRatingFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHintRatingFilm.Text = "";
            ComboBoxRatingFilm.BackColor = Color.White;
            ButtonCreateFilm.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
