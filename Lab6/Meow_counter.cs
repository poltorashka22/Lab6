using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab6
{
    public class Meow_counter : InterfaceMeowing
    {
    private InterfaceMeowing meowing;
    private int meow_counter;

    public Meow_counter(InterfaceMeowing meowings)
    {
            meowing = meowings;
            meow_counter = 0;
    }

    public InterfaceMeowing Meowings
        {
        get
        {
            return meowing;
        }
        set
        {
            meowing = value;
        }
    }

    public void Meow()
    {
        meowing.Meow();
        meow_counter = meow_counter + 1;
    }

    public void Meowing(int number_of_meows)
    {
            meowing.Meowing(number_of_meows);
            meow_counter = meow_counter + number_of_meows;
    }

    public int GetMeowCount()
    {
        return meow_counter;
;
    }

    
}
}
