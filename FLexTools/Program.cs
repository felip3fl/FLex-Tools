using FLexTools.Tools;

namespace FLexTools
{
    public class FLexTools
    {
        static void Main(string[] args)
        {
            string parameters = "GUID";

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

    }


}


