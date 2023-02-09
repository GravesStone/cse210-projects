/* Author Name : Mark Augustine Estimada 
BYU Idaho 2023
Title: Scripture Memorizer */


using System;

class Program
{
    static void Main(string[] args)
    {
        //Class Declaration
        Reference _ScriptureReference = new Reference("Proverbs", "3", "5-6");
            Scripture Scripture = new Scripture(_ScriptureReference, "Trust in the lord with all thine heart and understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
                ScriptureMemorizer scriptureMemorizer = new ScriptureMemorizer(Scripture);
        //Users Input
        string userInput = " ";

        while (userInput != "Quit" && scriptureMemorizer.hasWordsLeft() == true)
        {
            Console.Clear();
                Console.WriteLine(string.Format("{0} {1}", _ScriptureReference.toString(), scriptureMemorizer.toString()));
                    Console.WriteLine();
                        Console.WriteLine("Please emter to continue or type 'Quit to finish'");
                            Console.WriteLine();
                             Console.WriteLine("PRESS ENTER!!");
                                userInput = Console.ReadLine();
                                    scriptureMemorizer.RemoveChar();
        }
        //End Prompt aa Message After the Memorize End 
        Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", _ScriptureReference.toString(), scriptureMemorizer.toString()));
                Console.WriteLine();
                    Console.WriteLine("Well Done Lad! You did Great! ");
    }
    //Referencee class
    class Reference
    {
        // Private String Variable
        private string _book, _chapter, _verse;
        //Formatting
        public Reference (string book, string chapter, string verse)
        {
            _book = book;
                _chapter  = chapter;
                    _verse = verse;
        }
        //Format in the Reference Class
        public string toString()
        {
            return string.Format("{0} {1}:{2}", _book, _chapter, _verse);
        }
    }
    //Scripture class
    class Scripture
    {
        //Private string 
        private string _scriptureText;
            //Reference Private Re
            private Reference _scriptureReference;
        public Scripture (Reference scriptureReference, string scriptureText)
        {
            _scriptureReference = scriptureReference;
                _scriptureText = scriptureText;
        }
        //Scripture Format
        public string toString()
        {
            return string.Format("{0}", _scriptureText);
        }
    }
    //Scripture Memorizer
    class ScriptureMemorizer
    {
        //Private Varialbes 
        private Scripture _scripture;
            private List<string> _sTextList;
                private int _totalWordsRemoved = 0;
        //Public Scripture Memorizer
        public ScriptureMemorizer(Scripture scripture)
        {
            _scripture = scripture;
                _sTextList = new List<string>();
                    TextList();
        }
        //Private Convert Text 
        private void TextList()
        {
            _sTextList = _scripture.toString().Split(" ").ToList();
        }
        //Remove Characters
        public void RemoveChar()
        {
            //Variables Removing the Characters in the scripture verses
            int numWordsToRemove = 3;
                int wordsRemoved = 0;

            do
            {
                //Random _ Underscore
                int xIndex = new Random().Next(0, _sTextList.Count());
                //Scripture Attribute _sTextList Length
                if (_sTextList[xIndex].Contains('_') == false)
                {
                        //Increment the Underscore if the user push a Enter Button
                            _sTextList[xIndex] = new string('_', _sTextList[xIndex].Length);
                                    //Ever Enter it will blank the scripture
                                        wordsRemoved++;
                                            //Variable all total has been reemove
                                                _totalWordsRemoved++;

                    //Once the user enter it will once cover the 3 letters
                    if  ((_sTextList.Count() - numWordsToRemove) <= _totalWordsRemoved && _totalWordsRemoved < (_sTextList.Count() + 1))
                    {
                        wordsRemoved = 3;
                    }
                }
                //it will  loop the underscore  if the users continue to enter
            } while (wordsRemoved != numWordsToRemove);
        }
        //Public string of the Scripture List
        public string toString()
        {
            return string.Join(" ", _sTextList);
        }
        //Public bool words left the statment was false
        public bool hasWordsLeft()
        {
            //the rValue was false and after the program done it will end the program after the scripture.
            bool rValue = false;

            foreach (string word in _sTextList)
            {
                if (word.Contains("_") == false)
                {
                    rValue = true;
                        break;
                }
            }
            return rValue;
        }
    }
}