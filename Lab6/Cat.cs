using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Cat : InterfaceMeowing
    {
        private string name;

        public Cat(string name_cat) 
        {
            name = name_cat;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value ?? throw new ArgumentNullException(nameof(value)); // ошибка если присваеваем null
            }
        }

        public override string ToString()
        {
            return $"Кот: {Name}";
        }

        public void Meow()
        {
            Console.WriteLine($"{Name}: мяу!");
        }

        public void Meowing(int number_of_meows)
        {
            if (number_of_meows < 1)
            {
                Console.WriteLine("Кот не может мяукать 0 раз и меньше");
            }

            string meows = "";

            for (int i = 0; i < (number_of_meows - 1); i++)
            {
                meows = meows + "мяу-";
            }

            meows = meows + "мяу";
            Console.WriteLine($"{Name} :  {meows}");
        }
    }
}