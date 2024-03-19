// for loop (Counter Controlled)

  for(int i = 0; i < 5; i++)
{
    Console.WriteLine("I am a loop!");
    Console.WriteLine($"Counter: {i}");
}
Console.WriteLine("\nEnd of the loop!");


// while loop (Condition Controlled - Pre Check)
int count = 0;
int n = 0;
while (n < 5)
{
    Console.WriteLine("Input a number greater than 5");
    count++;
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered the number {n}");
    
}
Console.WriteLine();
Console.WriteLine($"You insired a total of {count} numbers");
Console.WriteLine("End of the loop");



// Do...while loop (Condition Controlled - Post Check)

do
{
    Console.WriteLine("Input a number greater than 5");
    count++;
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered the number {n}");
} while (n < 5);
// Foreach
/*
 * Formulas
for (int i = 0; i < length; i++)
{

}

do
{

} while (true);

while (true)
{

}
*/