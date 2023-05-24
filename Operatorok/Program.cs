using Operatorok;
using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static List<Kifejezesek> lista = new List<Kifejezesek>();
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("adatok\\kifejezesek.txt");
        sr.ReadLine();
        while (!sr.EndOfStream)
        {
            var mezok = sr.ReadLine().Split(' ');

            Kifejezesek uj = new Kifejezesek(int.Parse(mezok[0]), mezok[1] ,int.Parse(mezok[2]));
        }
        sr.Close();


        //2.
        Console.WriteLine($"2.feladat: Kifejezések száma: {lista.Count()}");

        //3.
        Console.WriteLine($"3.feladat: Kifejezések maradékos osztással: {lista.Where(x=>x.OPerator=="mod").Count()}");

        //4.
        bool van= lista.Any(x => x.ElsoOperandus % 10 == 0 && x.MasodikOperandus % 10 == 0);
        Console.WriteLine($"{ (van==true ? "Van ilyen kifejezés" : "Nincs ilyen kifejezés")}");

        //5.
        Console.WriteLine("5.feladat: Statisztika:");
        Console.WriteLine($"\tmod -> {lista.Count(a => a.OPerator == "mod")} db");
        Console.WriteLine($"\t  / -> {lista.Count(a => a.OPerator == "/")} db");
        Console.WriteLine($"\tdiv -> {lista.Count(a => a.OPerator == "div")} db");
        Console.WriteLine($"\t  - -> {lista.Count(a => a.OPerator == "-")} db");
        Console.WriteLine($"\t  * -> {lista.Count(a => a.OPerator == "*")} db");
        Console.WriteLine($"\t  + -> {lista.Count(a => a.OPerator == "+")} db");

        //6.

        //7.

        //8.
        using (StreamWriter fajl = new StreamWriter("eredmenyek.txt"))
        {
            lista.ForEach(x => fajl.WriteLine(x.ToString()));
        }
        Console.WriteLine("8. feladat: eredmenyek.txt");
        Console.ReadKey();
    }
}