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
    /// <summary>
    /// Читатает, если ничего не читает то лови нуль, создат форму нужную, если файл файл пустой то тож нуль
    /// потом письмо, в методе кек я сделал то, как должен выглядеть заполняющий алгоритм
    /// читаешь, если файл пустой то закидываем просто туда наш элемент, если он полный, то
    /// создадим новый объект, с длинной на 1 больщше, в цикле заполняем его из того, что прочли и в конце
    /// добавляем то, что хотели, потом на сериализацию отправляем, шоб та заполнила
    /// </summary>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Oxml">Не забуь его заполнить</param>
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
        public void SerializeFileWrite(OrganizerXML[] Oxml,string path)
        {
            FileInfo Menu = new FileInfo(path);
            if (File.Exists(path))
                Menu.Delete();
            Menu.Create().Close();





            XmlSerializer formatter = new XmlSerializer(typeof(OrganizerXML[]));
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            formatter.Serialize(fs, Oxml);
            fs.Close();

        }

        public void SerializeOneFileWrite(OrganizerXML oxml)
        {
            FileInfo Menu = new FileInfo(Constants.FileTask_xml);
            if (File.Exists(WinFormsLab.Constants.FileTask_xml))
                Menu.Delete();
            Menu.Create().Close();

            OrganizerXML[] Axml = { oxml };
            XmlSerializer formatter = new XmlSerializer(typeof(OrganizerXML[]));
            FileStream fs = new FileStream(Constants.FileTask_xml, FileMode.OpenOrCreate);
            formatter.Serialize(fs, Axml);
            fs.Close();
        }


        /// <summary>
        /// Крч, он прочтет, если файл пустой то добавит в файл переданный файл
        /// если не один то и проблем не будет особо
        /// </summary>
        /// <param name="Onexml"></param>
        public void SerializeBrainFileWrite(OrganizerXML Onexml)
        {
            OrganizerXML[] read = SerializeFileRead();
            if (read == null)
            {
                SerializeOneFileWrite(Onexml);
            }
            else
            {
                OrganizerXML[] org3 = new OrganizerXML[read.Length + 1];
                for (int i = 0; i < read.Length; i++)
                {
                    org3[i] = read[i];
                }
                org3[read.Length] = Onexml;
                SerializeFileWrite(org3);
            }
        }

    }
    
}
