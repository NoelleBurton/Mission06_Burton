﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Burton.Models
{
    public class AddMovie
    {
        [Key]
        public int MovieID { get; set; }

        [ForeignKey("CategoryID")]
        public string CategoryID { get; set; }
        public Category Category { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }

        public string CopiedToPlex { get; set; }
        public string Notes { get; set; }
    }
}
