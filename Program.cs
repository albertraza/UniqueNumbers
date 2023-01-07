// To execute the app, run dotnet run "FILEPATH"
using UniqueNumber;

if (args.Length == 0) throw new InvalidOperationException("No file path was provided.");

var filePath = args[0];

var fileContent = File.ReadAllText(filePath);
var numbers = fileContent.Split(Environment.NewLine).Select(str => int.Parse(str));

var numStr = string.Join(',', numbers);
Console.WriteLine($"Input: [{numStr}]");

var uniqueNumbers = Solution.GetUniqueNumbers(numbers);

var outputSrt = string.Join(',', uniqueNumbers);
Console.WriteLine($"Output: [{outputSrt}]");
