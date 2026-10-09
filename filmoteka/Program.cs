using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        List<Film> films = new List<Film>();

        films.Add(new Film("Интерстелар", 2014));
        films.Add(new ActionFilm("Мисията невъзможна", 2023, 15));
        films.Add(new ComedyFilm("Сам вкъщи", 1990, "Маколи Кълкин"));
        films.Add(new SuperheroFilm("Спайдърмен", 2002, 8, "Спайдърмен"));

        Console.WriteLine("=== КОЛЕКЦИЯ ОТ ФИЛМИ ===\n");

        // Полиморфизъм: всеки обект изпълнява своята версия на методите
        foreach (Film film in films)
        {
            film.ShowInfo();
            Console.WriteLine("Описание: " + film.Describe());
            film.Play();
            Console.WriteLine(new string('-', 40));
        }

        Console.WriteLine("\n=== ПРОВЕРКА НА ТИПОВЕТЕ ===");
        foreach (Film film in films)
        {
            Console.WriteLine(film.Title + " -> " + film.GetType().Name +
                              " | е ActionFilm: " + (film is ActionFilm));
        }
    }
}