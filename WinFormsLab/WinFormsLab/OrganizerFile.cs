using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsLab
{
    [Serializable]
    public class OrganizerXML
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public EvenCategoryLab EventCategory { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }

        public OrganizerXML(string n,string s,DateTime d,DateTime t, EvenCategoryLab e)
        {
            
            Date = d;
            Time = t;
            EventCategory = e;
            Text = s;
            Name = n;
        }
        public OrganizerXML()
        {

        }
    }

    public class OrganizerFile
    {
        public void kek()// тестовый стенд
        {
            OrganizerXML orgz = new OrganizerXML("Жопа","Sleep",DateTime.Now, DateTime.Now, EvenCategoryLab.Meeting);
            OrganizerXML orgz1 = new OrganizerXML("Горит","Sleep", DateTime.Now, DateTime.Now, EvenCategoryLab.Meeting);
            OrganizerXML[] org = new OrganizerXML[] { orgz, orgz1 };
            OrganizerXML[] org1 = new OrganizerXML[] { org[0],orgz };
            OrganizerXML[] read = SerializeFileRead();
            if (read == null)
            {
                SerializeFileWrite(org1);
            }
            else
            {
                OrganizerXML[] org3 = new OrganizerXML[read.Length + 1];
                for (int i = 0; i < read.Length; i++)
                {
                    org3[i] = read[i];
                }
                org3[read.Length] = orgz1;
                SerializeFileWrite(org3);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Oxml">Не забуь его заполнить</param>
        public OrganizerXML[] SerializeFileRead()
        {
            bool PainOfRain = true;
            StartMenu Menu = new StartMenu();
            if (!Menu.ExistAuthorizationBinaryFile(WinFormsLab.Constants.FileTask_xml))
            {
                
                    
                Menu.CreateAuthorizationBinaryFile(WinFormsLab.Constants.FileTask_xml);
                PainOfRain = false;

            }
            FileInfo fl = new FileInfo(Constants.FileTask_xml);
            
            if (!PainOfRain || fl.Length==0)
                return null;

            XmlSerializer formatter = new XmlSerializer(typeof(OrganizerXML[]));
            using (FileStream fs1 = new FileStream(Constants.FileTask_xml, FileMode.Open))
            {
                OrganizerXML[] newXML = (OrganizerXML[])formatter.Deserialize(fs1);
                Console.WriteLine("Объект десериализован");
                return newXML;
            }  
        }
        
        public void SerializeFileWrite(OrganizerXML[] Oxml)
        {
            FileInfo Menu = new FileInfo(Constants.FileTask_xml);
                if (File.Exists(WinFormsLab.Constants.FileTask_xml))
                    Menu.Delete();
            Menu.Create().Close();
            
            



            XmlSerializer formatter = new XmlSerializer(typeof(OrganizerXML[]));
            FileStream fs = new FileStream(Constants.FileTask_xml, FileMode.OpenOrCreate);
            formatter.Serialize(fs, Oxml);
            fs.Close();

        }




    }
    
}
