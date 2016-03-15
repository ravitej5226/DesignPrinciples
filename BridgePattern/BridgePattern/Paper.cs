using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Paper : Manuscript
    {
        public string Class { get; set; }
        public string Student { get; set; }
        public string Text { get; set; }
        public string References { get; set; }

        public Paper(string className, string student, string text, string references, IFormatter formatter)
            : base(formatter)
        {
            this.Class = className;
            this.Student = student;
            this.Text = text;
            this.References = references;

        }

        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine(formatter.Format("Title", this.Class));
            Console.WriteLine(formatter.Format("Author", this.Student));
            Console.WriteLine(formatter.Format("Text", this.Text));
            Console.WriteLine(formatter.Format("References", this.References));
        }
    }
}
