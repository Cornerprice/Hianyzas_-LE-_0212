string[] lines = File.ReadAllLines("szeptember.csv");
Hianyzas[] data = new Hianyzas[lines.Length];
for (int i = 1; i < lines.Length; i++)
{
    data[i] = new Hianyzas(lines[i]);
}

Console.WriteLine($"Rögzített hiányzások száma: {data.Length-1}");

struct Hianyzas
{
    public string Nev;
    public string Osztaly;
    public int ElsoNap;
    public int UtolsoNap;
    public int MulasztottOrak;

    public Hianyzas(string line) 
    {
        var splitted = line.Split(';');
        this.Nev = splitted[0];
        this.Osztaly = splitted[1];
        this.ElsoNap = int.Parse(splitted[2]);
        this.UtolsoNap = int.Parse(splitted[3]);
        this.MulasztottOrak = int.Parse(splitted[4]);
    }
}
