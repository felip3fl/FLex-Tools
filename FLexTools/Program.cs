using FLexTools.Tools;

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

            switch (parameters)
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


