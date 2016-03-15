using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class FAQ : Manuscript
    {
        public Dictionary<String, String> QuestionAnswers { get; set; }

        public FAQ(IFormatter formatter)
            : base(formatter)
        {
            this.QuestionAnswers = new Dictionary<string, string>();
        }

        public override void Print()
        {
            foreach (var item in this.QuestionAnswers)
            {
                Console.WriteLine(formatter.Format(item.Key, item.Value));
            }
        }
    }
}
