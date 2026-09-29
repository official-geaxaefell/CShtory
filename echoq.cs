string[] EchoPrepare(string read)
{
    string[] parts = read.Split("&");
    try
    {
        string text = string.Join("&", parts[..^1]);
        return new[] {text, parts[^1]};
    }
    catch (IndexOutOfRangeException)
    {
        return new[] {"", "-1"};
    }
}
Console.Write("Enter text with quality in format [text]&[quality]:");
string input = Console.ReadLine() ?? "";
try
{
    for (int i = 0; i < int.Parse(EchoPrepare(input)[1]); i++)
    {
       Console.WriteLine(EchoPrepare(input)[0]); 
    }
}
catch (FormatException)
{
    Console.WriteLine("Sorry, but you are an entered quality in invalid format.");
}

// 20.08.2026.