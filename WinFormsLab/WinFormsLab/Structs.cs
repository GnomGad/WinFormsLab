using System.IO;
using System;
using System.Windows.Forms;
public struct StructAutorization
{
    public string Login;
    public string Password;
}
public enum EvenCategoryLab
{
    Memo,
    Meeting,
    Task
}
namespace WinFormsLab
{
    public class Constants
    {
        public static string Name = null;
        public static string FileAutorizarion_dat = @"Authorization.dat";
        public static string FileTask_xml = @"Tasks.xml";
        public const string TxtPathes = "Twix.txt";
        public const string ConstFileTask = @"Tasks.xml";
        public static DateTime FindDate = DateTime.Now;
        public static OrganizerXML[] XML = null;
        private static int i = 0;
        public static void CreateTxtFilePaths()
        {
            if (!File.Exists(TxtPathes))
                File.CreateText(TxtPathes).Close();
        }

        public static void WritePaths( string text )
        {
            if (!File.Exists(TxtPathes))
                return;
            SetI();
            string[] tmp = ReadPaths();
            StreamWriter stw = new StreamWriter(TxtPathes);
            foreach(string i in tmp)
            stw.WriteLine(i);
            stw.WriteLine(text);
            stw.Close();

           
        }
        public static string[] ReadPaths()
        {
            string[] tmp = null;
            if (!File.Exists(TxtPathes))
                return null;
            SetI();
             tmp = new string[i];
            StreamReader str1 = new StreamReader(TxtPathes);
            for (int j = 0; j < i; j++)
                tmp[j] = str1.ReadLine();
            str1.Close();

            return tmp;
        }
        private static void SetI()
        {
            StreamReader str = new StreamReader(TxtPathes);
            i = 0;
            for (i = 0; !str.EndOfStream; i++)
                str.ReadLine();
            str.Close();
        }
    }

}