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
                    GerarCpf();
                    break;
                case "GUID":
                    GerarGuid();
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

        public static void GerarCpf()
        {
            var cpf = new CPF().GerarCpf();
            Console.WriteLine(cpf);
        }

        public static void GerarGuid()
        {
            var cpf = new GUID().GerateGuid();
            Console.WriteLine(cpf);
        }

    }


}


