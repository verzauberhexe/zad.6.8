using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostopadloscian repdanych = new Prostopadloscian();
            repdanych.długość = 10;
            repdanych.szerokość = 20;
            repdanych.wysokość = 30;
            Console.WriteLine(repdanych.objetosc());
            Prostopadloscian repdanychpt2 = new Prostopadloscian();
            repdanychpt2.długość = 40;
            repdanychpt2.szerokość = 50;
            repdanychpt2.wysokość = 60;
            repdanychpt2.porownywanie(repdanychpt2);
        }
    }

    public class Prostopadloscian
    {
        public float długość { get; set; }
        public float szerokość { get; set; }
        public float wysokość { get; set; }
        public float objetosc()
        {
            return długość * szerokość * wysokość;
        }
        public void porownywanie(Prostopadloscian rep)
        {
            if (this.objetosc() > rep.objetosc())
                Console.WriteLine("Prostopadłościan pierwszy ma większą objętość");
            else if (this.objetosc() < rep.objetosc())
                Console.WriteLine("Prostopadłościan pierwszy ma mniejszą objętość");
            else
                Console.WriteLine("Oba prostopadłościany mają taką samą objętość objętość");
        }
    }
}
