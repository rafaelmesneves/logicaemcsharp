// Coerção de tipos (conversão)

// Coerção explícita (forma manual de conversão)
Console.Write("Qual a sua idade? ");
string idadeInput = Console.ReadLine(); 
int idadeNumber;
bool conversaoBemSucedida = int.TryParse(idadeInput, out idadeNumber); // Tenta converter a entrada para um número inteiro

Console.WriteLine($"{idadeNumber}, {idadeNumber.GetType()}");

int numeroInvalido;
bool conversaoInvalida = int.TryParse("x", out numeroInvalido); // Tenta converter uma string inválida, resultando em false
Console.WriteLine(conversaoInvalida ? numeroInvalido.ToString() : "NaN"); // Exibe "NaN" se a conversão falhar

string numeroComoString = 10.ToString(); // Converte número para string
Console.WriteLine($"{numeroComoString}, {numeroComoString.GetType()}");

bool booleanoDeZero = Convert.ToBoolean(0); // Em C#, 'Convert.ToBoolean(0)' resulta em 'false'
Console.WriteLine(booleanoDeZero);

bool booleanoDeUm = Convert.ToBoolean(1); // Em C#, qualquer número diferente de zero resulta em 'true'
Console.WriteLine(booleanoDeUm);

// Coerção implícita
string resultado1 = 1 + "1"; // Em C#, você precisa converter explicitamente, então não ocorre a coerção automática
Console.WriteLine(resultado1);

int resultado2 = 10 - int.Parse("5"); // A string é convertida para um número explicitamente
Console.WriteLine(resultado2);

// Exemplo

int n = int.Parse("1") + 1; // '11' (string) se torna 2 após a coerção explícita
n = n - 1; // Subtrai 1, resultando em 10
Console.WriteLine(n);

string resultado3 = (2 + 3 + 4).ToString() + "5"; // 9 + "5" = "95"
Console.WriteLine(resultado3);

string resultado4 = "5" + 2 + 3 + 4; // "5234"
Console.WriteLine(resultado4);

string resultado5 = (10 - 4 - 3 - 2).ToString() + "5"; // "15"
Console.WriteLine(resultado5);
