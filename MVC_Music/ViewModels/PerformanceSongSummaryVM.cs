using MVC_Music.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MVC_Music.ViewModels
{
    public class PerformanceSongSummaryVM
    {
        public int ID { get; set; }

        [Display(Name = "Musician")]
        public string FormalName
        {
            get
            {
                return LastName + ", " + FirstName
                    + (string.IsNullOrEmpty(MiddleName) ? "" :
                        (" " + (char?)MiddleName[0] + ".").ToUpper());
            }
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Average Fee paid")]
        [DataType(DataType.Currency)]
        public double AverageFeePaid { get; set; }

        [Display(Name = "Highest Fee paid")]
        [DataType(DataType.Currency)]
        public double HighestFeePaid { get; set; }

        [Display(Name = "Lowest Fee paid")]
        [DataType(DataType.Currency)]
        public double LowestFeePaid { get; set; }

        //[Display(Name = "Number of Musicians")]
        //public int NumberOfMusicians { get; set; }

        [Display(Name = "Number of Performances")]
        public int NumberOfPerformances { get; set; }

        [Display(Name = "Number of Songs")]
        public int NumberOfSongs { get; set; }

        //[Display(Name = "Song")]
        //public int SongID { get; set; }
        //public Song Song { get; set; }

    }
}
