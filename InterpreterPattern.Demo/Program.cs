
using InterpreterPattern.Demo;

Console.WriteLine("Provide a word with expression");
var word = Console.ReadLine();

var value = word.Substring(0, word.IndexOf("-"));
var expressions = word.Substring(word.IndexOf("-"));

var interpreter = new Interpreter();
interpreter.Interpret(new Context(expressions, value));