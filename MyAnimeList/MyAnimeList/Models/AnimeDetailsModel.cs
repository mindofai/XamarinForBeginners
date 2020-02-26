using System;
using System.Collections.Generic;
using System.Text;

namespace MyAnimeList.Models
{
    public class AnimeDetailsModel
    {
        public int Id { get; set; }
        public string Website { get; set; }
        public string Title { get; set; }
        public string ImageSource { get; set; }
        public string Synopsis { get; set; }
        public double Rating { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
