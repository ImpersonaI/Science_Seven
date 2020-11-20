using System;

namespace Science_Seven
{
    class Program
    {
        static void Main(string[] args)
        {
            Iteraci iteraci = new Iteraci();
            iteraci.DoIteracii();
            Niton niton = new Niton();
            niton.DoNiton();
            Ditoh ditoh = new Ditoh();
            ditoh.DoDitoh();
            Hord hord = new Hord();
            hord.DoHord();

            Console.ReadKey();
        }
    }
}
