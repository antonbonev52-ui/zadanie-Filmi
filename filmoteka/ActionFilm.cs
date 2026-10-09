using System;

// Йерархично наследяване: ActionFilm : Film
class ActionFilm : Film
{
    public int Explosions;

    public ActionFilm(string title, int year, int explosions)
        : base(title, year)
    {
        Explosions = explosions;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Екшън филм: " + Title);
        Console.WriteLine("Година: " + Year);
        Console.WriteLine("Брой екшън сцени: " + Explosions);
    }

    public override void Play()
    {
        Console.WriteLine("Екшън филмът стартира!");
    }

    public override string Describe()
    {
        return "Динамичен екшън с " + Explosions + " екшън сцени.";
    }
}