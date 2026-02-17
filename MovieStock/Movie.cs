using System;

namespace MovieStock;

public class Movie
{
    public string Title { get; set; }

    public string Artist { get; set; }

    public string Genre { get; set; }

    public int Rating { get; set; }

}

public class MethodsClass
{
    List<Movie> movieList = new List<Movie>();
    Movie movieObj = new Movie();
    public void AddMovie(string movieDetails)
    {
        string[] strings = movieDetails.Split(",");
        movieObj.Title = strings[0];
        movieObj.Artist = strings[1];
        movieObj.Genre = strings[2];
        movieObj.Rating = int.Parse(strings[3]);
        movieList.Add(movieObj);
    }
    public List<Movie>MoviebyGenre(string genre)
    {
        List<Movie> myMovie = new List<Movie>();
        foreach(var item in movieList)
        {
            if(item.Genre == genre)
            {
                myMovie.Add(item);
            }
        }
        return myMovie;
    }
    public List<Movie> MovieByRating()
    {
        return movieList.OrderBy(n=>n.Rating).ToList();

    }
}


