// This project created as consolidated material.
using System.Linq;
List<string> parts = [];
List<string> items = [];
Console.Write("Hello, welcome to Sharp-Lister - updated version of J-Lister remastered on C#.\nAre you wanna play? (Y/N)");
string input = Console.ReadLine() ?? "";
while (input.ToUpper() != "Y" && input.ToUpper() != "N")
{
    Console.WriteLine("I didn't understand. Please, enter again (Y/N).");
    input = Console.ReadLine() ?? "";
}
if (input.ToUpper() == "Y")
{
    Console.WriteLine("Nice, okay, let's start play!\nIf you wanna stop game, press key 'E'.");
    while (true)
    {
        Console.WriteLine("3 actions, add item, delete item and replace item. Enter complex action in format [action][space][item name/item index]");
        string inputTwo = Console.ReadLine() ?? "";
        parts = inputTwo.Split().ToList();
        if (parts.Count != 2)
        {
            if (parts.Count > 0)
            {
                if (parts[0].ToUpper() == "E")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }  
            }
            Console.WriteLine("Invalid format.");
        }
        else
        {
            if (new[] {"add", "delete", "replace" }.Contains(parts[0].ToLower()))
            {
                if (parts[0].ToLower() == "add")
                {
                    items.Add(parts[1]);
                    Console.WriteLine($"Item added.\nUpdated list:\n{string.Join("\n", items)}");
                }
                if (parts[0].ToLower() == "delete" || parts[0].ToLower() == "replace")
                {
                    try
                    {
                        try
                        {
                            int ToDelete = int.Parse(parts[1]);
                            if (parts[0].ToLower() == "delete")
                            {
                                items.RemoveAt(ToDelete);
                                Console.WriteLine($"Item deleted.\nUpdated list:\n{string.Join("\n", items)}");
                            }
                            else
                            {
                                Console.WriteLine("Oah! You selected replace, if you need enter new propertie(new item name).\nPlease enter this propertie there:");
                                string NameTo = Console.ReadLine() ?? "unknown";
                                items[ToDelete] = NameTo;
                                Console.WriteLine($"Item replaced.\nUpdated list:\n{string.Join("\n", items)}");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid number.");
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("Item not found.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid, unknown action.");
            }
        }
    }
}
else
{
    Console.WriteLine("Sad, but okay, i wanna see you later with desire playing, bye!");
}

// 21.08.2026.