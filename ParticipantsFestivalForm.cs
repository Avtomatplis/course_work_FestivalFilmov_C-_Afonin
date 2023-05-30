using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class ParticipantsFestivalForm : Form
    {
        const string FileParticipants = "Participants.json";
        //const string FileFilm = "Film.json";

        int numberParticipants = 0;
        int countParticipants = 0;

        public ParticipantsFestivalForm()
        {
            Task.Run(() => File.Open(FileParticipants, FileMode.OpenOrCreate).Close());
            //  Task.Run(() => File.Open(FileFilm, FileMode.OpenOrCreate).Close());
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

        //  чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        async private void ButtonCreateParticipants_Click(object sender, EventArgs e)
        {

            ParticipantsForm formParticipants = new ParticipantsForm();
            formParticipants.ShowDialog();

            string nameParticipantsForm = ParticipantsForm.NameParticipantsForm;
            string lastNameParticipantsForm = ParticipantsForm.LastNameParticipantsForm;
            string cityParticipantsForm = ParticipantsForm.CityParticipantsForm;
            int ageParticipantsForm = ParticipantsForm.AgeParticipantsForm;

            Participants newParticipants = new Participants(nameParticipantsForm, lastNameParticipantsForm,
                cityParticipantsForm, ageParticipantsForm);
            if (!string.IsNullOrEmpty(nameParticipantsForm) &&
                (ageParticipantsForm > 0) &&
                !string.IsNullOrEmpty(lastNameParticipantsForm) &&
                !string.IsNullOrEmpty(cityParticipantsForm)) 
            {
                var participants = await ReadFromFile<Participants>(FileParticipants);

                if (!participants.Contains(newParticipants))
                {
                    foreach (var twoparticipants in participants)
                    {
                        if (twoparticipants.Name == nameParticipantsForm &&
                            twoparticipants.LastName == lastNameParticipantsForm &&
                            twoparticipants.City == cityParticipantsForm &&
                             twoparticipants.Age == ageParticipantsForm)
                        {
                            MessageBox.Show($"Участник {twoparticipants.Name} уже занесён" +
                                $" в базу Фестиваль фильмов. ", "Добавление участника",
                                0, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    participants.Add(newParticipants);
                    countParticipants = participants.Count;
                    TextBoxCountParticipants.Text = Convert.ToString(countParticipants);


                    await WriteToFile(participants, FileParticipants);

                    dataGridViewParticipantsTable.Rows.Add(nameParticipantsForm, lastNameParticipantsForm,
                       cityParticipantsForm , ageParticipantsForm);
                    MessageBox.Show($"Участник {nameParticipantsForm} успешно добавлен в базу " +
                           $"Фестиваль фильмов. ", "Добавление участника", 0,
                           MessageBoxIcon.Information);
                    ParticipantsForm.NameParticipantsForm = "";
                    ParticipantsForm.LastNameParticipantsForm = "";
                    ParticipantsForm.CityParticipantsForm = "";
                    ParticipantsForm.AgeParticipantsForm = 0;
                }
                else
                {
                    MessageBox.Show($"Этот участник был занесён в базу Фестиваль фильмов ранее",
                        "Добавление участника", 0,MessageBoxIcon.Information);
                    return;
                }
            }
        }
        async private void ParticipantsFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileParticipants))
            {

                var tableOfParticipants = await ReadFromFile<Participants>(FileParticipants);

                countParticipants = tableOfParticipants.Count;
                TextBoxCountParticipants.Text = Convert.ToString(countParticipants);

                if (tableOfParticipants != null)

                    foreach (var participants in tableOfParticipants)
                    {
                        dataGridViewParticipantsTable.Rows.Add();
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[0].Value = participants.Name;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[1].Value = participants.LastName;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[2].Value = participants.City;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[3].Value = participants.Age;
                        numberParticipants++;
                    }
            }
        }
        async  private void ButtonDeleteParticipants_Click(object sender, EventArgs e)
        {
            if (dataGridViewParticipantsTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                   "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
            int selectCount = dataGridViewParticipantsTable.SelectedRows[0].Index;

            if (selectCount >= 0 && dataGridViewParticipantsTable.SelectedRows.Count != 0)
            {
                var participants = await ReadFromFile<Participants>(FileParticipants);
                if (participants.Count == 1)
                {
                    TextBoxFilterParticipants.Text = "";
                    TextBoxFilterParticipants.Enabled = false;
                    ComboBoxFilterParticipants.SelectedIndex = -1;
                }
                string name = dataGridViewParticipantsTable.Rows[selectCount].Cells[0].Value.ToString();
                string lastName = dataGridViewParticipantsTable.Rows[selectCount].Cells[1].Value.ToString();
                string city = dataGridViewParticipantsTable.Rows[selectCount].Cells[2].Value.ToString();
                int age = Convert.ToInt32(dataGridViewParticipantsTable.Rows[selectCount].Cells[3].Value.ToString());

                foreach (var twoparticipants in participants)
                {
                    if (name == twoparticipants.Name && lastName == twoparticipants.LastName && city == twoparticipants.City
                        && age == twoparticipants.Age)
                    {
                        participants.Remove(twoparticipants);
                        TextBoxCountParticipants.Text = Convert.ToString(participants.Count);
                        dataGridViewParticipantsTable.Rows.Remove(dataGridViewParticipantsTable.Rows[selectCount]);
                        dataGridViewParticipantsTable.Refresh();
                        textBoxKolvoSearchParticipants.Text = dataGridViewParticipantsTable.SelectedRows.Count.ToString();
                        MessageBox.Show($"Участник  {twoparticipants.Name}  удалён!", "Удаление одного" +
                            " участника", 0,MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(participants, FileParticipants);
            }
            else
            {
                MessageBox.Show("Нет ни одного участника или вы не выбрали участника для удаления!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }
       async private void ButtonAllDeleteParticipants_Click(object sender, EventArgs e)
        {
            var participants = await ReadFromFile<Participants>(FileParticipants);
            countParticipants = participants.Count;
            if (countParticipants == 0)
            {
                MessageBox.Show("Нет ни одного участника!", "Удалить всех участников", 0, 
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                participants.Clear();
                await WriteToFile(participants, FileParticipants);
                TextBoxCountParticipants.Text = participants.Count.ToString();
                dataGridViewParticipantsTable.Rows.Clear();
                numberParticipants = 0;
                textBoxKolvoSearchParticipants.Visible = false;
                ComboBoxSearchPerticipants.Text = "";
                TextBoxSearchParticipants.Text = "";
                TextBoxFilterParticipants.Text = "";
                ComboBoxFilterParticipants.Text = "";
                labelKolvoSearchParticipants.Visible=false;
                ButtonSearchParticipants.Enabled = false;
                ButtonResetSearchParticipants.Enabled = false;
                labelFilterShowParticipants.Visible = false;
                MessageBox.Show("Данные всех участников удалены!", "Удалить всех участников", 
                    0, MessageBoxIcon.Information);
            }
          
        }
        private void ButtonCloseFilmTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void dataGridViewParticipantsTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewParticipantsTable.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string surname = selectedRow.Cells[1].Value.ToString();
            string city = selectedRow.Cells[2].Value.ToString();
            int age = Convert.ToInt32(selectedRow.Cells[3].Value);

            ParticipantsForm oldParticipant = new ParticipantsForm(name, surname, city, age);
            oldParticipant.ShowDialog();

            string modName = ParticipantsForm.NameParticipantsForm;
            string modSurname = ParticipantsForm.LastNameParticipantsForm;
            string modCity = ParticipantsForm.CityParticipantsForm;
            int modAge = ParticipantsForm.AgeParticipantsForm;

            Participants modifiedParticipant = new Participants(modName,
                modSurname, modCity, modAge);

            var participants = await ReadFromFile<Participants>(FileParticipants);

            foreach (var p in participants)
            {
                if (name == p.Name && surname == p.LastName
                     && city == p.City && age == p.Age)
                {
                    if (!(modName.Equals(name) && modSurname.Equals(surname) && modCity.Equals(city) && modAge == age))
                    {
                        participants.Remove(p);
                        participants.Add(modifiedParticipant);
                        selectedRow.Cells[0].Value = modName;
                        selectedRow.Cells[1].Value = modSurname;
                        selectedRow.Cells[2].Value = modCity;
                        selectedRow.Cells[3].Value = modAge;
                        dataGridViewParticipantsTable.Refresh();
                        MessageBox.Show($"Участник {p.Name} изменён!", "Изменение участника", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Участник {p.Name} не был изменён, внесите изменения!", "Неудачное изменение участника", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(participants, FileParticipants);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxFilterParticipants.Text.Length != 0)
            {
                labelFilterShowParticipants.Visible = true;
            }
            else
                labelFilterShowParticipants.Visible = false;
            if (ComboBoxFilterParticipants.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для фильтрации!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = TextBoxFilterParticipants.Text; 
            int columnIndex = ComboBoxFilterParticipants.SelectedIndex; 
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in dataGridViewParticipantsTable.Rows)
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
                dataGridViewParticipantsTable.Rows[0].Selected = true;
            }
            if (!hasVisibleRows && !string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ButtonSearchParticipants.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxSearchParticipants.Text))
            {
                MessageBox.Show($"Введите данные участника для поиска!", "Неудачный поиск участника", 0,
                            MessageBoxIcon.Information);
                return;
            }
            labelKolvoSearchParticipants.Visible = true;
            textBoxKolvoSearchParticipants.Visible = true;
            ButtonResetSearchParticipants.Enabled = true;
            string searchText = TextBoxSearchParticipants.Text.ToLower();
            int selectedColumnIndex = ComboBoxSearchPerticipants.SelectedIndex;
            ButtonDeleteParticipants.Enabled = false;
            bool found = false;
            foreach (DataGridViewRow row in dataGridViewParticipantsTable.Rows)
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
            textBoxKolvoSearchParticipants.Text = dataGridViewParticipantsTable.SelectedRows.Count.ToString();
            if (!found)
            {
                MessageBox.Show($"Участник с введёнными данными: {searchText} - отсутствует!", "Неудачный поиск участника", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxSearchParticipants.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewParticipantsTable.ClearSelection();
            TextBoxFilterParticipants.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxKolvoSearchParticipants.Text = "";
            textBoxKolvoSearchParticipants.Visible = false;
            labelKolvoSearchParticipants.Visible = false;
            TextBoxSearchParticipants.Text = "";
            foreach (DataGridViewRow row in dataGridViewParticipantsTable.Rows)
            {
                row.Selected = false;
            }
            ButtonResetSearchParticipants.Enabled = false;
            TextBoxSearchParticipants.Focus();
            ButtonSearchParticipants.Enabled = false;
            ButtonDeleteParticipants.Enabled = true;
        }

        private void textBoxKolvoSearchParticipants_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxCountParticipants_TextChanged(object sender, EventArgs e)
        {

        }

        private async void TextBoxFilterParticipants_Enter(object sender, EventArgs e)
        {
            var participants = await ReadFromFile<Participants>(FileParticipants);
            countParticipants = participants.Count;
            if (countParticipants == 0)
            {
                TextBoxFilterParticipants.Enabled = false;
                ComboBoxFilterParticipants.Text = "";
                MessageBox.Show("Нет ни одного участника!", "Неудачная фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            await WriteToFile(participants, FileParticipants);
        }
    }
}
