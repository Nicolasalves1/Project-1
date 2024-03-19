//variable declaration and types
string fullName = string.Empty;
int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;

//Prompt user for input
Console.WriteLine("Please enter your name: ");
fullName = Console.ReadLine();

Console.WriteLine("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter your gender(M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are you working(true of false): ");
working = Convert.ToBoolean(Console.ReadLine());

//Print information

Console.WriteLine("Your name is: " + fullName);//Concatenation
Console.WriteLine("Your age is: {0}", age);
Console.WriteLine($"Your salary is: {salary}$");//Interpolation
Console.WriteLine($"Your gender is: {gender}");//Interpolation
Console.WriteLine($"You are employed: {working}");//Interpolation

//Cansole.WriteLine($); syntax error