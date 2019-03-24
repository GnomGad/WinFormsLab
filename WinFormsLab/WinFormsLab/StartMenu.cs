using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace WinFormsLab
{
    
    class StartMenu : IStart
    {
        public void CreateAuthorizationBinaryFile(string Path)
        {
            File.CreateText(Path);
        }

        public bool ExistAuthorizationBinaryFile(string Path)
        {
            if (File.Exists(Path))
                return true;
            else
            return false;
        }

        public StructAutorization[] ReadLoginPasswordAuthorizationBinaryFile(string Path)
        {
            StructAutorization[] auto = null;

            BinaryReader BiRead = null;
            try
            {
                BiRead = new BinaryReader(File.Open((Path), FileMode.Open));
                int common =(int) (BiRead.BaseStream.Length / 256);
                auto = new StructAutorization[common];
                for (int it = 0; it < common; it++) 
                {
                    for (int kek = 0; kek < 32; kek++) 
                    {
                        char n = (char)BiRead.ReadInt32();
                        if (n!='0')
                        auto[it].Login += n;
                    }
                   // Console.WriteLine(auto[it].Login);
                    for (int kek = 0; kek < 32; kek++)
                    {
                        char n =(char) BiRead.ReadInt32();
                        if (n != '0')
                            auto[it].Password += n;
                    }
                   // Console.WriteLine(auto[it].Password);

                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("ReadLoginPasswordAuthorizationBinaryFile " + e.Message);
            }
            finally
            {
                BiRead.Close();
               
            }
            return auto;

        }

        public void WriteLoginPasswordAuthorizationBinaryFile(string Path, StructAutorization Autorization)
        {
            if(ExistAuthorizationBinaryFile(Path))
            {
                BinaryWriter BiWrite = null;
                try
                {
                    BiWrite = new BinaryWriter(File.Open(Path, FileMode.Append));

                    foreach (char auto in Autorization.Login)
                    {

                        int k =(auto);
                        BiWrite.Write(k);
                        //   Console.WriteLine((char)(auto + 20));
                    }
                    foreach (char auto in Autorization.Password)
                    {

                        int k = (auto);
                        BiWrite.Write(k);
                        //  Console.WriteLine((char)(auto + 20));
                    }
                    

                }
                catch (Exception e)
                {
                    Console.WriteLine("WriteLoginPasswordAuthorizationBinaryFile "+e.Message);
                }
                finally
                {
                    BiWrite.Close();
                }
            }
            else
                Console.WriteLine("Файла не существует");
        }

        public bool CheckLogin(string Login1, string Login2)
        {
            if (Login1 == Login2)
                return true;
            else
                return false;
        }
        public bool CheckPassword(string Password1, string Password2)
        {
            if (Password1 == Password2)
                return true;
            else
                return false;
        }
        public bool CheckNullInString(string text)
        {
            foreach(char c in text)
            {
                if (c == ' ')
                    return true;
            }
            return false;
        }
    }
   
}
