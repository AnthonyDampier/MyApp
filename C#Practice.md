// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("The current time is " + DateTime.Now);


// String name = "Bob";
// int age = 32;
// int isAge= 34;
// Console.WriteLine($"Hello {name} is your age {age}");
// Console.WriteLine(isAge == 32 ? "yes" : "no");

// Console.WriteLine(5/10);

// if (age == isAge){
//     Console.WriteLine("Equal");
// } else {
//     Console.WriteLine("Not Equal");
// }

Random rnd = new Random();
int num = rnd.Next(3); // return 0, 1 or 2
Console.WriteLine($"Random number {num}");

switch (num){
    case 0:
        Console.WriteLine("Random num is 0");
    break;
    case 1: 
        Console.WriteLine("Random num is 1");
    break;
    case 2: 
        Console.WriteLine("Random num is 2");
    break;
    default:
        Console.WriteLine("Something went wrong");
    break;
}

String[] firstArray = new String[3] {"El1", "El2", "El3"};


Console.WriteLine(firstArray[0]);
Console.WriteLine("For loop:");
for (int i = 0; i<firstArray.Length; i++){
    Console.WriteLine(firstArray[i]);
}

Console.WriteLine("Foreach loop:");
foreach (var item in firstArray)
{   
    Console.WriteLine(item);
}

Console.WriteLine("List:");
List<int> randomNumbers = new List<int>();
// randomNumbers.Add(rnd.Next(10));
for (int i = 0; i <= 10; i++){
    randomNumbers.Add(rnd.Next(10));
} 

randomNumbers.ForEach(num => Console.Write(num + ", "));
Console.WriteLine("");

Console.WriteLine("Classes: ");


/* 
Reverses str and counts "o" in str
*/
string str = "The quick brown fox jumps Over the lazy dog.";
char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);
string new_message = new String(charMessage);

// Counts number of "o" in string
int x = 0;
foreach (char i in charMessage) { if (i == 'o'|| i == 'O') { x++; } }

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");



