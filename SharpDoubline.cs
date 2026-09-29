// This project created as consolidated material too.
Console.WriteLine("Here place is SharpDoubline - \"Dualing Line v2\", but remastered on C#, not Python.\nEnter [text] [char index]");
string input = Console.ReadLine() ?? "";
string[] parts = input.Split();
if (parts.Count() < 2)
{
   Console.WriteLine("Invalid format. Bye ha-ha!"); 
}
else
{
    string text = string.Join(" ", parts[..^1]);
    try
    {
        if (int.Parse(parts[^1]) < text.Length && int.Parse(parts[^1]) > -1)
        {
           Console.WriteLine(text[..^(int.Parse(parts[^1]))]+"\n"+text[^(int.Parse(parts[^1]))..]+"\n\nBye ha-ha!"); 
        }
        else
        {
            Console.WriteLine("Char not found. Bye ha-ha!");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid number. Bye ha-ha!");
    }
}

// 21.08.2026 + 22.08.2026.