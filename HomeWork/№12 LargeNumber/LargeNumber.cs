using System.Text.RegularExpressions;

namespace _12_LargeNumber
{
    public static class LargeNumber
    
    {
        public static string Reed(string str)
        {
            try
            {
                string[] args = Regex.Split(str, @"([+-])");
                int length;
                string val1 = "";
                string val2 = "";
                if (args[0].Length > args[2].Length)
                {
                    length = args[0].Length - args[2].Length;
                    for (int i = length; i >= 1; i--)
                    {
                        val2 += "0";
                    }
                    val1 = args[0].ToString();
                    val2 += args[2].ToString();
                }
                else if (args[0].Length < args[2].Length)
                {
                    length = args[2].Length - args[0].Length;
                    for (int i = length; i >= 1; i--)
                    {
                        val1 += "0";
                    }
                    val1 += args[0].ToString();
                    val2 = args[2].ToString();
                }
                else
                {
                    val1 = args[0].ToString();
                    val2 = args[2].ToString();
                }
                List<int> listVal1 = Convert(val1);
                List<int> listVal2 = Convert(val2);
                return Calculate(listVal1, args[1], listVal2);
            }
            catch (Exception ex)
            {
                return "error - Invalid expression, try again";
            }
            
        }
        public static List<int> Convert(string args)
        { 
            List<int> list = new List<int>();
            for (int i = 0; i <= args.Length - 1; i++) 
            {
                string val = args[i].ToString();
                int.TryParse(val, out int result);
                list.Add(result);
            }
            return list; 
        }
        public static string Calculate(List<int> val1, string dija, List<int> val2)
        {
            try
            {
                string result = "";
                string resultRew = "";
                int plus = 0;
                if (dija == "+")
                {
                    for (int i = val1.Count - 1; i >= 0; i--)
                    {
                        if (val1[i] + val2[i] + plus < 10)
                        {
                            result += (val1[i] + val2[i] + plus);
                            plus = 0;
                        }
                        else
                        {
                            result += (val1[i] + val2[i] + plus - 10);
                            plus = 1;
                        }
                    }
                    for (int i = result.Length - 1; i >= 0; i--)
                    {
                        resultRew += result[i].ToString();
                    }
                    if (plus == 0)
                    {
                        return resultRew;
                    }
                    else
                    {
                        return resultRew = plus + resultRew;
                    }

                }
                else if (dija == "-")
                {
                    for (int i = val1.Count - 1; i >= 0; i--)
                    {
                        if (val1[i] - val2[i] - plus >= 0)
                        {

                            result += (val1[i] - val2[i] - plus);
                            plus = 0;
                        }
                        else
                        {
                            result += (10 + val1[i] - val2[i] - plus);
                            plus = 1;
                        }
                    }
                    if (plus == 0)
                    {
                        for (int i = result.Length - 1; i >= 0; i--)
                        {
                            resultRew += result[i].ToString();
                        }
                        return resultRew;
                    }
                    else
                    {
                        return resultRew = resultRew + "-" + Calculate(val2, dija, val1);
                    }
                }
                else return "error";
            }
            catch {  return "error"; }
        }
    }
}