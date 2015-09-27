﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Pizza.Framework.Utils
{
    public static class ReflectionExtensions
    {
        public static TAttribute GetAttribute<TAttribute>(this MemberInfo memberInfo)
            where TAttribute : Attribute
        {
            return (TAttribute)memberInfo.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault();
        }

        public static Dictionary<PropertyInfo, TAttribute> GetAllPropertiesWithAttribute<TAttribute>(this Type type)
            where TAttribute : Attribute
        {
            var result = new Dictionary<PropertyInfo, TAttribute>();
            foreach (var propertyInfo in type.GetProperties())
            {
                var attribute = propertyInfo.GetAttribute<TAttribute>();
                if (attribute != null)
                {
                    result.Add(propertyInfo, attribute);
                }
            }

            return result;
        }
    }
}
