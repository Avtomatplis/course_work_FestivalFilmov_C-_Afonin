using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class ParticipantsForm : Form
    {
        public static string NameParticipantsForm = "";
        public static string LastNameParticipantsForm = "";
        public static int AgeParticipantsForm = 0;
        public static string CityParticipantsForm = "";
        public ParticipantsForm()
        {
            InitializeComponent();
        }
        public ParticipantsForm(string name, string surname, string city, int age)
        {
            InitializeComponent();
            NameParticipantsForm = name;
            LastNameParticipantsForm = surname;
            CityParticipantsForm = city;
            AgeParticipantsForm = age;
            ButtonCreateParticipants.Text = "Изменить участника";
            fillData();
        }
        private void fillData()
        {
            TextBoxNameParticipants.Text = NameParticipantsForm;
            TextBoxLastNameParticipants.Text = LastNameParticipantsForm;
            NumericUpDownAgeParticipants.Value = AgeParticipantsForm;
            TextBoxCityParticipants.Text = CityParticipantsForm;
        }

        private void ButtonCreateParticipants_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxCityParticipants.Text))
            {
                AgeParticipantsForm = (int)NumericUpDownAgeParticipants.Value;
                Close();
            }
            else
            {
                ButtonCreateParticipants.Enabled = false;
            }

        }
        bool CheckOnCorrectTextBoxName(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelPrimerNameParticipants.Text = "Неверные данные! Пожалуйста, введите корректные данные!\n" + 
            "Примеры ввода: Максим, Кирилл") != "Неверные данные! Пожалуйста, введите корректные данные!\n" + 
            "Примеры ввода:" + " Максим, Кирилл";

        bool CheckOnCorrectTextBoxLastName(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelPrimerLastNameParticipants.Text = "Неверные данные! Пожалуйста, введите корректные данные!\n" + 
            "Примеры ввода: Сидоров, Иванов") != "Неверные данные! Пожалуйста, введите корректные данные!\n" 
            + "Примеры ввода:" +" Сидоров, Иванов";
        bool CheckOnCorrectTextBoxCity(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
           Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
           || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelPrimerCityParticipants.Text = "Неверные данные! Пожалуйста, введите корректные данные!\n" + 
            "Примеры ввода: Москва, Сочи") != "Неверные данные! Пожалуйста, введите корректные данные!\n"
            + "Примеры ввода:" +" Москва, Сочи";

        private void ButtonCloseParticipantsForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxNameParticipants_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxName(TextBoxNameParticipants))
            {
                NameParticipantsForm = TextBoxNameParticipants.Text;
                labelPrimerNameParticipants.Text = "";
                TextBoxNameParticipants.BackColor = Color.White;
                ButtonCreateParticipants.Enabled = true;
            }
            else
            {
                ButtonCreateParticipants.Enabled = false;
            }
        }

        private void TextBoxLastNameParticipants_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxLastName(TextBoxLastNameParticipants))
            {
                LastNameParticipantsForm = TextBoxLastNameParticipants.Text;
                labelPrimerLastNameParticipants.Text = "";
                TextBoxLastNameParticipants.BackColor = Color.White;
                ButtonCreateParticipants.Enabled = true;
            }
            else
            {
                ButtonCreateParticipants.Enabled = false;
            }
        }

        private void TextBoxCityParticipants_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxCity(TextBoxCityParticipants))
            {
                CityParticipantsForm = TextBoxCityParticipants.Text;
                labelPrimerCityParticipants.Text = "";
                TextBoxCityParticipants.BackColor = Color.White;
                ButtonCreateParticipants.Enabled = true;
            }
            else
            {
                ButtonCreateParticipants.Enabled = false;
            }
        }

        private void ParticipantsForm_Load(object sender, EventArgs e)
        {
            ButtonCreateParticipants.Enabled = false;
            this.ControlBox = false;
        }

        private void NumericUpDownAgeParticipants_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
