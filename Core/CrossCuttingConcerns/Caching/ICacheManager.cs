using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    //Farklı caching yöntemlerinin alternatifleri için interface
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key); //Generic olmayan versiyonu böyle de yazılabilir
        void Add(string key, object value, int duration);
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
