using System;

namespace Odev4_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Giresun", 28);
            myDictionary.Add("İzmir", 35);

            Console.WriteLine(myDictionary.Length);

            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine(myDictionary.keys[i] + " : " + myDictionary.values[i]);
            }


        }

        class MyDictionary <K, V>
        {
            public K[] keys { get; set; }
            public V[] values { get; set; }
            public K[] tempKeys { get; set; }
            public V[] tempValues { get; set; }

            public MyDictionary()
            {
                keys = new K[0];
                values = new V[0];
            }

            public void Add(K key, V value )
            {
                tempKeys = keys;
                tempValues = values;
                keys = new K[keys.Length + 1];
                values = new V[values.Length + 1];
                for (int i = 0; i < tempKeys.Length; i++)
                {
                    keys[i] = tempKeys[i];
                }
                for (int i = 0; i < tempValues.Length; i++)
                {
                    values[i] = tempValues[i];
                }

                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;
                
            }

            public int Length
            {
                get { return keys.Length; }
            }

        }

    }
}
