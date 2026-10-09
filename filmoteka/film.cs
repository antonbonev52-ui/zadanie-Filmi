using System;

// БАЗОВ КЛАС - от него наследяват всички останали
class Film
{
    public string Title;
    public int Year;

    public Film(string title, int year)
    {
        Title = title;
        Year = year;
    }

    // Метод за показване на информация
    public virtual void ShowInfo()
    {
        Console.WriteLine("Филм: " + Title);
        Console.WriteLine("Година: " + Year);
    }

    // Виртуални методи - наследниците могат да ги променят с override
    public virtual void Play()
    {
        Console.WriteLine("Филмът стартира!");
    }

    public virtual string Describe()
    {
        return "Това е филм със заглавие \"" + Title + "\", издаден през " + Year + " г.";
    }
}