using System.IO;
internal class Program
   
{
   
    enum Months
    {
        January = 1,
        Fabuary,
        March,
        April,
        May,
        June,
        Jult,
        August,
        September,
        October,
        November,
        December,
    }

    private static void Main(string[] args)
    {
        int Bdaymonth = (int)Months.March;
        int Bdayday = 9;
        int Bdayyear = 2006;

        string BdayDate = $"My bday si {Bdaymonth}/{Bdayday}/{Bdayyear}";

        File.WriteAllText("notAVirus.txt", "this is a virus\n");
        Console.WriteLine(File.ReadAllText("notAVirus.txt"));

        File.AppendAllText("notAVirus.txt", "why would you add more text this is literally a virus\n");
        Console.WriteLine(File.ReadAllText("notAVirus.txt")); 

        if(!File.Exists("notAVirus.txt"))
        {
            File.Copy("notAVirus.txt", "newVirus.txt");
        }
        else
        {
            File.Replace("newVirus.txt", "notAVirus", "notAVirusBackup");
        }

        File.AppendAllText("newVirus.txt", BdayDate);
        Console.WriteLine(File.ReadAllText("newVirus.txt"));


    }
}