using Contracts;

namespace ClassLibrary
{
    public class TextService: ITextService
    {
        public string ToUpper(string input)
        {
            return input.ToUpper();
        }
        public string Concat(string str1, string str2)
        {
            return str1 + str2;
        } 

    }
}