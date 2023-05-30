using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class GuestFestivalForm : Form
    {
        const string FileGuest = "Guest.json";

        int numbersGuest = 0;
        int countGuest = 0;
        public GuestFestivalForm()
        {
            Task.Run(() => File.Open(FileGuest, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }
        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync())
                ?? new List<T>());
            }
        }

        async private void ButtonCreateGuest_Click(object sender, EventArgs e)
        {
            GuestForm formGuest = new GuestForm();
            formGuest.ShowDialog();
            string nameGuestForm = GuestForm.NameGuestForm;
            string lastNameGuestForm = GuestForm.LastNameGuestForm;
            int seatNumberGuestForm = GuestForm.SeatNumberGuestForm;
            string emailGuestForm = GuestForm.EmailGuestForm;

            Guests newGuest = new Guests(nameGuestForm,
                lastNameGuestForm, emailGuestForm, seatNumberGuestForm);

            if (!string.IsNullOrEmpty(nameGuestForm) &&
                !string.IsNullOrEmpty(lastNameGuestForm) &&
                (seatNumberGuestForm > 0) &&
                !string.IsNullOrEmpty(emailGuestForm))
            {
                var guest = await ReadFromFile<Guests>(FileGuest);

                if (!guest.Contains(newGuest))
                {
                    foreach (var twoGuest in guest)
                    {
                        if (twoGuest.NameGuest == nameGuestForm &&
                            twoGuest.LastNameGuest == lastNameGuestForm &&
                            twoGuest.SeatNumberGuest == seatNumberGuestForm &&
                            twoGuest.EmailGuest == emailGuestForm)
                        {
                            MessageBox.Show($"Гость {twoGuest.NameGuest} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление гостя", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                        if(twoGuest.SeatNumberGuest==seatNumberGuestForm)
                        {
                            MessageBox.Show($"Гость c номером места {twoGuest.SeatNumberGuest} уже занесён в базу " +
                               $"Фестиваль фильмов. ", "Добавление гостя", 0,
                               MessageBoxIcon.Information);
                            return;
                        }
                    }

                    guest.Add(newGuest);
                    countGuest = guest.Count;
                    TextBoxCountGuest.Text = Convert.ToString(countGuest);


                    await WriteToFile(guest, FileGuest);

                    dataGridViewGuestTable.Rows.Add(nameGuestForm, lastNameGuestForm, emailGuestForm, seatNumberGuestForm);
                    MessageBox.Show($"Гость {nameGuestForm} успешно добавлен в базу " +
                           $"Фестиваль фильмов. ", "Добавление гостя", 0,
                           MessageBoxIcon.Information);
                    GuestForm.NameGuestForm = "";
                    GuestForm.LastNameGuestForm = "";
                    GuestForm.SeatNumberGuestForm = 0;
                    GuestForm.EmailGuestForm = "";
                }
                else
                {
                    MessageBox.Show($"Этот гость был занесён в базу фестиваль фильмов ранее",
                        "Добавление гостя", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        async private void GuestFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileGuest))
            {
                var tableOfGuest = await ReadFromFile<Guests>(FileGuest);
                numbersGuest = 0;
                countGuest = tableOfGuest.Count;
                TextBoxCountGuest.Text = Convert.ToString(countGuest);

                if (tableOfGuest != null)
                    foreach (var guests in tableOfGuest)
                    {
                        dataGridViewGuestTable.Rows.Add();
                        dataGridViewGuestTable.Rows[numbersGuest].Cells[0].Value = guests.NameGuest;
                        dataGridViewGuestTable.Rows[numbersGuest].Cells[1].Value = guests.LastNameGuest;
                        dataGridViewGuestTable.Rows[numbersGuest].Cells[2].Value = guests.EmailGuest;
                        dataGridViewGuestTable.Rows[numbersGuest].Cells[3].Value = guests.SeatNumberGuest;
                        numbersGuest++;
                    }
            }
        }

       async private void ButtonDeleteGuest_Click(object sender, EventArgs e)
        {
            if (dataGridViewGuestTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                   "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
            int selectCount = dataGridViewGuestTable.SelectedRows[0].Index;

            if (selectCount >= 0 && dataGridViewGuestTable.SelectedRows.Count != 0)
            {
                var guests = await ReadFromFile<Guests>(FileGuest);
                if (guests.Count == 1)
                {
                    TextBoxFilterGuest.Text = "";
                    TextBoxFilterGuest.Enabled = false;
                    ComboBoxFilterGuest.SelectedIndex = -1;
                }
                string nameGuest = dataGridViewGuestTable.Rows[selectCount].Cells[0].Value.ToString();
                string lastNameGuest = dataGridViewGuestTable.Rows[selectCount].Cells[1].Value.ToString();
                string emailGuest = dataGridViewGuestTable.Rows[selectCount].Cells[2].Value.ToString();
                int seatNumberGuest = Convert.ToInt32(dataGridViewGuestTable.Rows[selectCount].Cells[3].Value.ToString());

                foreach (var twoGuests in guests)
                {
                    if (nameGuest == twoGuests.NameGuest && lastNameGuest == twoGuests.LastNameGuest
                        && emailGuest == twoGuests.EmailGuest && seatNumberGuest == twoGuests.SeatNumberGuest)
                    {
                        guests.Remove(twoGuests);
                        TextBoxCountGuest.Text = Convert.ToString(guests.Count);
                        dataGridViewGuestTable.Rows.Remove(dataGridViewGuestTable.Rows[selectCount]);
                        dataGridViewGuestTable.Refresh();
                        TextBoxKolvoSearchGuest.Text = dataGridViewGuestTable.SelectedRows.Count.ToString();
                        MessageBox.Show($"Гость {twoGuests.NameGuest}  удалён!", "Удаление одного гостя", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(guests, FileGuest);
            }
            else
            {
                MessageBox.Show("Нет ни одного гостя или вы не выбрали гостя для удаления!", 
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

       async private void ButtonAllDeleteGuest_Click(object sender, EventArgs e)
        {
            var guests = await ReadFromFile<Guests>(FileGuest);
            countGuest = guests.Count;
            if (countGuest == 0)
            {
                MessageBox.Show("Нет ни одного гостя!", "Удалить всех гостей", 0, MessageBoxIcon.Information);
                return;
            }
            else
            {
                guests.Clear();
                await WriteToFile(guests, FileGuest);
                TextBoxCountGuest.Text = guests.Count.ToString();
                dataGridViewGuestTable.Rows.Clear();
                numbersGuest = 0;
                labelKolvoSearchGuest.Visible = false;
                TextBoxKolvoSearchGuest.Visible = false;
                TextBoxSearchGuest.Text = "";
                ComboBoxSearchGuest.Text = "";
                ComboBoxFilterGuest.Text = "";
                TextBoxFilterGuest.Text = "";
                labelFilterShowGuest.Visible = false;
                ButtonSearchGuest.Enabled = false;
                ButtonResetGuest.Enabled = false;
                MessageBox.Show("Данные всех гостей удалены!", "Удалить всех гостей", 0, MessageBoxIcon.Information);
            }
        }

        private void ButtonCloseGuestTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (TextBoxFilterGuest.Text.Length != 0)
            {
                labelFilterShowGuest.Visible = true;
            }
            else
                labelFilterShowGuest.Visible = false;
            if (ComboBoxFilterGuest.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для фильтрации!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = TextBoxFilterGuest.Text; 
            int columnIndex = ComboBoxFilterGuest.SelectedIndex;
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in dataGridViewGuestTable.Rows)
            {
                if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().Contains(searchValue))
                {
                    row.Visible = true;
                    hasVisibleRows = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
            if (hasVisibleRows)
            {
                dataGridViewGuestTable.Rows[0].Selected = true;
            }
            if (!hasVisibleRows && !string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxSearchGuest.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewGuestTable.ClearSelection();
            TextBoxFilterGuest.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ButtonSearchGuest.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxSearchGuest.Text))
            {
                MessageBox.Show($"Введите данные для поиска!", "Неудачный поиск гостя", 0,
                            MessageBoxIcon.Information);
                return;
            }
            labelKolvoSearchGuest.Visible = true;
            TextBoxKolvoSearchGuest.Visible = true;
            ButtonResetGuest.Enabled = true;
            ButtonDeleteGuest.Enabled = false;
            string searchText = TextBoxSearchGuest.Text.ToLower();
            int selectedColumnIndex = ComboBoxSearchGuest.SelectedIndex;
            bool found = false;

            foreach (DataGridViewRow row in dataGridViewGuestTable.Rows)
            {
                if (row.Cells[selectedColumnIndex].Value != null && row.Cells[selectedColumnIndex].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Selected = true;
                    found = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
            TextBoxKolvoSearchGuest.Text = dataGridViewGuestTable.SelectedRows.Count.ToString();
            if (!found)
            {
                MessageBox.Show($"Гость с введёнными данными: {searchText} - отсутствует!", "Неудачный поиск гостя", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxKolvoSearchGuest.Text = "";
            TextBoxKolvoSearchGuest.Visible = false;
            labelKolvoSearchGuest.Visible = false;
            TextBoxSearchGuest.Text = "";
            foreach (DataGridViewRow row in dataGridViewGuestTable.Rows)
            {
                row.Selected = false;
            }
            ButtonDeleteGuest.Enabled = true;
            ButtonResetGuest.Enabled = false;
            ButtonSearchGuest.Enabled = false;

        }
        private async void dataGridViewGuestTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewGuestTable.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string surname = selectedRow.Cells[1].Value.ToString();
            string email = selectedRow.Cells[2].Value.ToString();
            int seatNumber = Convert.ToInt32(selectedRow.Cells[3].Value);

            GuestForm guestForm = new GuestForm(name, surname, email,seatNumber);
            guestForm.ShowDialog();

            string modName = GuestForm.NameGuestForm;
            string modSurname = GuestForm.LastNameGuestForm;
            string modEmail = GuestForm.EmailGuestForm;
            int modNumberPlace = GuestForm.SeatNumberGuestForm;

            Guests modifiedParticipant = new Guests(modName,
                modSurname, modEmail, modNumberPlace);

            var guests = await ReadFromFile<Guests>(FileGuest);

            foreach (var g in guests)
            {
                if (name == g.NameGuest && surname == g.LastNameGuest
                    && seatNumber == g.SeatNumberGuest && email == g.EmailGuest)
                {
                    if (!(modName.Equals(name) && modSurname.Equals(surname) && modEmail.Equals(email) && modNumberPlace == seatNumber))
                    {
                        guests.Remove(g);
                        guests.Add(modifiedParticipant);
                        selectedRow.Cells[0].Value = modName;
                        selectedRow.Cells[1].Value = modSurname;
                        selectedRow.Cells[2].Value = modEmail;
                        selectedRow.Cells[3].Value = modNumberPlace;
                        dataGridViewGuestTable.Refresh();
                        MessageBox.Show($"Гость {g.NameGuest} изменён!", "Изменение участника", 0,
                            MessageBoxIcon.Information);
                        GuestForm.NameGuestForm = "";
                        GuestForm.LastNameGuestForm = "";
                        GuestForm.EmailGuestForm = "";
                        GuestForm.SeatNumberGuestForm = 0;
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Гость {g.NameGuest} не был изменён, внесите изменения!",
                            "Неудачное изменение участника", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(guests, FileGuest);
        }

        private async void TextBoxFilterGuest_Enter(object sender, EventArgs e)
        {
            var guests = await ReadFromFile<Guests>(FileGuest);
            countGuest = guests.Count;
            if (countGuest == 0)
            {
                TextBoxFilterGuest.Enabled = false;
                ComboBoxFilterGuest.Text = "";
                MessageBox.Show("Нет ни одного гостя!", "Неудачная фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            await WriteToFile(guests, FileGuest);
        }
    }
}
