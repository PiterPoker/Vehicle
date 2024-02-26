using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle
{
    public static class InstanceService<T>
    {
        public static IEnumerable<T> GetInstances()
        {
            var baseType = typeof(T);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => baseType.IsAssignableFrom(t)
                && !t.IsAbstract
                && (t.GetConstructor(Type.EmptyTypes) != null))
                .Select(t => (T)Activator.CreateInstance(t));
            return types;
        }
    }
}
