using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(Object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var attributes = property
                                 .GetCustomAttributes()
                                 .Where(t => t.GetType().IsSubclassOf(typeof(MyValidationAttribute)))
                                 .Cast<MyValidationAttribute>()
                                 .ToArray();

                foreach (var item in attributes)
                {
                    bool isValid = item.IsValid(property.GetValue(obj));
                    if (!isValid)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
