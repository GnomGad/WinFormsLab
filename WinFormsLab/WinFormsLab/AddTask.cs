using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WinFormsLab
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
            Build();
        }

        void Build()
        {
            initCombobox();
        }

        void initCombobox()
        {
            comboBox1.Items.AddRange(new string[] { EvenCategoryLab.Memo.ToString(), EvenCategoryLab.Meeting.ToString(), EvenCategoryLab.Task.ToString() });
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrganizerXML Oz = new OrganizerXML();
            OrganizerFile ORGfile = new OrganizerFile();
            Oz.Time =dateTimePicker1.Value.Date;
            Oz.Date = monthCalendar1.SelectionRange.Start;
            Oz.Text = textBox1.Text;
            Oz.EventCategory = (EvenCategoryLab)comboBox1.SelectedIndex;
            Oz.Name = "Привет";
            //OrganizerXML KEK = Oz;
            ORGfile.SerializeBrainFileWrite(Oz);
            
            MessageBox.Show("Новая метка была добавлена");
            Close();

        }
    }
}
