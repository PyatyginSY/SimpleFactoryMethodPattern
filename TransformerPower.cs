using System;

namespace SimpleFactoryMethodPattern
{
    public class TransformerPower : ITransformer
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer power");
        }
    }
}
