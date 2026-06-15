
using System;

class Program {
    static void Main(string[] args) {
        var MijnFilm = new Film("Inception", "Sci-fi", 148, 12);

        Console.WriteLine("Film informatie:");
        MijnFilm.ToonInfo();
    }
}

class Film {
    public string? Titel;
    public string? Genre;
    public int Duurtijd;
    public int Leeftijdsgrens;

    public Film(string? titel, string? genre, int duurtijd, int leeftijdsgrens) {
        Titel = titel;
        Genre = genre;
        Duurtijd = duurtijd;
        Leeftijdsgrens = leeftijdsgrens;
    }

    public void ToonInfo() {
        Console.WriteLine($"Titel: {Titel}, Genre: {Genre}, Duurtijd: {Duurtijd} minuten");
    }
}
