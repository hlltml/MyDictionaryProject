using System;

namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("book", "kitap");
            myDictionary.Add("table", "masa");
            myDictionary.Add("chair", "sandalye");
            myDictionary.List();
            Console.WriteLine("--------------");
            myDictionary.Add("glass", "bardak");
            myDictionary.List();
        }
    }
}
