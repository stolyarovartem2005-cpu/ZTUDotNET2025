using System;

namespace ZTUDotNET2025
{
    class Violin : MusicalInstrument
    {
        public Violin() : base("Скрипка", "Струнний смичковий інструмент", "Відома з XVI століття") { }
        public Violin(string desc, string hist) : base("Скрипка", desc, hist) { }
        public Violin(Violin other) : base(other) { }

        public override void Sound() => Console.WriteLine("Скрипка звучить ніжно");
        public override void Show() => Console.WriteLine($"Інструмент: {name}");
        public override void Desc() => Console.WriteLine($"Опис: {description}");
        public override void History() => Console.WriteLine($"Історія: {history}");
    }
}
