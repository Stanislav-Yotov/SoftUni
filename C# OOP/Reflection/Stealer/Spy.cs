using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
         public string StealFieldInfo(string className, params string[] fieldNames)
         {

             Type classType = Type.GetType(className);
             FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public |
                 BindingFlags.NonPublic | BindingFlags.Static);
             StringBuilder sb = new StringBuilder();
             Object instanced = Activator.CreateInstance(classType, new object[] { });
             sb.AppendLine($"Class under investigation: {className}");
             foreach (FieldInfo field in fields.Where(f => fieldNames.Contains(f.Name)))
             {
                sb.AppendLine($"{field.Name} = {field.GetValue(instanced)}");
             }

            return sb.ToString().TrimEnd();
         }

       
    }
}
