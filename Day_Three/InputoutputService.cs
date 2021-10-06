using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_Three
{
    static class IOService
    {
        private static string conn = "C:\\Users\\USER_PC_0381\\source\\sources";
        private static string format = "json";

        public static string Read(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader($"{conn}\\{filename}.{format}", Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }



        public static bool Write(string filename, string data)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{conn}\\{filename}.{format}", append: false, Encoding.UTF8))
                {
                    sw.WriteLine(data);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }



    }
}
