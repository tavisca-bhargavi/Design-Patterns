﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;

namespace Caching
{
    public class CacheMemoryProvider
    {
        MemoryCache cache = new MemoryCache("CachingProvider");
        public void AddItem(string key, Object value)
        {
            cache.Add(key, value, DateTime.Now.AddSeconds(10));
        }

        public void RemoveItem(string key)
        {
            cache.Remove(key);
        }

        public object GetItem(string key)
        {
            var res = cache[key];
            return res;
        }
    }
}
