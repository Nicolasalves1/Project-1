 Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());
// If statements ( == equivalent, <, >, <= less or equal, >= greater or equal, != not equal ) 
/*if(numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
}

else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("You have the same number of apples and oranges");
}

else
{
    Console.WriteLine("You have more oranges");
}

*/

//Switch Statements

Console.WriteLine("Enter your grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch (grade)
{

    case int n when n >= 0 && n <= 49:
        Console.WriteLine("Your grade is negative, try again next year!");
        break;

    case int n when n >= 50 && n <= 99:
        Console.WriteLine("Your grade is positive! You did very well!");
        break;

    case int n when n == 100:
        Console.WriteLine("Your grade is excellent! You are the best!");
        break;

    default:
        Console.WriteLine("Invalid value!");
        break;

         
}


// Ternary Operator
var message = numberOfApples > numberOfOranges ? "You have more apples" : "You have more oranges";
Console.WriteLine(message);
if  (numberOfApples == numberOfOranges)
{
    Console.WriteLine("The number of oranges and apples are equal");

}