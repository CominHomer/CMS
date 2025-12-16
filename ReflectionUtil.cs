using System;
using System.Linq;
using System.Reflection;

public static class ReflectionUtil
{
    public static Type[] Find<T>() 
    {
        Type baseType = typeof(T);
        Assembly assembly = Assembly.GetAssembly(baseType);

        Type[] allTypes = assembly.GetTypes();
        Type[] neededTypes = allTypes.Where(type => type.IsSubclassOf(baseType) && !type.IsAbstract).ToArray();

        return neededTypes;
    }
}