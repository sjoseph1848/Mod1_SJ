using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declaring the Car() Class
//This class has 3 properties: Color, Year, and Mileage
public class Car
{
    //Defining properties
    public string Color { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }
}

namespace Mod1_SJ
{
    class Test
    {
        static void Main()
        {
            //Instantiating an object of Car() Class
            Car Car1 = new Car();
        }
    }
}


