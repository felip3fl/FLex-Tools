#:package TextCopy@6.2.1
using TextCopy;

int totalCpfs = 1;
var arguments = "1";
var cpfs = new List<string>();

if(args.Length > 0)
    arguments = args[0];

if (arguments.Length > 10)
{
    var isValidCpf = checkValidCpf(arguments);
    if (isValidCpf)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{arguments} is a valid CPF");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{arguments} is an invalid CPF");
    }

    Console.ForegroundColor = ConsoleColor.White;

    return;
}

if (byte.TryParse(arguments, out byte parsedLength))
    totalCpfs = parsedLength;

for (int i = 0; i < totalCpfs; i++)
cpfs.Add(GenerateCPF());

var result = string.Join("\n", cpfs);
ClipboardService.SetText(result);
Console.WriteLine(result);

string GenerateCPF()
{
    int soma = 0, resto = 0;
    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
    int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

    Random rnd = new Random();
    string seed = rnd.Next(100000000, 999999999).ToString();

    for (int i = 0; i < 9; i++)
        soma += int.Parse(seed[i].ToString()) * multiplicador1[i];

    resto = soma % 11;
    if (resto < 2)
        resto = 0;
    else
        resto = 11 - resto;

    seed = seed + resto;
    soma = 0;

    for (int i = 0; i < 10; i++)
        soma += int.Parse(seed[i].ToString()) * multiplicador2[i];

    resto = soma % 11;

    if (resto < 2)
        resto = 0;
    else
        resto = 11 - resto;

    seed = seed + resto;
    return seed;
}

bool checkValidCpf(string cpf)
{
    cpf = new string(cpf.Where(char.IsDigit).ToArray());
    
    if (cpf.Length != 11)
        return false;
    
    if (cpf.All(c => c == cpf[0]))
        return false;
    
    int sum = 0;
    for (int i = 0; i < 9; i++)
        sum += (cpf[i] - '0') * (10 - i);
    
    int remainder = sum % 11;
    int firstDigit = remainder < 2 ? 0 : 11 - remainder;
    
    if ((cpf[9] - '0') != firstDigit)
        return false;
    
    sum = 0;
    for (int i = 0; i < 10; i++)
        sum += (cpf[i] - '0') * (11 - i);
    
    remainder = sum % 11;
    int secondDigit = remainder < 2 ? 0 : 11 - remainder;
    
    return (cpf[10] - '0') == secondDigit;
}