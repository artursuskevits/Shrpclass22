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
        private string GenerateMessageName(int index)
        {
            return $"Message_{index + 1}";
        }
        public void autmatizate()
        {
            List<Message> messagelist = new List<Message> { };
            Random rnd = new Random();
            int counter = rnd.Next(2, 10);
            for (int i = counter; i < counter+1; i++)
            {
                
                //Message m3 = new Message("Privet", "Zhenja", DateTime.Now.AddMinutes(-3));
                Console.WriteLine("Write your message");
                string messagetext = Console.ReadLine();
                Console.WriteLine("Write your nickname");
                string authorname = Console.ReadLine();
                string nameofmessage = GenerateMessageName(i);

                Message nameofmessage = new Message(messagetext,authorname, DateTime.Now);
                //messagelist.Add();
            }

        }
    }
}
