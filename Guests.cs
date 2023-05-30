using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_FestivalFilmov_Afonin
{
   public class Guests
    {
        public string NameGuest { get; set; }  //имя гостя
        public string LastNameGuest { get; set; }  //фамилия гостя
        public int SeatNumberGuest { get; set; } //номер места гостя
        public string EmailGuest { get; set; } //Электронная почта

        public Guests(string nameGuest, string lastNameGuest, string emailGuest,int seatNumberGuest)
        {
            NameGuest = nameGuest;
            LastNameGuest = lastNameGuest;
            EmailGuest = emailGuest;
            SeatNumberGuest = seatNumberGuest;
        }
    }
}
