
//Prototype - Defines the function (type, name and parameters)
//Definition - Has the code. It contains the code block
//Function Call - Makes the function
// DRY - Don't Repeat Yourself
// YAGNI - You Aren't Going to Need It


//Void functions - Completes a task and moves along

void printName()
{
    Console.WriteLine("Nícolas");
}

void Addition (int num1, int num2)
{
    Console.WriteLine($"The sum between {num1} and {num2} is {num1 + num2}");   
}
// Value returning functions - Completes a task, returns a result
printName();
Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2); 