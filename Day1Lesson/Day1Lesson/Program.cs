// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml;

Console.WriteLine("Hello, World!");

//create a string variable

string myName = "Sara";

//more variables:

string superHeroName = "aot";

Console.WriteLine(superHeroName);


int myAge = 40;

Console.WriteLine(myAge);


decimal myMoney = 100.50m;

Console.WriteLine(myMoney);


double myDouble = 100.50;

Console.WriteLine(myDouble);


bool isRaining = true;

Console.WriteLine(isRaining);


//output

string outputString = $"This thursday, i will be watching {superHeroName}";
Console.WriteLine(outputString);

//Creating and calling a function
void functionType1()
{
    string football_player = "Messi";
    Console.WriteLine(football_player);
}

functionType1();

void functionType2(int goals)
{
    string aaa = $"Massi has {goals} lifetime goals";
    Console.WriteLine (aaa);
}
functionType2(807);

//more than one parameter

void functionType2b(int one, string two, bool three)
{
    string Output2b = $"The values are {one}, {two}, {three}";
    Console.WriteLine(Output2b);
}

int one = 1;
string two = "Yes";
bool three = true;

functionType2b(one, two, three);

//Type Three
//Function takes parameters

int functionThatAddsTwoNumbers(int numberOne, int numberTwo)
{
    int sum = numberOne + numberTwo;
    return sum;
}

int doubleoseven = 007;
int randomAgent = 50;

//function call 

int result = functionThatAddsTwoNumbers(doubleoseven, randomAgent);

string outputOfAgents = $"The sum of {doubleoseven} and {randomAgent} is {result}";
Console.WriteLine(outputOfAgents);

//Type Four

//a function that is NOT taking any parameters
//and returning a value

//function definition
int FunctionThatReturnsRandomNumber()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 100);
    return randomNumber;
}

//function call
//i simply want a random number, between 1 and 100

int randomnumber = FunctionThatReturnsRandomNumber();
string somerandomsentence = $"The random number is {randomnumber} between 1 and 100, no parameters are sent";

//i want a random number betwen 500 and 800
int lowerboundvalue = 500;
int upperboundvalue = 800;
int randomnumber2 = FunctionThatReturnsRandomNumber(500, 800);