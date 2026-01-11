using System;

namespace ZTUDotNET2025
{
    class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон", "Мідний духовий інструмент", "З’явився у XV столітті") { }
        public Trombone(string desc, string hist) : base("Тромбон", desc, hist) { }
        public Trombone(Trombone other) : base(other) { }

        public override void Sound() => Console.WriteLine("Тромбон звучить гучно");
        public override void Show() => Console.WriteLine($"Інструмент: {name}");
        public override void Desc() => Console.WriteLine($"Опис: {description}");
        public override void History() => Console.WriteLine($"Історія: {history}");
    }
}
