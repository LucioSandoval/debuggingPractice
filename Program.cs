// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



// Challenge 1
bool amProgrammer = true;
int Age = 28;
List<string> names = new List<string>();
names.Add("Monica");
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");
// This is a tricky one! Hint: look up what a char is in C#
string myName = "MyName";

// Challenge 2
Console.WriteLine(" Challenge 2 --------");
List<int> numbers = new List<int>() {2,3,6,7,1,5};
for(int i = numbers.Count -1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}
// Challenge 3
 Console.WriteLine(" Challenge 3 --------");
List<int> moreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in moreNumbers)
{
    Console.WriteLine(i);
}
// Challenge 4
Console.WriteLine(" Challenge 4 --------");
List<int> evenMoreNumbers = new List<int> {3,6,9,12,14};
List<int> modifiedNumbers = new List<int>();
foreach(int num in evenMoreNumbers)
{
    if(num % 3 == 0)
    {
        modifiedNumbers.Add(0);
    }else{
        modifiedNumbers.Add(num);
    }
    
}

foreach(int num in modifiedNumbers){
    Console.WriteLine(num);
}
// Challenge 5
Console.WriteLine(" Challenge 5 --------");
// What can we learn from this error message?
// que para cambiar el valor de un texto se debe recorrer el texto o convertirlo en un array
string myString = "superduberawesome";
char[] charArray = myString.ToCharArray();
charArray[7] = 'p';
myString = new string(charArray);
// Challenge 6
Console.WriteLine(" Challenge 6 --------");
// Hint: some bugs don't come with error messages
// rand.Next(12); generará números aleatorios en el rango de 0 a 11, por lo cual nunca ingresa al if 
// la solución seria cambiar la condición en el if a 11 o en el método rand.Next(12); a rand.Next(13);
Random rand = new Random();
int randomNum = rand.Next(13);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}





