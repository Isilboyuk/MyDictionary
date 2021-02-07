using System;

namespace MyDictionaryGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string,string> myDictionary = new MyDictionary<string,string>();
            myDictionary.Add("Product","Ürün");
            myDictionary.Add("Customer", "Müşteri");

            //Console.WriteLine("Hello World!");
        }
    }
}
