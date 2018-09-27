using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SharpenedMinecraft.Types
{
    public class IDProvider<IDT, T> : IEnumerable<T> where T : class where IDT : IEquatable<IDT>
    {
        private PropertyInfo IDProperty { get; }
        private List<T> ts = new List<T>();
        int i = 0;
        public IDProvider(Expression<Func<T, IDT>> property)
        {
            var propertyInfo = ((MemberExpression)property.Body).Member as PropertyInfo;
            if (propertyInfo == null)
                throw new ArgumentException("The lambda expression 'property' should point to a valid Property");
            if (propertyInfo.PropertyType != typeof(IDT))
                throw new ArgumentException("Property Type has to be IDT");
            this.IDProperty = propertyInfo;
        }

        public void Add(T t, IDT id)
        {
            //TODO: Rework, it can cause a lot of problems
            //(The Complete Class)
            if (ts.Any(x => ((IDT)IDProperty.GetValue(x)).Equals(id)))
                throw new ArgumentException("Id Is taken");
            IDProperty.SetValue(t, id);
            ts.Add(t);
        }

        public void Add(T t)
        {
            while (ts.Any(x => ((IDT)IDProperty.GetValue(x)).Equals(i)))
                i++;

            IDProperty.SetValue(t, i);
            ts.Add(t);
        }

        public void Remove(T t)
        {
            ts.Remove(t);
        }

        public IEnumerator<T> GetEnumerator()
            => ts.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => ts.GetEnumerator();
    }
}