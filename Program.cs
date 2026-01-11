using System;

namespace ZTUDotNET2025
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrument[] instruments =
            {
                new Violin(),
                new Trombone(),
                new Ukulele(),
                new Cello()
            };

            foreach (var instrument in instruments)
            {
                instrument.ShowInfo();
                instrument.Sound();
                Console.WriteLine(new string('-', 40));
            }

            Console.ReadKey();
        }
    }
}
