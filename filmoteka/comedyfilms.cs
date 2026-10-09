using System;

// Йерархично наследяване: ComedyFilm : Film
class ComedyFilm : Film
{
    public string MainActor;

    public ComedyFilm(string title, int year, string mainActor)
        : base(title, year)
    {
        MainActor = mainActor;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Комедия: " + Title);
        Console.WriteLine("Година: " + Year);
        Console.WriteLine("Главна роля: " + MainActor);
    }

    public override void Play()
    {
        Console.WriteLine("Комедията стартира. Приятно смеене!");
    }

    public override string Describe()
    {
        return "Забавна комедия с " + MainActor + " в главната роля.";
    }
}