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

    }
}