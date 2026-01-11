using System;

namespace ZTUDotNET2025
{
    class Cello : MusicalInstrument
    {
        public Cello() : base("Віолончель", "Великий струнний інструмент", "Використовується з XVI століття") { }
        public Cello(string desc, string hist) : base("Віолончель", desc, hist) { }
        public Cello(Cello other) : base(other) { }

        public override void Sound() => Console.WriteLine("Віолончель звучить глибоко");
        public override void Show() => Console.WriteLine($"Інструмент: {name}");
        public override void Desc() => Console.WriteLine($"Опис: {description}");
        public override void History() => Console.WriteLine($"Історія: {history}");
    }
}
