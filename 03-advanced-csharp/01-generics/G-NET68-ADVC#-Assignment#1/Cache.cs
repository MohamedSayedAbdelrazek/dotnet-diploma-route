using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET68_ADVC__Assignment_1
{
    internal class Cache<TKey,TValue>
    {

        private List<TKey> keys = new List<TKey>(); 
        private List<TValue> values = new List<TValue>();
        private List<DateTime> expirationTimes = new List<DateTime>();
        public void Add(TKey key, TValue value, int seconds) 
        { 
            keys.Add(key);
            values.Add(value); 
            expirationTimes.Add(DateTime.Now.AddSeconds(seconds));
        }
        public TValue Get(TKey key) {
            for (int i = 0; i < keys.Count; i++) 
            {
                if (keys[i].Equals(key)) 
                {
                    if (DateTime.Now < expirationTimes[i]) 
                        return values[i]; 
                    return default;
                }
            } 
            return default; 
        }
        public void Remove(TKey key)
        { 
            for (int i = 0; i < keys.Count; i++) 
            {
                if (keys[i].Equals(key))
                {
                    keys.RemoveAt(i); 
                    values.RemoveAt(i); 
                    expirationTimes.RemoveAt(i);
                    return; 
                } 
            } 
        }
        public bool Contains(TKey key) {
            for (int i = 0; i < keys.Count; i++) 
            {
                if (keys[i].Equals(key))
                { 
                    if (DateTime.Now < expirationTimes[i]) 
                        return true;
                    return false; 
                }
            } 
            return false;
        }
    }

}
