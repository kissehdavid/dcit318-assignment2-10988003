// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace interfaces
{


    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable myCar = new Car();
            IMovable myBicycle = new Bicycle();

            myCar.Move(); 
            myBicycle.Move();

        }
        

    }
}