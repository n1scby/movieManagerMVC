using System;
using System.Collections.Generic;
using System.Text;

namespace nb.MovieLibrary
{
    public class MovieRepository
    {
        public static List<Movie> _movies = new List<Movie>();
        public static int nextNum = 0;
        static bool listCreated = false;



        public void Add(Movie newMovie)
        {
            newMovie.Id = nextNum++;
            _movies.Add(newMovie);
        }

        public void Edit(Movie updateMovie)
        {
            Movie origMovie = GetMovieById(updateMovie.Id);
            origMovie.Title = updateMovie.Title;
            origMovie.Genre = updateMovie.Genre;
        }

        public Movie GetMovieById(int id)
        {
            return _movies.Find(m => m.Id == id);
           
        }

        public void Delete(int id)
        {
            Movie deleteMovie = GetMovieById(id);
            _movies.Remove(deleteMovie);
        }

        public List<Movie> ListMovies()
        {
            return _movies;
        }

        public void BuildMovieList()
        {

            if (!listCreated)
            {
                Movie newMovie = new Movie
                {
                    Title = "Raider of the Lost Ark",
                    Genre = "Action/Adventure",
                    Id = nextNum++
                };
                _movies.Add(newMovie);

                newMovie = new Movie
                {
                    Title = "The Big Sick",
                    Genre = "Comedy/Drama",
                    Id = nextNum++
                };

                _movies.Add(newMovie);


                newMovie = new Movie
                {
                    Title = "Planes, Trains and Automobiles",
                    Genre = "Comedy",
                    Id = nextNum++
                };

                _movies.Add(newMovie);
                listCreated = true;
            }
        }
    }
}
