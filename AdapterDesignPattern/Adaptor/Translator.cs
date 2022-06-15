using AdapterDesignPattern.Adaptee;
using AdapterDesignPattern.Target;
using System;
using System.Collections.Generic;

namespace AdapterDesignPattern.Adaptor
{
    public class Translator : ITargetTranslator
    {
        static Dictionary<string, string> EnglishFrenchDictionary = new Dictionary<string, string>();
        static Dictionary<string, string> FrenchEnglishDictionary = new Dictionary<string, string>();

        EnglishSpeaker englishSpeaker = new EnglishSpeaker();
        FrenchSpeaker FrenchSpeaker = new FrenchSpeaker();

        static Translator()
        {
            EnglishFrenchDictionary.Add("how are you?", "comment allez-vous?");
            EnglishFrenchDictionary.Add("I am in USA", "Je suis aux Etats-Unis");
            EnglishFrenchDictionary.Add("I am fine", "Je suis trC(s bien");
            EnglishFrenchDictionary.Add("where are you?", "oC9 C*tes-vous?");

            FrenchEnglishDictionary.Add("Je suis trC(s bien", "I am fine");
            FrenchEnglishDictionary.Add("oC9 C*tes-vous?", "where are you?");
            FrenchEnglishDictionary.Add("comment allez-vous?", "how are you?");
            FrenchEnglishDictionary.Add("Je suis aux Etats-Unis", "I am in USA");

        }

        public string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage)
        {
            if (convertToWhichLanguage.Equals("English", StringComparison.InvariantCultureIgnoreCase))
            {
                string EnglishWords = ConvertToEnglish(words);
                Console.WriteLine("\nPam Converted \"" + words + " \" to \"" + EnglishWords + " and send the question to John");
                string EnglishWordsReply = englishSpeaker.AnswerFortheQuestion(EnglishWords);
                Console.WriteLine("Pam Got reply from John in English : " + "\"" + EnglishWordsReply + "\"");
                string FrenchConverted = ConvertToFrench(EnglishWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + EnglishWordsReply + "\"" + " to " + "\"" + FrenchConverted + "\"" + " and send back to David\n");
                return FrenchConverted;
            }
            else if (convertToWhichLanguage.Equals("French", StringComparison.InvariantCultureIgnoreCase))
            {
                string FrenchWords = ConvertToFrench(words);
                Console.WriteLine("\nPam Converted \"" + words + " \" to \"" + FrenchWords + " and send the question to David");
                string FrenchWordsReply = FrenchSpeaker.AnswerFortheQuestion(FrenchWords);
                Console.WriteLine("Pam Got reply from David in French : " + "\"" + FrenchWordsReply + "\"");
                string EnglishConverted = ConvertToEnglish(FrenchWordsReply);
                Console.WriteLine("Pam Converted " + "\"" + FrenchWordsReply + "\"" + " to " + "\"" + EnglishConverted + "\"" + " and send back to John\n");
                return EnglishConverted;
            }
            else
            {
                return "Sorry Cannot Covert";
            }
        }
        public string ConvertToFrench(string Words)
        {
            return EnglishFrenchDictionary[Words];
        }
        public string ConvertToEnglish(string Words)
        {
            return FrenchEnglishDictionary[Words];
        }
    }
    
}
