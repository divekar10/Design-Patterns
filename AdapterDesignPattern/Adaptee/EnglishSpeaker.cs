using AdapterDesignPattern.Adaptor;
using AdapterDesignPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Adaptee
{
    public class EnglishSpeaker : IEnglishSpeaker
    {
        public string AskQuestion(string Words)
        {
            Console.WriteLine("Question Asked by John [English Speaker and Can understand only English] : " + Words);
            ITargetTranslator target = new Translator();
            string replyFromEnglishSpeaker = target.TranslateAndTellToOtherPerson(Words, "French");
            return replyFromEnglishSpeaker;
        }

        public string AnswerFortheQuestion(string Words)
        {
            string reply = null;
            if (Words.Equals("where are you?", StringComparison.InvariantCultureIgnoreCase))
            {
                reply = "I am in USA";
            }
            return reply;
        }
    }
}
