using System;

namespace SimpleFactoryMethodPattern
{
    public class TransformerPump : ITransformer
    {
        public void GetVoltage()
        {
            Console.WriteLine("Voltage from transformer pump");
        }
    }
}
