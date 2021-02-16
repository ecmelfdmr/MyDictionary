using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary <T , K>
    {
        T[] items;
        T[] tempArray1;
        K[] keys;
        K[] tempArray2;
        
        public MyDictionary() 
        {
            items = new T[2];
            keys = new K[5];
        }

        public void Add(T item , K key) 
        {
            tempArray1 = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                items[i] = tempArray1[i];
            }

            items[items.Length - 1] = item;


            tempArray2 = keys;
            keys = new K[keys.Length + 1];
            for (int i = 0; i < tempArray2.Length; i++)
            {
                keys[i] = tempArray2[i];
            }

            keys[keys.Length - 1] = key;


        }
    }
}
