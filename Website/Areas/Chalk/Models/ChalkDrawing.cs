using System;
using System.ComponentModel.DataAnnotations;

namespace Website.Areas.Chalk.Models
{
    public class ChalkDrawing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PathName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}