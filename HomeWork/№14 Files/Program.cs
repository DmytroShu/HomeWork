using System.Text.RegularExpressions;

namespace _14_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\dimos\\OneDrive\\Рабочий стол\\LogFile.txt";
            ErrorFile.WriteError(filePath);
            ReadFile(filePath);
        }

        static void Statistic(List<string> list, int counter)
        {
            string filePath = "C:\\Users\\dimos\\OneDrive\\Рабочий стол\\LogFileInfo.txt";
            List<string> lines = new()
            {
                "FATAL: Operating system crash - it is impossible to continue work",
                "FATAL: Unable to load an important program module - system failure",
                "FATAL: There is no connection to the database - the required data cannot be loaded",
                "ERROR: Unable to complete the operation - insufficient resources",
                "ERROR: Configuration error - wrong configuration file",
                "ERROR: Error working with the file system - the file does not exist",
                "ERROR: JSON data parsing error - incorrect JSON object format",
                "ERROR: Unable to save file - insufficient access rights",
                "ERROR: Network error - loss of connection with the server"
            };
            List<int> count = new() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            string[] args;
            for (int i = 0; i < list.Count; i++)
            {
                string log = "";
                args = Regex.Split(list[i], @"([ ])");
                switch (args[2])
                {
                    case "1.1":
                        count[0]++;
                        break;
                    case "1.2":
                        count[1]++;
                        break;
                    case "1.3":
                        count[2]++;
                        break;
                    case "2.1":
                        count[3]++;
                        break;
                    case "2.2":
                        count[4]++;
                        break;
                    case "2.3":
                        count[5]++;
                        break;
                    case "2.4":
                        count[6]++;
                        break;
                    case "2.5":
                        count[7]++;
                        break;
                    case "2.6":
                        count[8]++;
                        break;
                }
            }
            List<VersLog> errorItems = count.Select((c, index) => new VersLog { code = c, log = lines[index] }).ToList();
            errorItems.OrderBy(item => item.code).ToList();
            using StreamWriter writer = new(filePath, true);

            foreach (var item in errorItems)
            {
                writer.WriteLine($"Count error: {item.code}, Error: {item.log}");
            }
            writer.WriteLine($"Total messages: {counter}");
        }
        static void ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new(filePath))
                {
                    int counter = 0;
                    List<string> lines = new();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        counter++;
                        lines.Add(ReadLog(line));
                    }
                    Statistic(lines, counter);
                }
            }
            else
            {
                Console.WriteLine("The file does not exist");
            }
        }
        static string ReadLog(string log)
        {
            string error = "";
            string[] args = Regex.Split(log, @"([ ])");
            for (int i = 4; i < args.Length; i++)
            {
                error += args[i];
            }
            return error;
        }
    }
}