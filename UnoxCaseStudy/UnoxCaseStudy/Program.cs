using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoxCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<Movie>> Auditlog = new Dictionary<string, List<Movie>>();
            Console.WriteLine("Welcome to unox MultiPlex");
            Console.WriteLine("Please Enter your User Name");
            string username = Console.ReadLine();
            Console.WriteLine($"Welcome Back {username}");
            while (true)
            {
                Console.WriteLine("Please Enter your Preference");
                Console.WriteLine("1. Book the Movie Ticket");
                Console.WriteLine("2. See the All Payment Transaction");
                Console.WriteLine("3. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BooktheMovieTicket();
                        break;
                    case 2:
                        SeethePaymentTranscation();
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
                Console.WriteLine("Do you want to Book aticket Again Press 1");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void SeethePaymentTranscation()
        {
            Console.WriteLine("*** Payment Successfull****");



        }

        private static void BooktheMovieTicket()
        {
            Console.WriteLine("*** MOvieDetails****");

            List<Movie> Movies = new List<Movie>(); 
            Movie movie1 = new Movie()
            {
                MovieName = "BatlaHouse",
                Screen = "A"
            };
            Movie movie2 = new Movie()
            {
                MovieName = "SpiderMan",
                Screen = "B"
            };
            Movie movie3 = new Movie()
            {
                MovieName = "Avengers",
                Screen = "A"
            };

            Movies.Add(movie1);
            Movies.Add(movie2);
            Movies.Add(movie3);
            foreach (var item in Movies)
            {
                Console.WriteLine(item.MovieName);
                Console.WriteLine(item.Screen);
                Console.WriteLine();
            }
        }
    }
    class Movie
    {
        public string MovieName { get; set; }
        public string Screen { get; set; }
    }
}
