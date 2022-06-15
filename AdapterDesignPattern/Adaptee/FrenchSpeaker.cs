using AdapterDesignPattern.Adaptor;
using AdapterDesignPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Adaptee
{
    public class FrenchSpeaker : IFrenchSpeaker
    {
        public string AnswerFortheQuestion(string Words)
        {
            Console.WriteLine("Question Asked by David [French Speaker and Can understand only French] : " + Words);
            ITargetTranslator target = new Translator();
            string replyFromJohn = target.TranslateAndTellToOtherPerson(Words, "English");
            return replyFromJohn;
        }

        public string AskQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("comment allez-vous?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "Je suis très bien";
            }
            return reply;
        }
    }
}
