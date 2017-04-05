using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson09
{
     public class Student
        {
            private String unyversity;
            private String name;
            private int age;
            private String response = "what was the question?";
            
            public String GetResponse()
            {
                return response;
            }

            public void SetResponse( string response)
            {
                if (!response.Equals(""))
                {
                    this.response = response;
                }
            }

            public int GetAge()
            {
                return age;
            }

            public void SetAge(int age)
            {
                if (!response.Equals(""))
                {
                    this.age = age;
                }
            }

             public string GetName()
             {
                    return name;
             }
    
             public void SetName(string name)
               {
                  if (!response.Equals(""))
                 {
                      this.name = name;
                 }
               }
    }
    }
