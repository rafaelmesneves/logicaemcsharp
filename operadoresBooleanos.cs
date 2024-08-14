// operador booleano (verdadeiro ou falso) são baseados em comparação

int numero1 = 10;
int numero2 = 12;

Console.WriteLine(numero1 == numero2); // '==' significa igualdade
// Em C#, '==' já verifica igualdade tanto de valor quanto de tipo, similar ao '===' no JavaScript

Console.WriteLine(numero1 != numero2); // '!=' significa diferente, similar ao '!=='

Console.WriteLine(numero1 > numero2); // maior que
Console.WriteLine(numero1 < numero2); // menor que
Console.WriteLine(numero1 >= numero2); // maior ou igual
Console.WriteLine(numero1 <= numero2); // menor ou igual

// Conjunções lógicas
int idadePessoa1 = 20;
int idadePessoa2 = 39;

Console.WriteLine(idadePessoa1 >= 18 && idadePessoa2 >= 18); // '&&' significa "e"
Console.WriteLine(idadePessoa1 >= 18 || idadePessoa2 >= 18); // '||' significa "ou"

// operador de inversão
Console.WriteLine(!true); // uso de '!' a frente do booleano inverte o seu valor
