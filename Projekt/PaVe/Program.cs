using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PaVe.InterfaceLayer.CLI;
using PaVe.InterfaceLayer.GUI;
using PaVe.DataLayer.IMDB;
using PaVe.InterfaceLayer;

namespace PaVe
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        public static bool GrapicInterface = true;
        public static InMeDatabase Database
        {
            get
            {
                return InMeDatabase.Current;
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            //CreateTestData();

            try
            {
                InMeDatabase.RefreshCurrent();
            }
            catch
            {
                MessageBox.Show("Fehlerhafte Datenbank", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (args.Count() > 0)
                GrapicInterface = false;

            if (GrapicInterface)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainGui());
            }
            else
            {
                MainCli cli = new MainCli();
                cli.Start();
            }

            Database.Save();
        }

        public static void CreateTestData()
        {
            string dbFile = InMeDatabase.DatabaseFile;

            if (File.Exists(dbFile))
            {
                string extension = Path.GetExtension(dbFile);
                string pathFile = dbFile.Substring(0, dbFile.IndexOf(extension));
                string backup = string.Join("_", new string[] { pathFile, DateTime.Now.ToString("ddMMyyyyHHmmss") });
                File.Move(dbFile, string.Concat(backup, extension));
            }

            InMeDatabase.RefreshCurrent();

            BackendWrapper.CreatePacket("CurrentUser", "A1");
            System.Threading.Thread.Sleep(1000);
            BackendWrapper.CreatePacket("CurrentUser", "A1");
            System.Threading.Thread.Sleep(1000);
            BackendWrapper.CreatePacket("CurrentUser", "A2");
            System.Threading.Thread.Sleep(1000);
            BackendWrapper.CreatePacket("CurrentUser", "A3");
            System.Threading.Thread.Sleep(1000);
            BackendWrapper.CreatePacket("CurrentUser", "B1");
            System.Threading.Thread.Sleep(1000);
            BackendWrapper.CreatePacket("CurrentUser", "C1");

            Database.Save();
        }
    }
}
