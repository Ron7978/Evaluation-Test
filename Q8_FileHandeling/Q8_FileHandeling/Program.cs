using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8_FileHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name = Console.ReadLine();
            string fileName = @"C:\Users\Bhattacharya.Rounak\OneDrive - Entain Group\" + name + ".txt";
            try
            {
                StreamWriter sw = File.AppendText(fileName);

                sw.WriteLine("Now is the winter of our discontent");
                sw.WriteLine("Made glorious summer by this sun of York");
                sw.WriteLine("And all the clouds that lour'd upon our house");
                sw.WriteLine("In the deep bosom of the ocean buried");
                sw.WriteLine("Now are our brows bound with victorious wreaths");
                sw.WriteLine("Our bruised arms hung up for monuments");
                sw.WriteLine("Our stern alarums changed to merry meetings");
                sw.WriteLine("Our dreadful marches to delightful measures");
                sw.WriteLine("Grim-visaged war hath smooth'd his wrinkled front");
                sw.WriteLine("And now, instead of mounting barded steeds");
                sw.WriteLine("To fright the souls of fearful adversaries");
                sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the text you wanna replaced");
            string OldText = Console.ReadLine();


            Console.WriteLine("Enter the text you want in the file");
            string NewText = Console.ReadLine();


            string text = File.ReadAllText(fileName);
            text = text.Replace(OldText, NewText);
            File.WriteAllText(fileName, text);

            Console.ReadLine();

        }
    }
}
