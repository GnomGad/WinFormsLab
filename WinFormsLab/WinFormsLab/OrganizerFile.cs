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

        public OrganizerXML(string s,DateTime d,DateTime t, EvenCategoryLab e)
        {
            
            Date = d;
            Time = t;
            EventCategory = e;
            Text = s;
        }
        public OrganizerXML()
        {

        }
    }

    public class OrganizerFile
    {
        public void kek()// тестовый стенд
        {
            OrganizerXML orgz = new OrganizerXML("Sleep",DateTime.Now, DateTime.Now, EvenCategoryLab.Meeting);
            OrganizerXML orgz1 = new OrganizerXML("Sleep", DateTime.Now, DateTime.Now, EvenCategoryLab.Meeting);
            OrganizerXML[] org = new OrganizerXML[] { orgz, orgz1 };
            XmlSerializer formatter = new XmlSerializer(typeof(OrganizerXML[]));

            FileStream fs = new FileStream(Constants.FileTask_xml, FileMode.OpenOrCreate);
            formatter.Serialize(fs, org);
            fs.Close();

            using (FileStream fs1 = new FileStream(Constants.FileTask_xml, FileMode.OpenOrCreate))
            {
                OrganizerXML[] newPerson1 = (OrganizerXML[])formatter.Deserialize(fs1);

                Console.WriteLine("Объект десериализован");
                foreach(OrganizerXML newPerson in newPerson1)
                Console.WriteLine("Дата: {0} --- время: {1} -------- категория {2}   --{3}--\r\n", newPerson.Date, newPerson.Time,newPerson.EventCategory,newPerson.Text);
            }
        }



    }
    
}
