using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryGenerics
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] key;
        TValue[] values;

        public MyDictionary()
        {
            key = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey keyVal, TValue value)
        {
            //To keep initial values of key and values tempKeys&tempValues created.
            TKey[] tempKeys = key;
            TValue[] tempValues = values;

            key = new TKey[key.Length + 1];
            values = new TValue[values.Length + 1];

            //Assign first values
            for (int i = 0; i < tempKeys.Length; i++)
            {
                key[i] = tempKeys[i];
                values[i] = tempValues[i];

            }
            //Add new values
            key[tempKeys.Length] = keyVal;
            values[tempValues.Length] = value;
        }

    }
}
