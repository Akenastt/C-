/***************************************************************************
1. Tipos de variáveis var, int, short, long, decimal, double, bool e string;
2. Operadores de atribuição, aritméticos, relacionais, lógicos e unários;
3. Estruturas de decisão if/else, ternárias e switch;
4. Estruturas de repetição while, do/while, for, foreach;
5. Arrays.
***************************************************************************/

// int a = 5;
// int b = 10;

// int c = a + b;
// var d = 33;
// var e = "Algum texto";

// // Arrays = vetores
// Console.WriteLine("Hello, World!");

// Console.WriteLine("Informe a altura: ");
// double alt = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Informe a largura: ");
// double larg = Convert.ToDouble(Console.ReadLine());

//  double area = alt * larg;

// Console.WriteLine("A area é: " + area);

Console.WriteLine("Digite primeiro número: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite segundo número: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2){
    Console.WriteLine("Maior numero: " + num2 + " Menor numero: " + num1);
}
else if(num1 > num2){
    Console.WriteLine("Maior numero: " + num1 + " Menor numero: " + num2);
}
