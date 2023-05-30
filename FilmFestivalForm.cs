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

namespace course_work_FestivalFilmov_Afonin
{
    public partial class FilmFestivalForm : Form
    {
        const string FileFilm = "Films.json";

        int numbersFilm = 0;
        int countFilm = 0;
        public FilmFestivalForm()
        {
            Task.Run(() => File.Open(FileFilm, FileMode.OpenOrCreate).Close());
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

        async private void ButtonCreateFilm_Click(object sender, EventArgs e)
        {
            FilmForm formFilm = new FilmForm();
            formFilm.ShowDialog();
            string nameFilmForm = FilmForm.NameFilmForm;
            string nominationFilmForm = FilmForm.NominationFilmForm;
            int ticketPriceForm = FilmForm.TicketPriceForm;
            string ratingFilmForm = FilmForm.RatingFilmForm;

            Film newFilm = new Film(nameFilmForm,
                nominationFilmForm, ticketPriceForm, ratingFilmForm);

            if (!string.IsNullOrEmpty(nameFilmForm) &&
                !string.IsNullOrEmpty(nominationFilmForm)&&
                (ticketPriceForm > 0) &&
                !string.IsNullOrEmpty(ratingFilmForm))
            {
                var films = await ReadFromFile<Film>(FileFilm);

                if (!films.Contains(newFilm))
                {
                    foreach (var twoFilms in films)
                    {
                        if (twoFilms.NameFilm == nameFilmForm &&
                            twoFilms.NominationFilm == nominationFilmForm &&
                            twoFilms.TicketPrice == ticketPriceForm &&
                            twoFilms.RatingFilm == ratingFilmForm)
                        {
                            MessageBox.Show($"Фильм {twoFilms.NameFilm} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление фильма", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }

                    films.Add(newFilm);
                    countFilm = films.Count;
                    TextBoxCountFilm.Text = Convert.ToString(countFilm);


                    await WriteToFile(films, FileFilm);

                    dataGridViewFilmTable.Rows.Add(nameFilmForm, nominationFilmForm, ticketPriceForm,
                              ratingFilmForm);
                    MessageBox.Show($"Фильм {nameFilmForm} успешно добавлен в базу " +
                                $"Фестиваль фильмов. ", "Добавление фильма", 0,
                                MessageBoxIcon.Information);
                    FilmForm.NameFilmForm = "";
                    FilmForm.NominationFilmForm = "";
                    FilmForm.TicketPriceForm=0;
                    FilmForm.RatingFilmForm="";

                }
                else
                {
                    MessageBox.Show($"Этот фильм был занесён в базу фестиваль фильмов ранее",
                        "Добавление фильма", 0,
                        MessageBoxIcon.Information);
                    return;
                }
            }

        }
        async private void FilmFestivalForm_Load(object sender, EventArgs e)
        {
            dataGridViewFilmTable.AllowUserToAddRows = false;
            if (File.Exists(FileFilm))
            {
                var tableOfFilms = await ReadFromFile<Film>(FileFilm);
                numbersFilm = 0;
                countFilm = tableOfFilms.Count;
                TextBoxCountFilm.Text = Convert.ToString(countFilm);

                if (tableOfFilms != null)
                    foreach (var film in tableOfFilms)
                    {
                        dataGridViewFilmTable.Rows.Add();
                        dataGridViewFilmTable.Rows[numbersFilm].Cells[0].Value = film.NameFilm;
                        dataGridViewFilmTable.Rows[numbersFilm].Cells[1].Value = film.NominationFilm;
                        dataGridViewFilmTable.Rows[numbersFilm].Cells[2].Value = film.TicketPrice;
                        dataGridViewFilmTable.Rows[numbersFilm].Cells[3].Value = film.RatingFilm;
                        numbersFilm++;
                    }
            }
           
        }

        async private void ButtonDeleteFilm_Click(object sender, EventArgs e)
        {
         
            if (dataGridViewFilmTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                   "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
            int selectCount = dataGridViewFilmTable.SelectedRows[0].Index;

            if (selectCount >= 0  && dataGridViewFilmTable.SelectedRows.Count!=0)
            {
                var films = await ReadFromFile<Film>(FileFilm);
                if(films.Count==1)
                {
                    TextBoxFilterFilm.Text = "";
                    TextBoxFilterFilm.Enabled = false;
                    ComboBoxFilterFilm.SelectedIndex = -1;
                }
                string nameFilm = dataGridViewFilmTable.Rows[selectCount].Cells[0].Value.ToString();
                string nominationFilm = dataGridViewFilmTable.Rows[selectCount].Cells[1].Value.ToString();
                int ticketPrice = Convert.ToInt32(dataGridViewFilmTable.Rows[selectCount].Cells[2].Value.ToString());
                string ratingFilm = dataGridViewFilmTable.Rows[selectCount].Cells[3].Value.ToString(); ;

                foreach (var f in films)
                {
                    if (nameFilm == f.NameFilm && nominationFilm == f.NominationFilm
                        && ticketPrice == f.TicketPrice && ratingFilm == f.RatingFilm)
                    {
                        films.Remove(f);
                        TextBoxCountFilm.Text = Convert.ToString(films.Count);
                        dataGridViewFilmTable.Rows.Remove(dataGridViewFilmTable.Rows[selectCount]);
                        dataGridViewFilmTable.Refresh();
                        TextBoxKolvoSearchFilm.Text = dataGridViewFilmTable.SelectedRows.Count.ToString();
                        MessageBox.Show($"Фильм {f.NameFilm}  удалён!", "Удаление одного фильма", 0,
                            MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(films, FileFilm);
            }
            else
            {
                MessageBox.Show("Нет ни одного фильма или вы не выбрали фильм для удаленя!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        private void ButtonCloseFilmTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void ButtonAllDeleteFilm_Click(object sender, EventArgs e)
        {
            var films = await ReadFromFile<Film>(FileFilm);
            countFilm = films.Count;
            if (countFilm == 0)
            {
                MessageBox.Show("Нет ни одного фильма!", "Удалить все фильмы", 0, MessageBoxIcon.Information);
                return;
            }
            else
            {
                films.Clear();
                await WriteToFile(films, FileFilm);
                TextBoxCountFilm.Text = films.Count.ToString();
                dataGridViewFilmTable.Rows.Clear();
                numbersFilm = 0;
                labelKolvoSearch.Visible = false;
                TextBoxKolvoSearchFilm.Visible = false;
                TextBoxSearchFilm.Text = "";
                ComboBoxFilterFilm.Text = "";
                TextBoxFilterFilm.Text = "";
                ComboBoxFilterFilm.Text = "";
                labelFilterShowFilm.Visible=false;
                ButtonSearhFilm.Enabled = false;
                ButtonResetSearchFilm.Enabled = false;
                MessageBox.Show("Данные всех фильмов удалены!", "Удалить все фильмы", 0, MessageBoxIcon.Information);
            }
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (TextBoxFilterFilm.Text.Length != 0)
            {
                labelFilterShowFilm.Visible = true;
            }
            else
                labelFilterShowFilm.Visible = false;
            if (ComboBoxFilterFilm.SelectedIndex == -1)
            {
                MessageBox.Show($"Выберите поле для фильтрации!", "Внимание", 0, MessageBoxIcon.Information);
                return;
            }
            string searchValue = TextBoxFilterFilm.Text;
            int columnIndex = ComboBoxFilterFilm.SelectedIndex;
            bool hasVisibleRows = false;

            foreach (DataGridViewRow row in dataGridViewFilmTable.Rows)
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
            if(hasVisibleRows)
            {
                dataGridViewFilmTable.Rows[0].Selected = true;
            }
            if (!hasVisibleRows && !string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show($"Полей с такими данными: {searchValue} - нет!", "Внимание", 0, MessageBoxIcon.Information);
            }

        }

        private async void dataGridViewFilmTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewFilmTable.CurrentRow;

            string name = selectedRow.Cells[0].Value.ToString();
            string nomination = selectedRow.Cells[1].Value.ToString();
            int ticketPrice = Convert.ToInt32(selectedRow.Cells[2].Value);
            string rating = selectedRow.Cells[3].Value.ToString();

            FilmForm formFilm = new FilmForm(name, nomination, ticketPrice, rating);
            formFilm.ShowDialog();

            string nameFilmForm = FilmForm.NameFilmForm;
            string nominationFilmForm = FilmForm.NominationFilmForm;
            int ticketPriceForm = FilmForm.TicketPriceForm;
            string ratingFilmForm = FilmForm.RatingFilmForm;

            Film modifiedFilm = new Film(nameFilmForm,
                nominationFilmForm, ticketPriceForm, ratingFilmForm);

            var films = await ReadFromFile<Film>(FileFilm);

            foreach (var f in films)
            {
                if (name == f.NameFilm && nomination == f.NominationFilm
                    && ticketPrice == f.TicketPrice && rating == f.RatingFilm)
                {
                    if(!(nameFilmForm.Equals(name) && nominationFilmForm.Equals(nomination) && ticketPriceForm == ticketPrice && ratingFilmForm.Equals(rating)))
                    {
                        films.Remove(f);
                        films.Add(modifiedFilm);
                        selectedRow.Cells[0].Value = nameFilmForm;
                        selectedRow.Cells[1].Value = nominationFilmForm;
                        selectedRow.Cells[2].Value = ticketPriceForm;
                        selectedRow.Cells[3].Value = ratingFilmForm;
                        dataGridViewFilmTable.Refresh();
                        MessageBox.Show($"Фильм {f.NameFilm}  изменён!", "Изменение фильма", 0,
                            MessageBoxIcon.Information);
                        FilmForm.NameFilmForm = "";
                        FilmForm.NominationFilmForm = "";
                        FilmForm.TicketPriceForm = 0;
                        FilmForm.RatingFilmForm = "";
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Фильм {f.NameFilm} не был изменён, внесите изменения!", "Неудачное изменение фильма", 0,
                            MessageBoxIcon.Information);
                    }
                }
            }
            await WriteToFile(films, FileFilm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxSearchFilm.Text))
            {
                MessageBox.Show($"Введите название фильма для поиска!", "Неудачный поиск фильма", 0,
                            MessageBoxIcon.Information);
                return;
            }
            TextBoxKolvoSearchFilm.Visible = true;
            labelKolvoSearch.Visible = true;
            ButtonResetSearchFilm.Enabled = true;
            string searchText = TextBoxSearchFilm.Text.ToLower();
            ButtonDeleteFilm.Enabled = false;
            bool found = false;

            foreach (DataGridViewRow row in dataGridViewFilmTable.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Selected = true;
                    found = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
            TextBoxKolvoSearchFilm.Text= dataGridViewFilmTable.SelectedRows.Count.ToString();

            if (!found) 
            {
                MessageBox.Show($"Фильм с таким названием: {searchText} - отсутствует!", "Неудачный поиск фильма", 0,
                            MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxSearchFilm.Text = "";
            TextBoxKolvoSearchFilm.Text = "";
            TextBoxKolvoSearchFilm.Visible= false;
            labelKolvoSearch.Visible= false;
            foreach (DataGridViewRow row in dataGridViewFilmTable.Rows)
            {
                row.Selected = false;
            }
            ButtonResetSearchFilm.Enabled = false;
            ButtonSearhFilm.Enabled= false;
            ButtonDeleteFilm.Enabled= true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ButtonSearhFilm.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewFilmTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void TextBoxFilterFilm_Enter(object sender, EventArgs e)
        {
            var films = await ReadFromFile<Film>(FileFilm);
            countFilm = films.Count;
            if (countFilm == 0)
            {
                TextBoxFilterFilm.Enabled = false;
                ComboBoxFilterFilm.Text = "";
                MessageBox.Show("Нет ни одного фильма!", "Неудачная фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            await WriteToFile(films, FileFilm);

        }

        private void ComboBoxFilterFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewFilmTable.ClearSelection();
            TextBoxFilterFilm.Enabled = true;
        }
    }
}