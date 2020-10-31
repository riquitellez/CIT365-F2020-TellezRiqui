using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        [Display(Name = "Book name")]
        public string BookName { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }
        [Display(Name = "Study notes")]
        public string StudyNotes { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Creation date")]
        public DateTime CreationDate { get; set; }
    }
}
