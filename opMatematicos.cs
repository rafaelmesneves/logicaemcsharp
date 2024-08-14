// operadores matemáticos
int nota1 = 10;
int nota2 = 8;

int somaDasNotas = nota1 + nota2;
double mediaDasNotas = somaDasNotas / 2.0; // Divisão por 2.0 para garantir que o resultado seja um double

Console.WriteLine($"Soma das notas = {somaDasNotas}"); // Em C#, utilizamos a interpolação de strings com '$'
Console.WriteLine($"Média das notas = {mediaDasNotas}");

// Resumindo o código
mediaDasNotas = (nota1 + nota2) / 2.0;

int numero = 16;
Console.WriteLine($"Raiz quadrada de 16 = {Math.Sqrt(numero)}"); // 'Math' é uma classe estática em C# com métodos matemáticos predefinidos
