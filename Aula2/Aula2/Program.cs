//var meuNomePorInferencia = "Lenilson Junior";
//Console.WriteLine(meuNomePorInferencia);


// ganhei = false;
//ganhei = true;

//char letra = 'F';

//letra = 'LL';
//letra = "M";

//string nome = "Junior";
//Console.WriteLine(nome[0]);

//using System.Text;

//Console.WriteLine("Olá, meu nome é Junior. \nEsse programa foi feito no SENAC!");

//var stringBilder = new System.Text.StringBuilder();
//stringBilder.AppendLine("Olá, meu nome é Junior.");
//stringBilder.AppendLine("Esse programa foi feito no SENAC");

//Console.WriteLine(stringBilder.ToString());
//-----------------------------------------------------------
//Console.WriteLine("Olá, qual o seu nome?");
//string meuNome = Console.ReadLine();

//Console.WriteLine($"Olá {meuNome}, muito prazer!");
//Console.WriteLine("Qual a sua idade?");
//int minhaIdade = int.Parse(Console.ReadLine());

//Console.WriteLine($"Que legal! No seu próximo anirversário você terá {minhaIdade + 1} anos!");
//-----------------------------------------------------------------

//using System.Data;

//var data = new DateTime();

//data = DateTime.MinValue;
//data = DateTime.MaxValue;
//data = DateTime.Today;
//data = DateTime.Now;

//Console.WriteLine(data.ToString());

const double pi = 3.14;
const int speedbiz = 100;

int idade = 20;
char primeiraLetradoNome = 'L';
float temp = 5.2F;
bool t = true;

Console.WriteLine("Qual o dia sua data de nascimento?");
int DiaNascimento = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o mês da sua data de nascimento?");
int MesNascimento = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o ano da sua data de nascimento?");
int AnoNascimento = int.Parse(Console.ReadLine());

var data = new DateTime(AnoNascimento,MesNascimento,DiaNascimento);
Console.WriteLine($"Sua data de nascimento é: {data.ToString("dd/MM/yyyy")}, e você têm: {2024 - AnoNascimento} anos");

//Console.WriteLine($"Sua data de nascimento é: {Data}");

