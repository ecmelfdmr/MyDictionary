using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary <int, string> musteriler = new MyDictionary<int, string>();
            musteriler.Add(103, "Kayra");
            musteriler.Add(104, "Mehtap");
            musteriler.Add(105, "Serhat");
            
        }
    }
}
