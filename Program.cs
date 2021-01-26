using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> myList = new MyList<int, string>();
            myList.Add(1, "Ayşe");
            myList.Add(2, "Veli");
            myList.Add(3, "Ahmet");
            myList.Add(4, "Mehmet");
            myList.Add(5, "İpek");
            
            Console.WriteLine(myList.Count);

        }
    }

    class MyList<Tkey, Tvalue>
    {
        Tkey[] _key;
        Tvalue[] _value;
        
        public MyList()
        {
            _key = new Tkey[0];
            _value = new Tvalue[0];
        }

        public void Add(Tkey item, Tvalue item1)
        {
            Tkey[] _tempkey = _key;
            Tvalue[] _tempvalue = _value;

            _key = new Tkey[_key.Length + 1];
            _value = new Tvalue[_value.Length + 1];

            for (int i = 0; i < _tempkey.Length; i++)
            {
                _key[i] = _tempkey[i];
            }
            _key[_key.Length - 1] = item;

            for (int j = 0; j < _tempvalue.Length; j++)
            {
                _value[j] = _tempvalue[j];
            }
            _value[_value.Length - 1] = item1;
        }

        public int Count
        {
            get { return _key.Length ; }

        }
    }
}
