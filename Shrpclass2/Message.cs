using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Shrpclass2
{
    public class Message
    {
        List<string> messagelist = new List<string> { "Wassup", "Poka", "I wanna die", "GAGAGAgA","OGO","(", "lalalalala","Vlad" };
        private readonly string _content;
        private readonly string _author;
        private readonly DateTime _time;
        private int _likes;

        public Message(string content, string author, DateTime time)
        {
            this._content = content;
            this._author = author;
            this._time = time;
        }

        public int Likes { get => _likes; }
        public DateTime Time { get => _time; }
        public string Author { get => _author; }
        public string Content { get => _content; }

        public void AddLike()
        {
            _likes++;
        }

        public double GetPopularity()
        {
            double elapsed = DateTime.Now.Subtract(this._time).TotalSeconds;
            if (elapsed == 0)
            {
                return _likes;
            }
            return _likes / elapsed;

        }

        public void ShowMessageInfo()
        {
            Console.WriteLine();
            Console.WriteLine("text = " + Content);
            Console.WriteLine("time = " + Time);
            Console.WriteLine("lieks = " + Likes);
            Console.WriteLine("hype = " + GetPopularity());
        }

        public void Popularitycheck(double esimine, double teine)
        {
            double checknum = esimine - teine;
            if (checknum > 0)
            {
                Console.WriteLine("m1 is more poppular");
            }
            else if (checknum < 0)
            {
                Console.WriteLine("m2 is more poppular");
            }
            else
            {
                Console.WriteLine("m1 and m2 same by popularity");
            }
            return;
        }

        public void GEtPopularityINfo(List<Message> messages)
        {
            Message mostpopularmessage= new Message("Privet", "Zhenja", DateTime.Now.AddMinutes(-3));
            double hypecounter= 0;
            foreach (Message message in messages)
            {
                if (message.GetPopularity() > hypecounter)
                {
                    hypecounter = message.GetPopularity() ;
                    mostpopularmessage = message;
                }
            }
            Console.WriteLine();
            Console.WriteLine("most popular message is "+ mostpopularmessage.Content + " and his autor is "+ mostpopularmessage.Author);
            
        }
        
        public static void autmatizate()
        {
            List<Message> messagelist = new List<Message> { };

            Random rnd = new Random();
            int like_counter = 0;
            int counter = rnd.Next(2, 10);
            Console.WriteLine("Create {0} messages",counter);
            for (int i = 0; i < counter+1; i++)
            {
                Console.WriteLine("Write {0} message",i+1);
                string messagetext = Console.ReadLine();
                Console.WriteLine("Write your nickname");
                string authorname = Console.ReadLine();
                
                

                Message newmessage = new Message(messagetext,authorname, DateTime.Now);
                like_counter= rnd.Next(0, 50);
                for (int ii = 0; ii < like_counter; ii++)
                {
                    newmessage.AddLike();
                   
                }
                messagelist.Add(newmessage);
                messagelist[i].ShowMessageInfo();
              
                Console.WriteLine();
            }
            messagelist[0].GEtPopularityINfo(messagelist);


        }
    }
}
