using System;

namespace ClassLibrary1
{
    public class ChainStore : Store  // Сеть магазинов
    {
        public int Customers { get; set; }  // Количество покупателей
        public string Region { get; set; }   // Регион 

        // Конструктор сети
        public ChainStore(string name, int salesCount, double revenue,
                         int customers, string region)
            : base(name, salesCount, revenue)
        {
            Customers = customers;
            Region = region;
        }

        // Расчет качества
        public override double Quality()
        {
            double baseQ = base.Quality();
            return Customers > 50000 ? 2 * baseQ : 0.5 * baseQ;
        }

        // Информация о сети
        public override string Info()
        {
            return $"{base.Info()}, Покупатели: {Customers}, Регион: {Region}, Qp: {Quality():F2}";
        }
    }
}