using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleFormat;
using System.Diagnostics;
using PaVe.DataLayer.IMDB;

namespace PaVe.InterfaceLayer.CLI
{
    class MainCli
    {
        public Dictionary<Page, string[]> Index = initIndex();
        public string[] instance { get; private set; }

        public enum Page
        {
            Main = 0,
            
            PacketMenu = 9,
            PacketAdd = 10,
            PacketRemove = 11,
            PacketList = 18,

            PersonMenu = 27,
            PersonAdd = 28,
            PersonRemove = 29,
            PersonList = 36,
        }

        private LinkedList<Page> History = new LinkedList<Page>();

        public MainCli()
        {
            CmdSpawn.ShowConsoleWindow();
        }

        public void Start()
        {
            ConsoleKeyInfo select = new ConsoleKeyInfo();

            History.AddFirst(Page.Main);

            Page current = History.First();
            Load(current);

            string input = string.Empty;
            do
            {
                if (current == Page.PacketList)
                {
                    input = Console.ReadLine();
                    InputMapping(ref current, ref input);
                }
                else
                {
                    select = Console.ReadKey();
                    KeyMapping(select, current);
                    current = History.Last();
                }

                Load(current, input);
            } while (ConsoleKey.Escape != select.Key);

            Console.WriteLine("Close CLI...");
            Console.ReadKey(); // debug
        }

        private void InputMapping(ref Page current, ref string input)
        {
            string tmp = input;
            switch (tmp)
            {
                case "exit":
                case "quit":
                case ":q":
                case "/q":
                    History.RemoveLast();
                    current = History.Last();
                    input = string.Empty;
                    break;
                default:
                    if (PaVe.Program.Database.Pakete.Any(p => string.Equals(p.ID, tmp)))
                        Load(current, tmp);
                    break;

            }
        }

        private void KeyMapping(ConsoleKeyInfo select, Page current)
        {
            Debug.WriteLine("#CLI {0} => {1}", History.Last(), select.Key);
            switch (select.Key)
            {
                case ConsoleKey.NumPad0:
                case ConsoleKey.D0:
                    if (History.Count > 1)
                        History.RemoveLast();
                    break;

                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    if (current == Page.Main)
                        History.AddLast(Page.PacketMenu);

                    //PacketMenu => List/Show
                    else if (current == Page.PacketMenu)
                        History.AddLast(Page.PacketList);

                    //PersonMenu => List/Show
                    else if (current == Page.PersonMenu)
                        History.AddLast(Page.PersonList);
                    break;

                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    if (current == Page.Main)
                        History.AddLast(Page.PersonMenu);

                    //PacketMenu => Add
                    else if (current == Page.PacketMenu)
                        History.AddLast(Page.PacketAdd);

                    //PersonMenu => Add
                    else if (current == Page.PersonMenu)
                        History.AddLast(Page.PersonAdd);
                    break;

                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    //PacketMenu => Remove
                    if (current == Page.PacketMenu)
                        History.AddLast(Page.PacketRemove);

                    //PersonMenu => Remove
                    else if (current == Page.PersonMenu)
                        History.AddLast(Page.PersonRemove);
                    break;

                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:
                case ConsoleKey.NumPad7:
                case ConsoleKey.D7:
                case ConsoleKey.NumPad8:
                case ConsoleKey.D8:
                case ConsoleKey.NumPad9:
                case ConsoleKey.D9:
                    break;

                default:
                    break;
            }
        }

        private void Load(Page pointer)
        {
            Load(pointer, string.Empty);
        }

        private void Load(Page pointer, string input)
        {
            RebuildList(pointer, input);
                
            Refresh();
            Interpreter(Index[pointer]);
        }

        private void RebuildList(Page pointer, string input)
        {
            if (pointer == Page.PacketList)
            {
                //Remove List for Refresh
                if (Index.ContainsKey(pointer))
                    Index.Remove(pointer);

                Index.Add(Page.PacketList, CreateList(input)
                    .Select(p => string.Format("\tPacket ID {0}\r\n\t\tPostfach: {1}\r\n\t\tPerson: {2}", p.ID, p.Panel, p.Person))
                    .ToArray());
            }

            if (pointer == Page.PersonList)
            {
                throw new NotImplementedException();
            }

        }

        private void Refresh()
        {
            Console.Clear();
            Console.WriteLine();
            ConsoleHead.Header(new string[] { "PaVe [CLI]", "Die Paketverwaltung" }, true);
            Console.WriteLine();
        }

        private void Interpreter(List<string> cli)
        {
            Interpreter(cli.ToArray());
        }

        private void Interpreter(string[] cli)
        {
            foreach (string line in cli)
            {
                if(string.IsNullOrEmpty(line))
                    Console.WriteLine();
                else
                    Console.WriteLine(line);
            }
        }

        private IEnumerable<PaVe.DataLayer.Tables.Paket> CreateList(string filter)
        {
            return PaVe.Program.Database.Pakete
                .Where(p =>
                    string.IsNullOrEmpty(filter) ||
                    p.ID.Contains(filter) ||
                    p.ID.Contains(filter) ||
                    p.Panel.ToString().Contains(filter) ||
                    p.Person.ToString().Contains(filter));
        }



        private static Dictionary<Page, string[]> initIndex()
        {
            Dictionary<Page, string[]> index = new Dictionary<Page, string[]>()
            {
                #region Main
                {Page.Main, new string[]
                    {
                        "\t\t[Menu]",
                        "\t1) List Packets",
                        "\t2) List Personen",
                        string.Empty,
                        "\t(ESC Exit)",
                        string.Empty,
                    }
                },
                #endregion Main
                #region PacketMenu
                {Page.PacketMenu, new string[]
                    {
                        "\t\t[List Packets]",
                        "\t1) Show Packets",
                        "\t2) Add Packet",
                        "\t3) Remove Packet",
                        string.Empty,
                        "\t0) Back (ESC Exit)",
                        string.Empty,
                    }
                },
                {Page.PacketAdd, new string[]
                    {
                        "\t\t[PacketAdd]",
                        "\t1) ...",
                        string.Empty,
                        "\t0) Back (ESC Exit)",
                        string.Empty,
                    }
                },
                {Page.PacketRemove, new string[]
                    {
                        "\t\t[PacketRemove]",
                        "\t1) ...",
                        string.Empty,
                        "\t0) Back (ESC Exit)",
                        string.Empty,
                    }
                },
                #endregion PacketMenu
                #region PersonMenu
                {Page.PersonMenu, new string[]
                    {
                        "\t\t[PersonMenu]",
                        "\t1) List Personen",
                        "\t2) Add Person",
                        "\t3) Remove Person",
                        string.Empty,
                        "\t0) Back (ESC Exit)",
                        string.Empty,
                    }
                },
                {Page.PersonAdd, new string[]
                    {
                        "\t\t[PersonAdd]",
                        "\t1) ...",
                        string.Empty,
                        "\t0) Back (ESC Exit)",
                        string.Empty,
                    }
                },
                {Page.PersonRemove, new string[]
                    {
                        "\t\t[PersonRemove]",
                        "\t1) ...",
                        string.Empty,
                        "\t0) Back (ESC Exit)",
                        string.Empty,
                    }
                },
                #endregion PersonMenu
            };
            return index;
        }
    }
}
