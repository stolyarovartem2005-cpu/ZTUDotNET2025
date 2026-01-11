using System;

namespace ZTUDotNET2025
{
    abstract class MusicalInstrument
    {
        protected string name;
        protected string description;
        protected string history;

        // Конструктор за замовчуванням
        public MusicalInstrument()
        {
            name = "Невідомий інструмент";
            description = "Опис відсутній";
            history = "Історія відсутня";
        }

        // Конструктор з параметрами
        public MusicalInstrument(string name, string description)
        {
            this.name = name;
            this.description = description;
            this.history = "Історія відсутня";
        }

        // Конструктор з параметрами
        public MusicalInstrument(string name, string description, string history)
        {
            this.name = name;
            this.description = description;
            this.history = history;
        }

        // Конструктор копіювання
        public MusicalInstrument(MusicalInstrument other)
        {
            name = other.name;
            description = other.description;
            history = other.history;
        }

        // Методи доступу
        public void SetName(string name) => this.name = name;
        public string GetName() => name;

        public void SetDescription(string description) => this.description = description;
        public string GetDescription() => description;

        public void SetHistory(string history) => this.history = history;
        public string GetHistory() => history;

        // Абстрактні методи
        public abstract void Sound();
        public abstract void Show();
        public abstract void Desc();
        public abstract void History();

        // Вивід усієї інформації
        public virtual void ShowInfo()
        {
            Show();
            Desc();
            History();
        }
    }
}
