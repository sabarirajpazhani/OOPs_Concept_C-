using System;

namespace OOPs_Concept_C
{
    class Bike
    {
        public string BikeNmae = "Yamaha";

        public void Display()
        {
            Console.WriteLine("Bike Name: "+ BikeNmae);
        }
    }
    public class OOPs_Concepts_C
    {
        static void Main(string[] args)
        {
            Bike obj = new Bike();

            Console.WriteLine(obj.BikeNmae);
            obj.Display();
        }
    }
}


//Output

//Yamaha
//Bike Name: Yamaha
