using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLab
{
    [Serializable]
    public class OrganizerFile
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public EvenCategoryLab EventCategory { get; set; }

        public OrganizerFile(DateTime d,DateTime t, EvenCategoryLab e)
        {
            Date = d;
            Time = t;
            EventCategory = e;
        }
    }
    
}
