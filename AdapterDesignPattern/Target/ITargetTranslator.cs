using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern.Target
{
    public interface ITargetTranslator
    {
        string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
    }
}
