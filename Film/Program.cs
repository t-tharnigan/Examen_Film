
using System;

class Program {
    static void Main(string[] args) {
        var MijnFilm = new Film {
            Titel = "Inception",
            Genre = "Sci-fi",
            Duurtijd = 148
        };

        Console.WriteLine("Film informatie:");
        MijnFilm.ToonInfo();
    }
}

class Film {
    public string? Titel;
    public string? Genre;
    public int Duurtijd;

    public void ToonInfo() {
        Console.WriteLine($"Titel: {Titel}, Genre: {Genre}, Duurtijd: {Duurtijd} minuten");
    }
}
