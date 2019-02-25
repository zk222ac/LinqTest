using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
   public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int DurationInMin { get; set; }
        public string StudioName { get; set; }

        public Movie(int id ,string title, int year, int durationInMin, string sN)
        {
            MovieId = id;
            Title = title;
            Year = year;
            DurationInMin = durationInMin;
            StudioName = sN;
        }
        public override string ToString()
        {
            return $"ID:{MovieId}, Title :{Title}, Year:{Year}, DurationInMin:{DurationInMin} , StudioName: {StudioName}";
        }
        
    }
}
