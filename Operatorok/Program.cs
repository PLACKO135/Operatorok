using Operatorok;

internal class Program
{
    static List<Kifejezesek> lista = new List<Kifejezesek>();
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("adatok\\kifejezesek.txt");
        sr.ReadLine();
        while (!sr.EndOfStream)
        {
            var mezok = sr.ReadLine().Split(';');

            Kifejezesek uj = new Kifejezesek(int.Parse(mezok[0]), mezok[1] ,int.Parse(mezok[2]));
        }
        sr.Close();
    }
}