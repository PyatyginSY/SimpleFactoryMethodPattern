using System;

namespace SimpleFactoryMethodPattern
{
    class TransformerFactory
    {
        public static ITransformer CreateTransformer(string typeTransformer)
        {
            return (ITransformer)Activator.CreateInstance(Type.GetType("SimpleFactoryMethodPattern." + typeTransformer.ToString()));
        }
    }
}
