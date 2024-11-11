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
                
            }

            switch (parameters.ToUpper())
            {
                case "CPF":
                    GenerateCpf();
                    break;
                case "GUID":
                    GenerateGuid();
                    break;
                case "CNPJ":
                    GenerateCNPJ();
                    break;
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


