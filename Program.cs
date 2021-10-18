using System;

namespace SimpleFactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SimpleFactoryMethodPattern");

            ITransformer transformer;

            transformer = TransformerFactory.CreateTransformer("TransformerPower");
            transformer.GetVoltage();
            
            transformer = TransformerFactory.CreateTransformer("TransformerDistribution");
            transformer.GetVoltage();
            
            transformer = TransformerFactory.CreateTransformer("TransformerPump");
            transformer.GetVoltage();

            Console.ReadLine();
        }
    }
}
