
namespace _11_Calculator_
{
    public static class Calculate
    {
        public static string FindAction(string[] substrings)
        {
            for (int i = 0; i < substrings.Length; i++)
            {

                if (!double.TryParse(substrings[i], out double sub) && substrings[i] == "*" || substrings[i] == "/")
                {
                    double result = Action(substrings[i - 1], substrings[i + 1], substrings[i]);
                    substrings[i + 1] = result.ToString();
                    substrings[i] = "";
                    substrings[i - 1] = "";
                }
            }
            substrings = Array.FindAll(substrings, item => !string.IsNullOrEmpty(item));
            for (int i = 0; i < substrings.Length; i++)
            {
                if (!double.TryParse(substrings[i], out double sub) && substrings[i] == "+" || substrings[i] == "-")
                {
                    string resultate;
                    try
                    {
                        double result = Action(substrings[i - 1], substrings[i + 1], substrings[i]);
                        substrings[i + 1] = result.ToString();
                        substrings[i] = "";
                        substrings[i - 1] = "";
                    }
                    catch (Exception ex)
                    {
                        return resultate = substrings[i] + substrings[i + 1];
                    }


                }
            }
            substrings = Array.FindAll(substrings, item => !string.IsNullOrEmpty(item));
            return substrings[0];
        }
        static double Action(string str1, string str2, string action)
        {
            double.TryParse(str1, out double val1);
            double.TryParse(str2, out double val2);
            switch (action)
            {
                case "*":
                    return val1 * val2;
                case "/":
                    return val1 / val2;
                case "+":
                    return val1 + val2;
                case "-":
                    return val1 - val2;
                default: return 0;
            }
        }
    }
}
