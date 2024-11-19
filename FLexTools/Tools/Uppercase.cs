using System.Globalization;

namespace FLexTools.Tools
{
    public class Uppercase
    {
        public string Transform(string text)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            var textTitleCase = myTI.ToTitleCase(text);
            return textTitleCase;
        }
    }
}
