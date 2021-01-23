using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryExample
{
    class MyDictionary<Key, Value>
     {
        Key[] keys;
        Value[] values;
        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }
        public void Add(Key key, Value value)
        {
            Key[] tempkeys = keys;
            Value[] tempvalues = values;
            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];
            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public void Print()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " Yaş " + values[i]);
            }
        }

    }
}
