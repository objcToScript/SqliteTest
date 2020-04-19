using System;
using System.Reflection;
using Gdk;

public static class objectExtensions {

    public static object _performSelector_Property(this object obj, string propertyName) {

        Type magicType = obj.GetType();
        PropertyInfo pi = magicType.GetProperty(propertyName,
        BindingFlags.Public | BindingFlags.NonPublic |
        BindingFlags.Instance | BindingFlags.Static |
        BindingFlags.DeclaredOnly);

        MethodInfo getMethod = pi.GetGetMethod();
        object result = getMethod.Invoke(obj, null);

        return result;
    }
}
