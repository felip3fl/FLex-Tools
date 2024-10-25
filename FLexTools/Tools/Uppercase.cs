namespace FLexTools.Tools
{
    public class Uppercase
    {
        public string Trnasform()
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            var text = getClipboardText().ToLower();
            var textTitleCase = myTI.ToTitleCase(text);
            SetClipboard(textTitleCase);
            Console.WriteLine(textTitleCase);

            return textTitleCase;
        }
    }
}
