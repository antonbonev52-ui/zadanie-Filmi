using System;

// Наследяване с преходна връзка: Film -> ActionFilm -> SuperheroFilm
class SuperheroFilm : ActionFilm
{
    public string Hero;

    public SuperheroFilm(string title, int year, int explosions, string hero)
        : base(title, year, explosions)
    {
        Hero = hero;
    }

    public override void ShowInfo()
    {
        base.ShowInfo(); // логиката на ActionFilm
        Console.WriteLine("Супергерой: " + Hero);
    }

    public override void Play()
    {
        Console.WriteLine("Супергеройският филм стартира! " + Hero + " спасява света!");
    }

    public override string Describe()
    {
        return "Епично приключение, в което " + Hero + " се бори срещу злото.";
    }
}