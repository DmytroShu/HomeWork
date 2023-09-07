
namespace _14_Files
{
    public class ErrorFile
    {
        static string RandomTime()
        {
            string data = "";
            Random random = new();

            int randomHour = random.Next(01, 24);
            if (randomHour < 10) { data += "0" + randomHour; }
            else data += randomHour;
            data += ":";
            int randomMin = random.Next(01, 60);
            if (randomMin < 10) { data += "0" + randomMin; }
            else data += randomMin;
            data += ":";
            int randomSek = random.Next(01, 60);
            if (randomSek < 10) { data += "0" + randomSek; }
            else data += randomSek;

            return data;

        }
        static string RandomError()
        {
            Random random = new();
            int val = random.Next(1, 6);
            int val2;
            string error = "";
            if (val == 1)
            {
                val2 = random.Next(1, 4);
                switch (val2)
                {
                    case 1:
                        return " 1.1 - FATAL: Operating system crash - it is impossible to continue work";
                    case 2:
                        return " 1.2 - FATAL: Unable to load an important program module - system failure";
                    case 3:
                        return " 1.3 - FATAL: There is no connection to the database - the required data cannot be loaded";
                }
            }
            else if (val == 2 || val == 3)
            {
                val2 = random.Next(1, 7);
                switch (val2)
                {
                    case 1:
                        return " 2.1 - ERROR: Unable to complete the operation - insufficient resources";
                    case 2:
                        return " 2.2 - ERROR: Configuration error - wrong configuration file";
                    case 3:
                        return " 2.3 - ERROR: Error working with the file system - the file does not exist";
                    case 4:
                        return " 2.4 - ERROR: JSON data parsing error - incorrect JSON object format";
                    case 5:
                        return " 2.5 - ERROR: Unable to save file - insufficient access rights";
                    case 6:
                        return " 2.6 - ERROR: Network error - loss of connection with the server";
                }
            }
            else if (val > 3 && val <= 6)
            {
                val2 = random.Next(1, 6);
                switch (val2)
                {
                    case 1:
                        return " 3.1 - WARNING: Using an outdated API - it is recommended to use a newer version of the API";
                    case 2:
                        return " 3.2 - WARNING: Limited resources - possible memory exhaustion when the operation continues";
                    case 3:
                        return " 3.3 - WARNING: Possible file name conflict - the file name already exists in the system";
                    case 4:
                        return " 3.4 - WARNING: Leakage of resources in the program - may slow down the work";
                    case 5:
                        return " 3.5 - WARNING: Limited bandwidth of the network - possible problems in the operation of applications";
                }
            }
            return error;
        }
        static public void WriteError(string filePath)
        {
            
            string a = "2023";
            string b = "-0";
            string c = "-";
            string ver = " v.1.";
            int day = 1;
            int month = 1;
            int monthDay = 31;
            string str = "";
            Random random = new();

            for (int i = 0; i < 5; i++)
            {
                int ran = random.Next(10, 50);
                for (int j = 0; j <= ran; j++)
                {
                    if (day >= monthDay)
                    {
                        month++;
                        day = 1;
                    }
                    if (month == 2)
                    {
                        monthDay = 28;
                    }
                    if (month == 3 || month == 5)
                    {
                        monthDay = 31;
                    }
                    if (month == 4)
                    {
                        monthDay = 30;
                    }
                    day++;
                    if (day < 10)
                    {
                        str = a + b + month + c + "0" + day + " " + RandomTime() + ver + i + RandomError();
                        using StreamWriter writer = new(filePath, true);
                        writer.WriteLine(str);

                    }
                    else
                    {
                        str = a + b + month + c + day + " " + RandomTime() + ver + i + RandomError();
                        using StreamWriter writer = new(filePath, true);
                        writer.WriteLine(str);
                    }
                }
            }
        }
    }
}
