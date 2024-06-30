using FLexTools.Tools;

namespace FLexTools
{
    public class FLexTools
    {
        static void Main(string[] args)
        {
            string parameters = "CPNPJ";

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
                case "CPNPJ":
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
            Console.WriteLine(cpf);
        }

        public static void GenerateGuid()
        {
            var cpf = new GUID().Generate();
            Console.WriteLine(cpf);
        }

        public static void GenerateCNPJ()
        {
            var cnpj = new CNPJ().Generate();
            Console.WriteLine(cnpj);
        }

    }


}


