using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpAssignment2
{
    class AttributesAndReflection
    {
        // Multiuse attribute. 
        [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       AllowMultiple = true)  
]
        public class Developer : System.Attribute
        {
            string name;
            public string position;

            public Developer(string name)
            {
                this.name = name;

                // Default value.  
                position = "j.developer";
            }

            public string GetName()
            {
                return name;
            }
        }

        // Class with the custom attribute.  
        [Developer("Md Anayeat Rabbi khan")]
        public class FirstClass
        {
            
        }

        // Class without  attribute.  
        public class SecondClass
        {
             
        }

        // Class with multiple Author attributes.  
        [Developer("masud saheb"), Developer("Tamim Hossain", position ="j. front end developer")]
        public class ThirdClass
        {
            
        }

        class DeveloperAttribute
        {
            static void Test()
            {
                DeveloperInfo(typeof(FirstClass));
                DeveloperInfo(typeof(SecondClass));
                DeveloperInfo(typeof(ThirdClass));
            }

            private static void DeveloperInfo(Type t)
            {
                Console.WriteLine("Developer information for {0}", t);

                // Using reflection.  
                Attribute[] attrs = Attribute.GetCustomAttributes(t);  // Reflection.  

                // Displaying output.  
                foreach (Attribute attr in attrs)
                {
                    if (attr is Developer)
                    {
                        Developer a = (Developer)attr;
                        System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.position);
                    }
                }
            }
        }
    }
}
