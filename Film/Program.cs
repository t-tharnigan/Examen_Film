
using System;

class Program {
    static void Main(string[] args) {
        var MijnFilm = new Film {
            Titel = "Inception",
            Genre = "Sci-fi",
            Duurtijd = 148,
            Leeftijdsgrens = 12
        };

        Console.WriteLine("Film informatie:");
        MijnFilm.ToonInfo();
    }
}

class Film {
    public string? Titel;
    public string? Genre;
    public int Duurtijd;
    public int Leeftijdsgrens;

    public Film() {
    }

    public Film(string? titel, string? genre, int duurtijd, int leeftijdsgrens) {
        Titel = titel;
        Genre = genre;
        Duurtijd = duurtijd;
        Leeftijdsgrens = leeftijdsgrens;
    }

    public void ToonInfo() {
        Console.WriteLine($"De film '{Titel}' is een {Genre} film met een duurtijd van {Duurtijd} minuten. De leeftijdsgrens is {Leeftijdsgrens} jaar.");
    }
}
