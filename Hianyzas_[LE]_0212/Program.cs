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
    public List<int> MulasztottOrak;

    public Hianyzas(string line) 
    {
        MulasztottOrak = new List<int>();
        var splitted = line.Split(';');
        this.Nev = splitted[0];
        this.Osztaly = splitted[1];
        this.ElsoNap = int.Parse(splitted[2]);
        this.UtolsoNap = int.Parse(splitted[3]);
        for (int i = 4; i < splitted.Length; i++)
        {
            MulasztottOrak.Add(int.Parse(splitted[i]));
        }
        MulasztottOrak.Sort();
    }

    public int Mulasztasok()
    {
        int sum = 0;
        for (int i = 0; i < MulasztottOrak.Count; i++) 
        {
            sum += MulasztottOrak[i];
        }
        return sum;
    }
}
