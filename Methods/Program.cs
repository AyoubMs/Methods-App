
using Methods;

//SampleMethods.SayHi();
//WriteLine();
//for (int i = 0; i < 10; i++)
//{
//    SampleMethods.SayHi();
//}

// DRY - Don't Repeat Yourself
// SOLID - SRP - Single Responsibility Principle

//string name = ConsoleMessages.GetUsersName();

//ConsoleMessages.SayHi(name);

//double results = MathShortcuts.Add(5, 3);
//Console.WriteLine($"The result is {results}");

//double[] vals = new double[] { 1, 2, 3, 4, 5 };

//MathShortcuts.AddAll(vals);

//ConsoleMessages.SayGoodBye();

// Discard character (_)
(string firstName, _) = ConsoleMessages.GetFullName();

Console.WriteLine($"First name: {firstName}");
//Console.WriteLine($"Last name: {lastName}");

