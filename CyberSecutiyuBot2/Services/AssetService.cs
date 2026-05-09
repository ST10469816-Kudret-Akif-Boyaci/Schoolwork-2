using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecutiyuBot2.Services
{

    //acts as an interface between backend files (logo.txt, etc)
    // in the services - define the operations in terms of methods
    public class AssetService
    {
        private string logoPath;

        public AssetService()


        {
            logoPath = Path.Combine(AppContext.BaseDirectory, "Assets", "logo.txt");
        }

        //load the ASCII logo from file

        public string loadlogo()
        {
            //exception handling if the file is not found
            try
            {
                if (File.Exists(logoPath))
                {
                    string logo = File.ReadAllText(logoPath);
                    return logo;
                }
                else
                {
                    return "logo file not found in assets folder";

                }
            }
            catch (Exception ex)
            {
                return $"error loading logo: {ex.Message}";
            }
        }

        //dispay logo
        public void displaylogo()
        {
            string logo = loadlogo();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(logo);
            Console.ResetColor();
        }

        //display a decorative border
        public void Displayborder()
        {
            Console.WriteLine(new string('=', 60));
        }

        //display the logo on the welcome screen
        public void showwelcomescreen()
        {
            Console.Clear();

            Displayborder();
            displaylogo();
            Displayborder();

            Console.WriteLine("cybersecurity awarenes bot");
            Console.WriteLine("helping you stay safe online");
            Console.WriteLine();


        }
    }
}
