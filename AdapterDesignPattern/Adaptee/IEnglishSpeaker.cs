using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Adaptee
{
    public interface IEnglishSpeaker
    {
        string AskQuestion(string Words);
        string AnswerFortheQuestion(string Words);
    }
}
