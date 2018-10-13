using System;
using System.Configuration;

namespace Factory.RepositoryFactory
{
    public static class GenericFactory
    {
        public static T Get<T>() where T : class
        {
            string resolvedTypeName = ConfigurationManager.AppSettings[typeof(T).ToString()];
            Type resolvedType = Type.GetType(resolvedTypeName);
            object instance = Activator.CreateInstance(resolvedType);
            T result = instance as T;
            return result;


        }
    }
}
