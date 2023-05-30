using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class GuestForm : Form
    {
        public static string NameGuestForm = "";
        public static string LastNameGuestForm = "";
        public static int SeatNumberGuestForm = 0;
        public static string EmailGuestForm = "";
        public GuestForm()
        {
            InitializeComponent();
        }
        public GuestForm(string name, string surname, string email, int seatNumber)
        {
            InitializeComponent();
            ButtonCreateGuest.Text = "Изменить гостя";
            NameGuestForm = name;
            LastNameGuestForm = surname;
            EmailGuestForm = email;
            SeatNumberGuestForm = seatNumber;
            fillData();

        }
        private void fillData()
        {
            TextBoxNameGuest.Text = NameGuestForm;
            TextBoxLastNameGuest.Text = LastNameGuestForm;
            TextBoxEmailGuest.Text = EmailGuestForm;
            NumericUpDownSeatNumberGuest.Value = SeatNumberGuestForm;
        }
        private void ButtonCreateGuest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxNameGuest.Text)&& !string.IsNullOrEmpty(TextBoxLastNameGuest.Text)&& 
                !string.IsNullOrEmpty(TextBoxEmailGuest.Text))
            {

                SeatNumberGuestForm = (int)NumericUpDownSeatNumberGuest.Value;

                Close();
            }
            else
            {
                ButtonCreateGuest.Enabled= false;
            }
            
        }
        bool CheckOnCorrectTextBoxNameGuest(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
           Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
           || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelPrimerNameGuest.Text = "Неверные данные! Пожалуйста, введите корректные данные!\n" + 
            "Примеры ввода: Костя, Екатерина")
           != "Неверные данные! Пожалуйста, введите корректные данные!\n" + "Примеры ввода: Костя, Екатерина";
        bool CheckOnCorrectTextBoxLastNameGuest(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
        Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
        || (tb.BackColor = Color.MistyRose) != Color.MistyRose
        || (labelPrimerLastNameGuest.Text = "Неверные данные! Пожалуйста, введите корректные данные!\n" + 
            "Примеры ввода: Курков, Вахромеев")
        != "Неверные данные! Пожалуйста, введите корректные данные!\n" + "Примеры ввода: Курков, Вахромеев";
        bool CheckOnCorrectTextBoxEmailGuest(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$")&&
            Regex.IsMatch(tb.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
             || (tb.BackColor = Color.MistyRose) != Color.MistyRose
             || (labelPrimerEmailGuest.Text = "Неверные данные! Пожалуйста, введите корректные данные!\n" +
            "Примеры ввода: zhig@inbox.ru, patrik@gmail.com")
        != "Неверные данные! Пожалуйста, введите корректные данные!\n" + "Примеры ввода: zhig@inbox.ru, patrik@gmail.com";

        private void ButtonCloseGuestForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            ButtonCreateGuest.Enabled = false;
            this.ControlBox = false;
        }

        private void TextBoxNameGuest_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxNameGuest(TextBoxNameGuest))
            {
                NameGuestForm = TextBoxNameGuest.Text;
                labelPrimerNameGuest.Text = "";
                TextBoxNameGuest.BackColor = Color.White;
                ButtonCreateGuest.Enabled = true;
            }
            else
            {
                ButtonCreateGuest.Enabled = false;
            }
        }

        private void TextBoxLastNameGuest_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxLastNameGuest(TextBoxLastNameGuest))
            {
                LastNameGuestForm = TextBoxLastNameGuest.Text;
                labelPrimerLastNameGuest.Text = "";
                TextBoxLastNameGuest.BackColor = Color.White;
                ButtonCreateGuest.Enabled = true;
            }
            else
            {
                ButtonCreateGuest.Enabled = false;
            }
        }

        private void TextBoxEmailGuest_Leave(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxEmailGuest(TextBoxEmailGuest))
            {
                EmailGuestForm = TextBoxEmailGuest.Text;
                labelPrimerEmailGuest.Text = "";
                TextBoxEmailGuest.BackColor = Color.White;
                ButtonCreateGuest.Enabled = true;
            }
            else
            {
                ButtonCreateGuest.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
