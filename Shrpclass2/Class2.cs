using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shrpclass2.Class2;

namespace Shrpclass2
{
    internal class Class2
    {
        public class Student
        {
            
            public int bdate;
            public string Name { get; }
            public int age;
            private readonly string _city;
            public string status;

            public Student(string name, int age, string city)
            {
                Name = name;
                Age = age;
                _city = city;
            }

            public int Age
            {
                get { return age; }
                set
                {
                    age = value;
                    if (Age < 18) status = "alaealine";
                    else status = "taiskasvanud";
                }
            }

            public int Bdate()
            {
                int nowdate = DateTime.Now.Year;
                bdate = nowdate - Age;
                return bdate; 
            }

            public string Status
            {
                get { return status; }
            }
            public string GetCity()
            {
                return _city;
            }
            public void ShowInfo()
            {
                Console.WriteLine(Name);
                Console.WriteLine(Age);
                Console.WriteLine(status);
                Console.WriteLine(GetCity());
                Console.WriteLine(Bdate());
            }
        }
    }
 }

