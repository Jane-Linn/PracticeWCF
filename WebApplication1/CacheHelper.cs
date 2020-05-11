using Service1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace WebApplication1
{
    public static class CacheHelper
    {
        private static MemoryCache cache = MemoryCache.Default;
        public static StockInfo[] GetCache(string input)
        {
            if (!cache.Contains(input))
            {
                RefreshCache(input);
            }
            return cache.Get(input) as StockInfo[];
        }

        public static void RefreshCache(string input)
        {

        }
    }
}