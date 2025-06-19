using System;

namespace ClassLibrary1
{
    public class Store  // Базовый магазин
    {
        public string Name { get; set; }      // Название
        public int SalesCount { get; set; }    // Количество продаж
        public double Revenue { get; set; }    // Выручка

        // Конструктор магазина
        public Store(string name, int salesCount, double revenue)
        {
            Name = name;
            SalesCount = salesCount;
            Revenue = revenue;
        }

        // Расчет качества
        public virtual double Quality()
        {
            return SalesCount == 0 ? 0 : Revenue / SalesCount;
        }

        // Информация о магазине
        public virtual string Info()
        {
            return $"{Name}, Продажи: {SalesCount}, Выручка: {Revenue}, Q: {Quality():F2}";
        }
    }
}