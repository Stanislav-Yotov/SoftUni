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

        public string AnalyzeAccessModifiers(string className)                                                                     
        {                                                                                                                          
            StringBuilder sb = new StringBuilder();                                                                                
            Type classType = Type.GetType(className);                                                                              
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);             
            foreach (var fieldInfo in fields)                                                                                      
            {                                                                                                                      
                sb.AppendLine($"{fieldInfo.Name} must be private!");                                                               
            }                                                                                                                      
                                                                                                                                   
            MethodInfo[] nonPublics = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);                        
            MethodInfo[] publics = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);                              
            foreach (var methodInfo in nonPublics.Where(m => m.Name.StartsWith("get")))                                            
            {                                                                                                                      
                sb.AppendLine($"{methodInfo.Name} have to be public!");                                                            
            }                                                                                                                      
                                                                                                                                   
            foreach (var methodInfo in publics.Where(m => m.Name.StartsWith("set")))                                               
            {                                                                                                                      
                sb.AppendLine($"{methodInfo.Name} have to be private!");                                                           
            }                                                                                                                      
                                                                                                                                   
            return sb.ToString().TrimEnd();                                                                                        
        }                                                                                                                          



    }
}
