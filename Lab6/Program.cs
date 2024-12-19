using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Задание 1");
            Cat barsik = new Cat("Барсик");
            barsik.Meow();
            barsik.Meowing(3);
            barsik.Meowing(-2);
            Console.WriteLine();

            //Задание 2
            Console.WriteLine("Задание 2");
            List<InterfaceMeowing> meows = new List<InterfaceMeowing>();

            Cat gusy = new Cat("Гуся");

            meows.Add(new Cat("Гуся"));
            meows.Add(new Cat("Буся"));
            meows.Add(new Cat("Ася"));

            meows.Add(new Kot("Маня"));

            Calling_meow_at_everyone(meows);
            Console.WriteLine();

            //Задание 3
            Console.WriteLine("Задание 3");
            List<InterfaceMeowing> meows2 = new List<InterfaceMeowing>();

            meows2.Add(new Meow_counter(new Cat("Сёма")));
            meows2.Add(new Meow_counter(new Cat("Сеня")));


            Calling_meow_at_everyone(meows2);

            


            foreach (var meow in meows2)
            {
                var meow_counter = (Meow_counter)meow;
                var cat = (Cat)meow_counter.Meowings;
                Console.WriteLine($"{cat.Name} мяукал: {meow_counter.GetMeowCount()} раз.");
            }

            Calling_meow_at_everyone(meows2);
            Calling_meow_at_everyone(meows2);

            foreach (var meow in meows2)
            {
                var meow_counter = (Meow_counter)meow;
                var cat = (Cat)meow_counter.Meowings;
                Console.WriteLine($"{cat.Name} мяукал: {meow_counter.GetMeowCount()} раз.");
            }

            Console.WriteLine();

            //---------------------------------------
            //---------------------------------------

            Fraction fraction1 = new Fraction(1, 3);
            Fraction fraction2 = new Fraction(2, 5);

            Fraction result = new Fraction(1, 1);
            result = fraction1 + fraction2;
            Console.WriteLine($" {fraction1} + {fraction2} = {result}");

            Fraction fraction3 = new Fraction(5,6);

            Console.WriteLine($"{fraction1} + {fraction2} / {fraction3} - 5 = {fraction1 + fraction2 / fraction3 - 5} ");

            Fraction_cache fraction_cache1 = new Fraction_cache(fraction1);
            Fraction_cache fraction_cache2 = new Fraction_cache(fraction2);
            Fraction_cache fraction_cache3 = new Fraction_cache(fraction3);



            Console.WriteLine($"Кешированное значение {fraction_cache1}: {fraction_cache1.GetDecimalValue()}");
            Console.WriteLine($"Кешированное значение {fraction_cache2}: {fraction_cache2.GetDecimalValue()}");
            Console.WriteLine($"Кешированное значение {fraction_cache3}: {fraction_cache3.GetDecimalValue()}");

            // Обновление числителя и отображение новых значений
            fraction_cache1.SetNumerator(7);
            Console.WriteLine($"Обновили {fraction_cache1} Кешированное значение: {fraction_cache1.GetDecimalValue()}");

            // Обновление знаменателя и отображение новых значений
            fraction_cache2.SetDenominator(15);
            Console.WriteLine($"Обновили {fraction_cache2} Кешированное значение: {fraction_cache2.GetDecimalValue()}");


        }

        private static void Calling_meow_at_everyone(List<InterfaceMeowing> meows)
        {
            foreach (var meow in meows)
            {
                meow.Meow();
            }
        }
    }
}