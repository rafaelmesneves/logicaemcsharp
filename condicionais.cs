// Controle de fluxo: condicionais
Console.Write("Qual sua idade? ");
int idade = int.Parse(Console.ReadLine()); // Solicita a entrada de dados e já converte a entrada para número

bool maiorIdade = idade >= 18;

// Estrutura condicional: 'if/else' (se/senão)
if (maiorIdade) // ou (idade >= 18)
{
    Console.WriteLine("Maioridade");
}
else
{
    Console.WriteLine("Menoridade");
}

// Teste meu
const int mediaAluno = 5;
Console.Write("Nota 1: ");
int nota1 = int.Parse(Console.ReadLine());
Console.Write("Nota 2: ");
int nota2 = int.Parse(Console.ReadLine());

if ((nota1 + nota2) / 2 >= mediaAluno)
{
    Console.WriteLine("Na média");
}
else
{
    Console.WriteLine("Reprovado");
}

// Segundo teste
const int mediaAluno1 = 7;
Console.Write("Nota 1: ");
int nota01 = int.Parse(Console.ReadLine());
Console.Write("Nota 2: ");
int nota02 = int.Parse(Console.ReadLine());

double media = (nota01 + nota02) / 2.0;

if (media >= mediaAluno1)
{
    Console.WriteLine($"Na média, sua nota foi {media}");
}
else if (media >= 5)
{
    Console.WriteLine($"Recuperação, sua nota foi {media}");
}
else
{
    Console.WriteLine($"Reprovado, sua nota foi {media}");
}

// Switch case = muito útil quando a variável possui valores específicos
string permissoes = "aluno"; // "aluno" || "professor" || "admin"

switch (permissoes)
{
    case "aluno":
        Console.WriteLine("Você só pode visualizar as aulas");
        break;
    case "professor":
        Console.WriteLine("Você pode alterar as aulas e adicionar exercícios");
        break;
    case "admin":
        Console.WriteLine("Você pode fazer o que quiser no sistema");
        break;
    default: // 'default' significa "se não for nenhum caso acima, faça isso"
        Console.WriteLine("Não sei quem é você no sistema");
        break;
}

// Operador ternário
int idadezinha = 7;

Console.WriteLine(idadezinha >= 18 ? "Maioridade" : "Minoridade");

string mensagem = idadezinha >= 18 ? "Maioridade" : "Minoridade"; // Atribui valor à variável com base em uma constatação de valor
Console.WriteLine(mensagem);

// Truthy & Falsy
// Falsy: 0, null, "", NaN
// Truthy: todos os demais

object valor = ""; // Exemplo de falsy
if (string.IsNullOrEmpty(valor as string))
{
    Console.WriteLine("Valor é falsy");
}
else
{
    Console.WriteLine("Valor é truthy");
}
