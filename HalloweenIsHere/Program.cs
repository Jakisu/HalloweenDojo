using HalloweenIsHere;

Validator validator = new Validator();

string palavra = "Halloween is here";

var maiusculo = validator.MostrarMaísculo(palavra);
var minusculo = validator.MostrarMinusculo(palavra);



Console.WriteLine($"Total de letras {palavra.Count()}");
validator.MostrarVogais(palavra);
validator.MostrarConsoantes(palavra);
Console.WriteLine($"Letras maiúsculas: {maiusculo}");
Console.WriteLine($"Letras minusculas: {minusculo}");

Console.WriteLine($"Quantidade de palavras: {validator.MostrarPalavras(palavra)}");

