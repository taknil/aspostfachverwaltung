using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleFormat
{
    static class CmdSpawn
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        public static void ShowConsoleWindow()
        {
            var handle = GetConsoleWindow();
            if (handle == IntPtr.Zero)
                AllocConsole();
            else
                ShowWindow(handle, SW_SHOW);

            Console.WriteLine("CLI loaded...");
        }

        public static void HideConsoleWindow()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }
    }

    static class ConsoleHead
    {
        public static string stringspace = "\t";
        public static char stringsymbol = '#';
        private static string stringline;
        private static int stringlength = 0;
        private static int stringstartend;

        public static void Header(string[] head, bool space)
        {
            //init

            if (space)
            {
                //Text Länge/Anzahl
                foreach (string line in head)
                {
                    if (stringlength == 0 | stringlength < line.Length)
                        stringlength = line.Length;

                    stringstartend = stringlength + 14;
                }

                Console.Write("\t");
                //start
                for (int i = 0; i < stringstartend; i++)
                {
                    Console.Write(stringsymbol);
                }
                Console.Write("\n");

                //Text Strings + Write
                foreach (string line in head)
                {
                    stringline = stringsymbol + stringspace + line;

                    while (stringstartend - 7 > stringline.Length)
                    {
                        stringline += " ";
                    }


                    Console.WriteLine("\t" + stringline + stringsymbol);
                }

                Console.Write("\t");
                //end
                for (int i = 0; i < stringstartend; i++)
                {
                    Console.Write(stringsymbol);
                }
                Console.Write("\n");
            }
            else
            {
                //Text Länge/Anzahl
                foreach (string line in head)
                {
                    if (stringlength == 0 | stringlength < line.Length)
                        stringlength = line.Length;

                    stringstartend = stringlength + 14;
                }

                //start
                for (int i = 0; i < stringstartend; i++)
                {
                    Console.Write(stringsymbol);
                }
                Console.Write("\n");

                //Text Strings + Write
                foreach (string line in head)
                {
                    stringline = stringsymbol + stringspace + line;

                    while (stringstartend - 7 > stringline.Length)
                    {
                        stringline += " ";
                    }


                    Console.WriteLine(stringline + stringsymbol);
                }

                //end
                for (int i = 0; i < stringstartend; i++)
                {
                    Console.Write(stringsymbol);
                }
                Console.Write("\n");
            }
        }
    }

    class ConsoleText
    {
        public class Werte
        {
            public List<string> texts = new List<string>();
            public List<string> values = new List<string>();
            public List<bool> spaces = new List<bool>();
        }

       public Werte werte = new Werte();
        public void ConsoleList()
        {
            Console.WriteLine();

            werte.texts.Add(string.Empty);
            werte.values.Add(string.Empty);
            werte.spaces.Add(false);
        }

        public void ConsoleList(string text, string value)
        {
            //string stringline = text + ":";
            Console.WriteLine(text + " " + value);

            werte.texts.Add(text);
            werte.values.Add(value);
            werte.spaces.Add(false);
        }

        public void ConsoleList(string text, string value, bool space)
        {
            if (space)
            {
                Console.WriteLine("\t" + text + " " + value);

                werte.texts.Add(text);
                werte.values.Add(value);
                werte.spaces.Add(true);
            }
            else
            {
                Console.WriteLine(text + " " + value);

                werte.texts.Add(text);
                werte.values.Add(value);
                werte.spaces.Add(false);
            }
        }

        private static void ConsoleListRefresh(string text, string value, bool space)
        {
            if (space)
            {
                Console.WriteLine("\t" + text + ":\t" + value);
            }
            else
            {
                Console.WriteLine(text + ":\t" + value);
            }
        }

        public void ConsoleRefresh()
        {
            Console.Clear();


        }
    }
}
