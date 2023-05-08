using Geekbrains.IT.Final;

void Run() {
    Console.Write("Enter comma-separated list of elements and press enter: ");
    var inputStr = Console.ReadLine();
    while (inputStr == null || inputStr.Length == 0) {
        Console.Write("Try again: ");
        inputStr = Console.ReadLine();
    }
    string[] input = inputStr.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);

    var filter = new ArrayFilter();
    string[] output = filter.ByLength(input, 3);

    Console.WriteLine();
    Console.WriteLine(FormatResult(input, output));
}

string FormatArray(string[] input) =>
    $"[{String.Join(", ", Array.ConvertAll(input, elem => $"\"{elem}\""))}]";

string FormatResult(string[] input, string[] output) =>
    $"{FormatArray(input)} -> {FormatArray(output)}";

Run();
