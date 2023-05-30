using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class JuryForm : Form
    {
        public static string NameJuryForm = "";
        public static string LastNameJuryForm = "";
        public static string PostJuryForm = "";
        public JuryForm()
        {
            InitializeComponent();
        }
        public JuryForm(string name, string surname, string post)
        {
            InitializeComponent();
            ButtonCreateJury.Text = "Изменить жюри";
            NameJuryForm = name;
            LastNameJuryForm = surname;
            PostJuryForm = post;
            fillData();
        }
        private void fillData()
        {
            TextBoxNameJury.Text = NameJuryForm;
            TextBoxLastNameJury.Text=LastNameJuryForm;
            ComboBoxPostJury.SelectedItem = PostJuryForm;
        }

        private void JuryForm_Load(object sender, EventArgs e)
        {
            ButtonCreateJury.Enabled = false;
            this.ControlBox = false;
        }

        private void ButtonCreateJury_Click(object sender, EventArgs e)
        {
            if (
              CheckOnCorrectComboBox(ComboBoxPostJury)&& !string.IsNullOrEmpty(TextBoxNameJury.Text) &&
              !string.IsNullOrEmpty(TextBoxLastNameJury.Text))
            {
                PostJuryForm = ComboBoxPostJury.SelectedItem as string;
                Close();
            }
            else
            {
               ButtonCreateJury.Enabled=false;
            }
        }
        bool CheckOnCorrectTextBoxNameJury(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelPrimerNameJury.Text = "Неверные данные! Пожалуйста, введите корректные данные!\n"+
            "Примеры ввода: Сергей, Настя")
            != "Неверные данные! Пожалуйста, введите корректные данные!\n"+ "Примеры ввода: Сергей, Настя";
        bool CheckOnCorrectTextBoxLastNameJury(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelPrimerLastNameJury.Text = "Неверные данные! Пожалуйста, введите корректные данные!\n"+
            "Примеры ввода: Седов, Лукашина")
            != "Неверные данные! Пожалуйста, введите корректные данные!\n" + "Примеры ввода: Седов, Лукашина";
        bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null)
            || (cb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelHintPostJury.Text = "Пожалуйста, выберите одну из должностей!")
            != "Пожалуйста, выберите одну из должностей!";
        private void ButtonCloseJuryForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBoxPostJury_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHintPostJury.Text = "";
            ComboBoxPostJury.BackColor = Color.White;
            ButtonCreateJury.Enabled = true;
        }

        private void TextBoxNameJury_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxNameJury(TextBoxNameJury))
            {
                NameJuryForm = TextBoxNameJury.Text;
                labelPrimerNameJury.Text = "";
                TextBoxNameJury.BackColor = Color.White;
                ButtonCreateJury.Enabled = true;
            }
            else
            {
                ButtonCreateJury.Enabled = false;
            }
        }

        private void TextBoxLastNameJury_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxLastNameJury(TextBoxLastNameJury))
            {
                LastNameJuryForm = TextBoxLastNameJury.Text;
                labelPrimerLastNameJury.Text = "";
                TextBoxLastNameJury.BackColor = Color.White;
                ButtonCreateJury.Enabled = true;
            }
            else
            {
                ButtonCreateJury.Enabled = false;
            }
        }
    }
}
