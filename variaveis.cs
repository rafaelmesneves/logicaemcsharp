// imprime algo
Console.WriteLine("Hello World!");

// variáveis
string nome = "Rafael"; // string
int idade = 29; // int
string nomeDoProfessor = "Marquinho"; // string, camelCase
double altura = 1.77; // double
bool estudando = true; // booleano verdadeiro
bool naoEstudando = false; // booleano falso

Console.WriteLine("Me chamo " + nome + " e tenho " + idade + " anos");
Console.WriteLine(nome.GetType()); // Em C#, 'GetType()' mostra o tipo da variável
Console.WriteLine($"{idade}, {idade.GetType()}"); // É possível demonstrar mais de uma saída usando interpolação de strings

object semConteudo = null; // Variável sem atribuição de conteúdo ('null')

// É possível declarar mais de uma variável por vez usando a vírgula
string curso = "front-end em React", topico = "javascript basico I";
Console.WriteLine($"{curso}, {topico}");

// Em C#, você pode usar 'var' quando o tipo é inferido, mas é mais comum usar tipos explícitos

int notaDoAluno = 10; // Permite que possa ser modificado o valor declarado
const int mediaDoAluno = 8; // Constante, não permite que o valor declarado mude

notaDoAluno = 9;
// mediaDoAluno = 5; // Não é permitido

Console.WriteLine(notaDoAluno);
Console.WriteLine(mediaDoAluno);

// Entrada de dados do usuário
Console.Write("Qual a sua idade? ");
string idadeInput = Console.ReadLine(); // 'Console.ReadLine()' recebe os dados do usuário como uma string
int idade = int.Parse(idadeInput); // Converte a string recebida para um inteiro

Console.WriteLine($"O usuário tem {idade} anos de idade");
