using System;

namespace nb.MovieLibrary
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }


        public string getMovieInfo()
        {
            return $"Id: {Id}  Title: {Title}  Genre: {Genre}";

        }
    }
}
