// This project created as consolidated material too again.
using System.IO;
string[] Soundtracks = Directory.GetFiles(@"C:\Users\Arlan\Desktop\All Music\Music Now");
foreach (string ToDelete in Soundtracks)
{
    File.Delete(ToDelete);
}
string[] SoundtracksTo = Directory.GetFiles(@"C:\Users\Arlan\Desktop\All Music\Other Music");
foreach (string Track in SoundtracksTo)
{
    Console.WriteLine($"[{Array.IndexOf(SoundtracksTo, Track)}] {Track[45..]}");
}
Console.WriteLine("Enter track indexes, without square brackets, separated by spaces. (For example: 12 6 3)");
string input = Console.ReadLine() ?? "";
string[] parts = input.Split();
int Errors = 0;
foreach (string ID in parts)
{
    try
    {
        if (int.Parse(ID) < SoundtracksTo.Count() && int.Parse(ID) > -1)
        {
            File.Copy(SoundtracksTo[int.Parse(ID)], @$"C:\Users\Arlan\Desktop\All Music\Music Now\{SoundtracksTo[int.Parse(ID)][45..]}");
        }
        else
        {
           Errors += 1; 
        }
    }
    catch (FormatException)
    {
        Errors += 1;
    }
}
Console.WriteLine($"Successfully copied: {parts.Count()-Errors} from: {parts.Count()}");

// 22.08.2026.