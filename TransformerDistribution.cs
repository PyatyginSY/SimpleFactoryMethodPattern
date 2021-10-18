using System;

namespace SimpleFactoryMethodPattern
{
    public class TransformerDistribution : ITransformer
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer distribution");
        }
    }
}
