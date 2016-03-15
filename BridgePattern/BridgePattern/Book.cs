using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Book : Manuscript
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public Book(string title, string author, string text, IFormatter formatter) : base(formatter)
        {            
            this.Title = title;
            this.Author = author;
            this.Text = text;
        }

        public override void Print()
        {            
            Console.WriteLine();
            Console.WriteLine(formatter.Format("Title", this.Title));
            Console.WriteLine(formatter.Format("Author", this.Author));
            Console.WriteLine(formatter.Format("Text", this.Text));
        }
    }
}
