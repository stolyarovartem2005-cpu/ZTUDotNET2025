using System;

namespace ZTUDotNET2025
{
    class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле", "Малий струнний інструмент", "Походить з Гаваїв") { }
        public Ukulele(string desc, string hist) : base("Укулеле", desc, hist) { }
        public Ukulele(Ukulele other) : base(other) { }

        public override void Sound() => Console.WriteLine("Укулеле звучить дзвінко");
        public override void Show() => Console.WriteLine($"Інструмент: {name}");
        public override void Desc() => Console.WriteLine($"Опис: {description}");
        public override void History() => Console.WriteLine($"Історія: {history}");
    }
}
