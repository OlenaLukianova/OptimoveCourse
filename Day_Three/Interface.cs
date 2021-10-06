using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
    public interface IRepositore<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> FindAll(Func<T, bool> predicate);
        T Find(Func<T, bool> predicate);
        T Update(T obj);
        IEnumerable<T> Update(Func<T, bool> predicate, T obj);
        void Delete(T obj);
        bool Save(string filename,
            IEnumerable<T> objects);

    }
}
