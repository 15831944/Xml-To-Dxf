using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using netDxf.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace ParcelsConverter
{
    
    static class main
    {
        public static string Path;
        [STAThread]
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                
                RegistryKey root;
                try
                {
                    root = Registry.ClassesRoot.OpenSubKey("SystemFileAssociations", true);
                }
                catch (System.Security.SecurityException)
                {
                    Console.WriteLine("Недостаточно прав, запустите от имени администратора.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                Console.WriteLine("Для установки приложения нажмите - 1, для удаления - 2");
                char request = Console.ReadKey().KeyChar;
                if (request == '1')
                {
                    root = Registry.ClassesRoot.CreateSubKey(@"SystemFileAssociations\.xml\shell\toDXF\command");
                    root.SetValue("", "\"" + System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + "\" " + "%1");
                    root = Registry.ClassesRoot.OpenSubKey(@"SystemFileAssociations\.xml\shell\toDXF", true);
                    root.SetValue("icon", Directory.GetCurrentDirectory() + "\\icon.ico");
                    root.SetValue("", "to DXF");
                }
                if(request == '2')
                {
                    Registry.ClassesRoot.DeleteSubKeyTree(@"SystemFileAssociations\.xml\shell\toDXF");
                }
            

            }
            else
            {
                Path = args[0];

                switch (Path.Substring(Path.Length - 3))
                {
                    case "xml":
                        MyXmlReader.Start(Path);
                        Win_Prop Win = new Win_Prop();
                        Win.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Неизвестный формат файла!");
                        break;
                }
                /*
                 * switch на будущее
                 */
            }
        }
    }
    
}
