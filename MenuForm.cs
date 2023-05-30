using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void ButtonCloseMainForm_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ButtonAccountingFilm_Click(object sender, EventArgs e)
        {
            FilmFestivalForm filmFestival = new FilmFestivalForm();
            filmFestival.ShowDialog();
        }

        private void ButtonAccountingParticipants_Click(object sender, EventArgs e)
        {
            ParticipantsFestivalForm participantsFestivalForm = new ParticipantsFestivalForm();
            participantsFestivalForm.ShowDialog();
        }

        private void ButtonAccountingJury_Click(object sender, EventArgs e)
        {
            JuryFestivalForm juryFestivalForm = new JuryFestivalForm();
            juryFestivalForm.ShowDialog();
        }

        private void ButtonAccountingGuest_Click(object sender, EventArgs e)
        {
            GuestFestivalForm guestFestivalForm = new GuestFestivalForm();
            guestFestivalForm.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

    }
}
