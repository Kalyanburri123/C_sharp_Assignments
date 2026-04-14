using System;
namespace Movie_Project;
class Movie
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int YearOfRelease { get; set; }
    public string Genre { get; set; }

    public void Display()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Year: {YearOfRelease}, Genre: {Genre}");
    }
}