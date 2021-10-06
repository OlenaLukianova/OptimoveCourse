using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Day_Three
{
    public class DataService<T> : IRepositore<T> where T : class
    {
        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public T Find(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(string filename, IEnumerable<T> objects)
        {
            return IOService.Write(filename, JsonConvert.SerializeObject(objects));
        }

        public T Update(T obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Update(Func<T, bool> predicate, T obj)
        {
            throw new NotImplementedException();
        }
    }
}
