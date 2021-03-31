using System;
using System.Collections.Generic;

namespace Lab_4._2
{
    class Movie
    {
        public string Title;
        public string Category;

        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> myMovies = new List<Movie>();
            myMovies.Add(new Movie("Thor", "scifi"));
            myMovies.Add(new Movie("Cinderella", "animated"));
            myMovies.Add(new Movie("Harry Potter", "scifi"));
            myMovies.Add(new Movie("Lord of the Rings", "scifi"));
            myMovies.Add(new Movie("Forzen", "animated"));
            myMovies.Add(new Movie("Princess and the Frog", "animated"));
            myMovies.Add(new Movie("The Notebook", "drama"));
            myMovies.Add(new Movie("Forest Gump", "drama"));
            myMovies.Add(new Movie("Saw", "horror"));
            myMovies.Add(new Movie("Thirteen Ghosts", "horror"));

            bool done = false;
            while (!done)
            {
                Console.WriteLine("Enter animated, drama, horror, or scifi to see our selections.");
                string userGenre = Console.ReadLine().ToLower();
                while (userGenre != "drama" && userGenre != "scifi" && userGenre != "horror" && userGenre != "animated")
                {
                    Console.WriteLine("Invalid selection || Try typing: animated, drama, horror, or scifi.");
                    userGenre = Console.ReadLine().ToLower();
                }
                Console.WriteLine();
                Console.WriteLine($"You selected {userGenre}.");
                Console.WriteLine();
                Console.WriteLine("Titles in this category: ");
                foreach (Movie aMovie in myMovies)
                {
                    if (aMovie.Category == userGenre)
                    {
                        Console.WriteLine($"- {aMovie.Title}");
                    }
                }
                Console.WriteLine();
                Console.Write("Go again? (Y/N) ");
                string goAgain = Console.ReadLine().ToLower();
                while (goAgain != "n" && goAgain != "no" && goAgain != "y" && goAgain != "yes")
                {
                    Console.WriteLine("Invalid selection || Try typing: Y, N, Yes, or No. ");
                    goAgain = Console.ReadLine().ToLower();

                }
                if (goAgain == "n" || goAgain == "no")
                {
                    done = true;
                }
                Console.WriteLine();
            }

        }


    }
}
