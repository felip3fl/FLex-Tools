using FLexTools.Tools;
using System;
using System.Globalization;

namespace FLexTools
{
    public class FLexTools
    {
        [STAThread]
        static void Main(string[] args)
        {

            string parameters = "uppercase";

            if (validateParameters(args))
            {
                parameters = args.FirstOrDefault().ToUpper();
            }

            if (parameters == "")
            {
                //show menu with all the itens:
                Console.WriteLine("FLexTools - Tools for your day by day");
                Console.WriteLine("Usage: FLexTools [parameter]");
                Console.WriteLine("Parameters:");
                Console.WriteLine("CPF - Generate a new CPF number and copy to clipboard");
                Console.WriteLine("CNPJ - Generate a new CNPJ number and copy to clipboard");
                Console.WriteLine("GUID - Generate a new GUID and copy to clipboard");
                Console.WriteLine("UPPERCASE - Convert the text in clipboard to UPPERCASE and copy to clipboard");
            }

            switch (parameters.ToUpper())
            {
                case "1":
                case "CPF":
                    GenerateCpf();
                    break;
                case "2":
                case "GUID":
                    GenerateGuid();
                    break;
                case "3":
                case "CNPJ":
                    GenerateCNPJ();
                    break;
                case "4":
                case "UPPERCASE": 
                case "UPPER":
                case "UP":
                    TextToTitleCase();
                    break;
                default:
                    break;
            }
        }

        private static bool validateParameters(string[] args)
        {
            if (args.FirstOrDefault() == null)
            {
                return false;
            }

            return true;
        }

        public static void GenerateCpf()
        {
            var cpf = new CPF().Generate();
            SetClipboard(cpf);
            Console.WriteLine(cpf);
        }

        public static void GenerateGuid()
        {
            var guid = new GUID().Generate();
            SetClipboard(guid);
            Console.WriteLine(guid);
        }

        public static void TextToTitleCase()
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

            var text = getClipboardText().ToLower();
            var textTitleCase = myTI.ToTitleCase(text);
            SetClipboard(textTitleCase);
            Console.WriteLine(textTitleCase);
        }

        private static string getClipboardText()
        {
            string returnAudioStream = null;
            if (Clipboard.ContainsText())
            {
                returnAudioStream = Clipboard.GetText();
            }
            return returnAudioStream;
        }

        public static void GenerateCNPJ()
        {
            var cnpj = new CNPJ().Generate();
            SetClipboard(cnpj);
            Console.WriteLine(cnpj);
        }

        private static void SetClipboard(string text)
        {
            Thread thread = new Thread(() => Clipboard.SetText(text));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();
        }

    }


}


