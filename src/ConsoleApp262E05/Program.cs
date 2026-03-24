//formula del perimetro es: lado * lado + base L + base C
// L = Base Larga
// C = Base Corta
//Formula del area es: base L + base C * altura / 2

//variables
double lado = 5;
double L = 10;
double C = 6;
double altura = 4;
double perimetro = (lado*lado) + L + C;
double area= (L + C) * altura / 2;

Console.WriteLine($"EL perimetro de un trapecio de {lado}cm en cada lado, con una base larga de {L}cm y una base corta de {C}cm es: {perimetro}cm");
Console.WriteLine($"EL area de un trapecio de {lado}cm en cada lado, con una base larga de {L}cm, una base corta de {C}cm y una altura de {altura}cm es: {area}cm^2");
Console.WriteLine($"el volumen de un trapecio base larga de {L}cm, una base corta de {C}cm y una altura de {altura}cm es: {area * altura}cm^3");
