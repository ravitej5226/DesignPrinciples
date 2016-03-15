using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manuscript> manuscripts = new List<Manuscript>();

            // Instantiate the formatters
            IFormatter standardFormatter = new StandardFormatter();
            IFormatter backwardsFormatter = new BackwardsFormatter();
            IFormatter fancyFormatter = new FancyFormatter();

            FAQ faq = new FAQ(standardFormatter);
            faq.QuestionAnswers.Add("Question 1", "Hello World");
            faq.QuestionAnswers.Add("Question 2", "May the force be with you");
            faq.QuestionAnswers.Add("Question 3", "Rest in Peace!");
            manuscripts.Add(faq);

            Book book = new Book("New book of patterns", "Raghu", "John Doe", backwardsFormatter);
            manuscripts.Add(book);

            Manuscript paper = new Paper("Design Patterns", "Wiki", "Ravi", "Nothing", fancyFormatter);
            manuscripts.Add(paper);

            foreach (var item in manuscripts)
            {
                item.Print();
            }
        }
    }
}
