using FLexTools.Tools;
using System;
using System.Globalization;
using TextCopy;

namespace FLexTools
{
    public class FLexTools
    {
        
        static void Main(string[] args)
        {
            string parameters = "";

            if (validateParameters(args))
            {
                parameters = args.FirstOrDefault().ToUpper();
            }

            while (parameters == "")
            {
                Console.WriteLine("Type your option:");
                Console.WriteLine("1 CPF - Generate a new CPF number");
                Console.WriteLine("2 CNPJ - Generate a new CNPJ number");
                Console.WriteLine("3 GUID - Generate a new GUID");
                Console.WriteLine("4 UPPERCASE - Convert the text in clipboard to UPPERCASE");
                
                parameters = Console.ReadLine();
            }

            switch (parameters.ToUpper())
            {
                case "1":
                case "CPF":
                case "CP":
                    GenerateCpf();
                    break;
                case "2":
                case "GUID":
                case "GU":
                    GenerateGuid();
                    break;
                case "3":
                case "CNPJ":
                case "CN":
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
            var text = getClipboardText().ToLower();
            var uppercase = new Uppercase().Transform(text);
            
            SetClipboard(uppercase);
            Console.WriteLine(uppercase);
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


