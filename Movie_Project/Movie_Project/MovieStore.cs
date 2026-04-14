using System;
using System.Collections.Generic;
namespace Movie_Project;
class MovieStore
{
    private List<Movie> movies = new List<Movie>();
    private const int MAX_SIZE = 5;

    public void AddMovie()
    {
        if (movies.Count >= MAX_SIZE)
        {
            Console.WriteLine("Store is full.");
            return;
        }

        Movie m = new Movie();

        Console.Write("Enter Id: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid Id");
            return;
        }
        m.Id = id;

        Console.Write("Enter Name: ");
        m.Name = Console.ReadLine();

        Console.Write("Enter Year: ");
        if (!int.TryParse(Console.ReadLine(), out int year))
        {
            Console.WriteLine("Invalid Year");
            return;
        }
        m.YearOfRelease = year;

        Console.Write("Enter Genre: ");
        m.Genre = Console.ReadLine();

        movies.Add(m);
        Console.WriteLine("Movie added.");
    }
    public void DisplayAll()
    {
        if (movies.Count == 0)
        {
            Console.WriteLine("No movies available.");
            return;
        }

        foreach (var m in movies)
        {
            m.Display();
        }
    }
    public void FindById()
    {
        Console.Write("Enter Id: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid Id");
            return;
        }

        var movie = movies.Find(m => m.Id == id);

        if (movie != null)
            movie.Display();
        else
            Console.WriteLine("Movie not found.");
    }
    public void RemoveById()
    {
        Console.Write("Enter Id: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid Id");
            return;
        }

        var movie = movies.Find(m => m.Id == id);

        if (movie != null)
        {
            movies.Remove(movie);
            Console.WriteLine("Movie removed.");
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }
    }
    public void ClearAll()
    {
        movies.Clear();
        Console.WriteLine("All movies cleared.");
    }
}