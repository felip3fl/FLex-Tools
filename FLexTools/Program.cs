using DevTools;

namespace FLexTools
{
    class TestClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            var parameters = args.FirstOrDefault().ToUpper();

            switch (parameters)
            {
                case "CPF":
                    GerarCpf();
                    break;
                default:
                    break;
            }
        }

        public static void GerarCpf()
        {
            var cpf = new CPF().GerarCpf();
            Console.WriteLine(cpf);
        }

    }


}


