int num = 11;
int num2 = 12;


Console.WriteLine($"Addition: {num + num2}");
Console.WriteLine($"Subtration: {num - num2}");
Console.WriteLine($"Multiplication: {num * num2}");
Console.WriteLine($"Division: {num / num2}");
Console.WriteLine($"Modulus: {num % num2}");
Console.WriteLine();
num = num + 4;//15

Console.WriteLine($"New Addition: {num + num2}");
Console.WriteLine($"New Subtration: {num - num2}");
Console.WriteLine($"New Multiplication: {num * num2}");
Console.WriteLine($"New Division: {num / num2}");
Console.WriteLine($"New Modulus: {num % num2}");

//Compound Assignment Operators 
num += 4; //num = num + 4: 19
Console.WriteLine(num);
num -= 4; //num = num - 4:  15
Console.WriteLine(num);
num *= 4; //num = num * 4: 15*4 = 60
Console.WriteLine(num);
num /= 4; //num = num / 4: 15
Console.WriteLine(num);
num %= 4; //num = num % 4: 15 mod 4 = 3
Console.WriteLine(num);
