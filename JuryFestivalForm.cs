using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class JuryFestivalForm : Form
    {
        const string FileJury = "Jury.json";

        int numbersJury = 0;
        int countJury = 0;
        public JuryFestivalForm()
        {
            Task.Run(() => File.Open(FileJury, FileMode.OpenOrCreate).Close());
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
        async private void ButtonCreateJury_Click(object sender, EventArgs e)
        {
            JuryForm formJury = new JuryForm();
            formJury.ShowDialog();
            string nameJuryForm = JuryForm.NameJuryForm;
            string lastNameJuryForm = JuryForm.LastNameJuryForm;
            string postJuryForm = JuryForm.PostJuryForm;

            Jury newJury = new Jury(nameJuryForm, lastNameJuryForm, postJuryForm);

            if (!string.IsNullOrEmpty(nameJuryForm) &&
                !string.IsNullOrEmpty(lastNameJuryForm) &&
                !string.IsNullOrEmpty(postJuryForm))
            {
                var jurys = await ReadFromFile<Jury>(FileJury);

                if (!jurys.Contains(newJury))
                {
                    foreach (var twoJury in jurys)
                    {
                        if (twoJury.NameJury == nameJuryForm &&
                            twoJury.LastNameJury == lastNameJuryForm &&
                            twoJury.PostJury == postJuryForm)
                        {
                            MessageBox.Show($"Жюри {twoJury.NameJury} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление жюри", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }

                    jurys.Add(newJury);
                    countJury = jurys.Count;
                    TextBoxCountJury.Text = Convert.ToString(countJury);


                    await WriteToFile(jurys, FileJury);

                    dataGridViewJuryTable.Rows.Add(nameJuryForm, lastNameJuryForm, postJuryForm);
                    MessageBox.Show($"Член жюри {nameJuryForm} успешно добавлен в базу " +
                           $"Фестиваль фильмов. ", "Добавление члена жюри", 0,
                           MessageBoxIcon.Information);
                    JuryForm.NameJuryForm = "";
                    JuryForm.LastNameJuryForm = "";
                    JuryForm.PostJuryForm = "";
                }
                else
                {
                    MessageBox.Show($"Этот член жюри был занесён в базу фестиваль фильмов ранее",
                        "Добавление жюри", 0,
                        MessageBoxIcon.Information);
                    return;
                }
            }
        }
        async private void JuryFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileJury))
            {
                var tableOfJury = await ReadFromFile<Jury>(FileJury);
                numbersJury = 0;
                countJury = tableOfJury.Count;
                TextBoxCountJury.Text = Convert.ToString(countJury);

                if (tableOfJury != null)

                    foreach (var jurys in tableOfJury)
                    {
                        dataGridViewJuryTable.Rows.Add();
                        dataGridViewJuryTable.Rows[numbersJury].Cells[0].Value = jurys.NameJury;
                        dataGridViewJuryTable.Rows[numbersJury].Cells[1].Value = jurys.LastNameJury;
                        dataGridViewJuryTable.Rows[numbersJury].Cells[2].Value = jurys.PostJury;
                        numbersJury++;
                    }
            }
        }

        async private void ButtonAllDeleteJury_Click(object sender, EventArgs e)
        {
            var jurys = await ReadFromFile<Jury>(FileJury);
            countJury = jurys.Count;
            if (countJury == 0)
            {
                MessageBox.Show("Нет ни одного члена жюри!", "Удалить всех членов жюри", 0,
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                jurys.Clear();
                await WriteToFile(jurys, FileJury);
                TextBoxCountJury.Text = jurys.Count.ToString();
                dataGridViewJuryTable.Rows.Clear();
                numbersJury = 0;
                labelKolvoSearchJury.Visible = false;
                TextBoxKolvoSearhJury.Visible = false;
                TextBoxSearchJury.Text = "";
                ComboBoxSearchJury.Text = "";
                ComboBoxFilterJury.Text = "";
                TextBoxFilterJury.Text = "";
                labelFilterShowJury.Visible = false;
                ButtonSearchJury.Enabled = false;
                ButtonResetSearchJury.Enabled = false;
                MessageBox.Show("Данные всех членов жюри удалены!", "Удалить всех членов жюри", 0,
                    MessageBoxIcon.Information);
            }
        }

        private void ButtonCloseJuryTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void ButtonDeleteJury_Click(object sender, EventArgs e)
        {
            if (dataGridViewJuryTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                   "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
            int selectCount = dataGridViewJuryTable.SelectedRows[0].Index;

            if (selectCount >= 0 && dataGridViewJuryTable.SelectedRows.Count != 0)
            {
                var jurys = await ReadFromFile<Jury>(FileJury);
                if (jurys.Count == 1)
                {
                    TextBoxFilterJury.Text = "";
                    TextBoxFilterJury.Enabled = false;
                    ComboBoxFilterJury.SelectedIndex = -1;
                }
                string nameJury = dataGridViewJuryTable.Rows[selectCount].Cells[0].Value.ToString();
                string lastNameJury = dataGridViewJuryTable.Rows[selectCount].Cells[1].Value.ToString();
                string postJury = dataGridViewJuryTable.Rows[selectCount].Cells[2].Value.ToString();

                foreach (var twoJury in jurys)
                {
                    if (nameJury == twoJury.NameJury && lastNameJury == twoJury.LastNameJury
                        && postJury == twoJury.PostJury)
                    {
                        jurys.Remove(twoJury);
                        TextBoxCountJury.Text = Convert.ToString(jurys.Count);
                        dataGridViewJuryTable.Rows.Remove(dataGridViewJuryTable.Rows[selectCount]);
                        dataGridViewJuryTable.Refresh();
                        TextBoxKolvoSearhJury.Text = dataGridViewJuryTable.SelectedRows.Count.ToString();
                        MessageBox.Show($"Член жюри {twoJury.NameJury}  удалён!", "Удаление одного члена жюри",
                            0, MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(jurys, FileJury);
            }
            else
            {
                MessageBox.Show("Нет ни одного члена жюри или вы не выбрали члена жюри для удаления!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        private async void dataGridViewJuryTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewJuryTable.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string surname = selectedRow.Cells[1].Value.ToString();
            string post = selectedRow.Cells[2].Value.ToString();

            JuryForm juryFestival = new JuryForm(name, surname, post);
            juryFestival.ShowDialog();

            string modName = JuryForm.NameJuryForm;
            string modSurname = JuryForm.LastNameJuryForm;
            string modPost = JuryForm.PostJuryForm;

            Jury modifiedJury = new Jury(modName,
                modSurname, modPost);

            var jurys = await ReadFromFile<Jury>(FileJury);

            foreach (var j in jurys)
            {
                if (name == j.NameJury && surname == j.LastNameJury &&
                     post == j.PostJury)
                {
                    if (!(modName.Equals(name) && modSurname.Equals(surname) && modPost.Equals(post)))
                    {
                        jurys.Remove(j);
                        jurys.Add(modifiedJury);
                        selectedRow.Cells[0].Value = modName;
                        selectedRow.Cells[1].Value = modSurname;
                        selectedRow.Cells[2].Value = modPost;
                        dataGridViewJuryTable.Refresh();
                        MessageBox.Show($"Жюри {j.NameJury} изменён!", "Изменение жюри", 0,
                            MessageBoxIcon.Information);
                        JuryForm.NameJuryForm = "";
                        JuryForm.LastNameJuryForm = "";
                        JuryForm.PostJuryForm = "";
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Жюри {j.NameJury} не был изменён, внесите изменения!", "Неудачное изменение жюри", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(jurys, FileJury);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxFilterJury.Text.Length != 0)
            {
                labelFilterShowJury.Visible = true;
            }
            else
                labelFilterShowJury.Visible = false;
            if (ComboBoxFilterJury.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для фильтрации!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = TextBoxFilterJury.Text; 
            int columnIndex = ComboBoxFilterJury.SelectedIndex; 
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in dataGridViewJuryTable.Rows)
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
                dataGridViewJuryTable.Rows[0].Selected = true;
            }
            if (!hasVisibleRows && !string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewJuryTable.ClearSelection();
            TextBoxFilterJury.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxSearchJury.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxSearchJury.Text))
            {
                MessageBox.Show($"Введите данные члена жюри для поиска!", "Неудачный поиск члена жюри", 0,
                            MessageBoxIcon.Information);
                return;
            }
            TextBoxKolvoSearhJury.Visible = true;
            labelKolvoSearchJury.Visible = true;
            ButtonResetSearchJury.Enabled = true;
            ButtonDeleteJury.Enabled = false;
            string searchText = TextBoxSearchJury.Text.ToLower();
            int selectedColumnIndex= ComboBoxSearchJury.SelectedIndex;
            bool found = false;

            foreach (DataGridViewRow row in dataGridViewJuryTable.Rows)
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
            TextBoxKolvoSearhJury.Text = dataGridViewJuryTable.SelectedRows.Count.ToString();
            if (!found)
            {
                MessageBox.Show($"Жюри с введёнными данными: {searchText} - отсутствует!", "Неудачный поиск жюри", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxSearchJury.Text = "";
            TextBoxKolvoSearhJury.Text = "";
            TextBoxKolvoSearhJury.Visible = false;
            labelKolvoSearchJury.Visible = false;
            ButtonDeleteJury.Enabled=true;
            foreach (DataGridViewRow row in dataGridViewJuryTable.Rows)
            {
                row.Selected = false;
            }
            ButtonResetSearchJury.Enabled = false;
            ButtonSearchJury.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ButtonSearchJury.Enabled = true;
        }

        private void labelKolvoSearchJury_Click(object sender, EventArgs e)
        {

        }

        private async void TextBoxFilterJury_Enter(object sender, EventArgs e)
        {
            var jurys = await ReadFromFile<Jury>(FileJury);
            countJury = jurys.Count;
            if (countJury == 0)
            {
                TextBoxFilterJury.Enabled = false;
                ComboBoxFilterJury.Text = "";
                MessageBox.Show("Нет ни одного члена жюри!", "Неудачная фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            await WriteToFile(jurys, FileJury);
        }
    }
}
