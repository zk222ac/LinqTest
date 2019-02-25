using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Studio> studios = new List<Studio>()
            {
                new Studio(1,"New Line Cinema" , "Boston",4000),
                new Studio(2,"20th Century Fox" , "New York",2500),
                new Studio(3,"Paramount Pictures" , "New York",8000),
            };

            List<Movie> movies = new List<Movie>()
            {
                new Movie(101,"Se7en" , 1995 ,127 , "New Line Cinema"),
                new Movie(102,"Alien" , 2010 ,100 , "20th Century Fox"),
                new Movie(103,"Forrest Gump" , 2001 ,140 , "Paramount Pictures"),
                new Movie(104,"True Grit" , 2005 ,150 , "20th Century Fox"),
                new Movie(105,"Dark City" , 2019 ,190 , "Paramount Pictures"),

            };

            // Single Property Selection Type 
            // select single property from all list
            //
            //IEnumerable<string> titles = from movie in movies
            //    select movie.StudioName;
            // Lambda Expression 
            var titles = movies.Select(m => new {m.Title, m.StudioName});
             GetMoviesAndTitlesPrint(titles);  
           // GetMoviesPrint(titles);

            // Select Multiple properties 

            var titlesAndStudioName = (from movie in movies
                where (movie.Year > 2000) && (movie.Year < 2019)
                orderby movie.Year, movie.Title
                select new {movie.StudioName, movie.Title, movie.Year});
            int count = titlesAndStudioName.Count();
           
            // Joining Table................................ 
            var joiningMovieStudio = from m in movies
                join s in studios
                on m.StudioName equals s.StudioName
                where( s.City == "New York") || (s.City == "Boston")
                select new {m.Title, s.StudioName, m.DurationInMin};

            GetMoviesAndTitlesPrint(joiningMovieStudio);
            //GetMoviesAndTitlesPrint(titlesAndStudioName);
            // -------------------------------
            // Anonymous Type 
            int[] numbers = {5, 4, 3, 2, 7, 9, 8, 0, 1, 6};
            string[] words = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "night"};

            var digitsOddEven = from n in numbers
                select new {Digits = words[n], Even = (n % 2 == 0)};

            foreach (var dig in digitsOddEven)
            {
                Console.WriteLine("The digit {0} is {1}," , dig.Digits, dig.Even? "even":"odd");
            }


          //--------------------------------------
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void GetMoviesPrint(IEnumerable<string> movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
        static void GetMoviesAndTitlesPrint(dynamic movies)
        {
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
    }
}
