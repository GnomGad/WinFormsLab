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
        OrganizerXML[] MainXML = null;
        int Value = -1;
        OrganizerXML OneXMl = null;
        bool CheckTask = false;
        public AddTask()
        {
            InitializeComponent();
            Build();
        }
        public AddTask(OrganizerXML[] ArrayOrg,int i)
        {
            CheckTask = true;
            InitializeComponent();
            MainXML = ArrayOrg;
            Value = i;
            OneXMl = ArrayOrg[i];
            Build(ArrayOrg, i);

        }
        void Build(OrganizerXML[] ArrayOrg, int i)
        {
            Build();
            OrganizerXML xml = ArrayOrg[i];
            SetItems(ArrayOrg[i]);

        }
        void Build()
        {
            initCombobox();
        }
        void SetItems(OrganizerXML xml)
        {
            comboBox1.SelectedIndex = (int)xml.EventCategory;
            textBox1.Text = xml.Text;
            dateTimePicker1.Value = xml.Time;
            monthCalendar1.TodayDate = xml.Date;
            
        }
        void initCombobox()
        {
            comboBox1.Items.AddRange(new string[] { EvenCategoryLab.Memo.ToString(), EvenCategoryLab.Meeting.ToString(), EvenCategoryLab.Task.ToString() });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckTask)
            {
                button1_Click2(sender, e);
            }
            else
                button1_Click1(sender, e);
        }
        private void button1_Click1(object sender, EventArgs e)
        {
            bool TestTime = true;
            bool TestEven = true;
            bool TestName = true;
            bool TestText = true;
            bool TestDate = true;

            OrganizerXML Oz = new OrganizerXML();
            OrganizerFile ORGfile = new OrganizerFile();
            
            Oz.Time = dateTimePicker1.Value;
            Oz.Date = monthCalendar1.SelectionRange.Start;
            Oz.Text = textBox1.Text;
            Oz.EventCategory = (EvenCategoryLab)comboBox1.SelectedIndex;   
            Oz.Name = Constants.Name;
            string[] Dat = Oz.Date.GetDateTimeFormats();
            //MessageBox.Show(Dat[0]);

            if ((int)Oz.EventCategory == -1)
            {
                TestEven = false;
                MessageBox.Show("Укажи тип","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (Oz.Name == null || Oz.Name == "")
            {
                TestName = false;
                MessageBox.Show("Ошибка с именем юзера\r\n Боль, а не ошибка", "Очень странная Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(Oz.Text == null || Oz.Text.Trim() == "")
            {
                TestText = false;
                MessageBox.Show("Где текст сударь?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DateTime dd = DateTime.Now;

            if (Oz.Date.DayOfYear < dd.DayOfYear)
            {// если день меньше, чем текущий, то чекаем годы
                if (Oz.Date.Year > dd.Year)
                {
                    TestDate = false;
                    MessageBox.Show("Нельзя указать день из прошлого", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (Oz.Date.DayOfYear == dd.DayOfYear)// если дни одинаковы то чекаем время
            {
                if (Oz.Time.Hour == dd.Hour)
                { // если текущий час меньше то чекаем минуты
                    if (Oz.Time.Minute < dd.Minute+10)
                    {
                        TestDate = false;
                        int kek = - Oz.Time.Minute + dd.Minute ;
                        MessageBox.Show("Событие через "+kek+" минут?\r\n ты кого обамнуть пытаешься?\r\n событие должно быть не раньше чем ререз 10 минут", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (Oz.Time.Hour < dd.Hour)
                {
                    TestDate = false;
                    MessageBox.Show("Ты там че курил?\r\n Стрелки часов переверни", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            if(TestDate && TestEven && TestName &&TestText && TestTime)
            {
                OrganizerXML KEK = Oz;
                ORGfile.SerializeBrainFileWrite(Oz);
                MessageBox.Show("Новая метка была добавлена");
                Close();

            }
           

            // MessageBox.Show("Новая метка была добавлена");
            

        }
        private void button1_Click2(object sender,EventArgs e)
        {
            bool TestTime = true;
            bool TestEven = true;
            bool TestName = true;
            bool TestText = true;
            bool TestDate = true;

           
            OrganizerFile ORGfile = new OrganizerFile();

            OneXMl.Time = dateTimePicker1.Value;
            OneXMl.Date = monthCalendar1.SelectionRange.Start;
            OneXMl.Text = textBox1.Text;
            OneXMl.EventCategory = (EvenCategoryLab)comboBox1.SelectedIndex;
            OneXMl.Name = Constants.Name;
            string[] Dat = OneXMl.Date.GetDateTimeFormats();
            //MessageBox.Show(Dat[0]);

            if ((int)OneXMl.EventCategory == -1)
            {
                TestEven = false;
                MessageBox.Show("Укажи тип", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (OneXMl.Name == null || OneXMl.Name == "")
            {
                TestName = false;
                MessageBox.Show("Ошибка с именем юзера\r\n Боль, а не ошибка", "Очень странная Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (OneXMl.Text == null || OneXMl.Text.Trim() == "")
            {
                TestText = false;
                MessageBox.Show("Где текст сударь?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DateTime dd = DateTime.Now;

            if (OneXMl.Date.DayOfYear < dd.DayOfYear)
            {// если день меньше, чем текущий, то чекаем годы
                if (OneXMl.Date.Year > dd.Year)
                {
                    TestDate = false;
                    MessageBox.Show("Нельзя указать день из прошлого", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (OneXMl.Date.DayOfYear == dd.DayOfYear)// если дни одинаковы то чекаем время
            {
                if (OneXMl.Time.Hour == dd.Hour)
                { // если текущий час меньше то чекаем минуты
                    if (OneXMl.Time.Minute < dd.Minute + 10)
                    {
                        TestDate = false;
                        int kek = -OneXMl.Time.Minute + dd.Minute;
                        MessageBox.Show("Событие через " + kek + " минут?\r\n ты кого обамнуть пытаешься?\r\n событие должно быть не раньше чем ререз 10 минут", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (OneXMl.Time.Hour < dd.Hour)
                {
                    TestDate = false;
                    MessageBox.Show("Ты там че курил?\r\n Стрелки часов переверни", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (TestDate && TestEven && TestName && TestText && TestTime)
            {

                MainXML[Value] = OneXMl;
                ORGfile.SerializeFileWrite(MainXML);
                MessageBox.Show("Метка была изменена");
                Close();

            }
        }
    }
}
