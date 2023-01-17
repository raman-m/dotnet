using System.Reflection;

var asm = Assembly.GetExecutingAssembly();
var solutionName = asm.GetName().Name.Replace(".", " ");

Console.WriteLine($"Welcome to '{solutionName}' app!");
