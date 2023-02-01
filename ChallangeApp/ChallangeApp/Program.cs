// liczby całkowite
int myAge = 120;
int newAge = myAge + 5;
Console.WriteLine(newAge);
int myVar = int.MinValue;
uint myVar2 = uint.MaxValue;
long myVar3 = long.MaxValue;
// liczby zmiennoprzecinkowe
float myNumber = float.MaxValue;
double myNumber2 = double.MaxValue;
decimal myNumber3 = decimal.MaxValue;

// zmienne tekstowe 
string name = "Grzegorz";
string surname = "Lach";
string result = name + surname + myAge;
Console.WriteLine(result);
Console.WriteLine(name + surname);
char myVar1 = 'c';
var result2 = name.ToArray();

// zmienne 
bool isActive = true;
isActive = false;
var isValid = 5 > 6;
Console.WriteLine(isValid);

// warunki logiczne if
var number1 = 5;
var number2 = 10;
if (number1 > number2)
{
    Console.WriteLine("Jestem tutaj w linii 33");
}
else
{
    Console.WriteLine("Jestem tutaj w linii 38");
}
var name1 = "Ola";
var age = 30;
if (name1 == "Ola" || age < 50)
{
    Console.WriteLine("Jestem Olą lub mam mniej niż 50 lat ");
}
else
{
    Console.WriteLine(" Jestem kimś innym");
}