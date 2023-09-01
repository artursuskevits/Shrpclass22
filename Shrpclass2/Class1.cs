using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shrpclass2.Class2;

namespace Shrpclass2
{
    internal class Class1
    {
        public class StudentMain
        {
            public static void Main()
            {
                List<Message> messagelist = new List<Message> { };
                //Student task
                //Class2.Student student = new Student("John", 17, "London");
                //student.ShowInfo();

                Message m1 = new Message("Hello", "Boris", DateTime.Now.AddDays(0));
                m1.AddLike();
                m1.ShowMessageInfo();
                messagelist.Add(m1);



                Message m2 = new Message("Privet", "Katya", DateTime.Now.AddMinutes(-1));
                m2.AddLike();
                m2.ShowMessageInfo();
                messagelist.Add(m2);
                m2.Popularitycheck(m1.GetPopularity(), m2.GetPopularity());
                


                Message m3= new Message("Privet", "Zhenja", DateTime.Now.AddMinutes(-3));
                m3.AddLike();
                messagelist.Add(m3);
                m3.GEtPopularityINfo(messagelist);
                Console.ReadLine();

            }
        }
    }
}
