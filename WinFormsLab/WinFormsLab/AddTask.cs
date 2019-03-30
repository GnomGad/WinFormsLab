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
    }
}
