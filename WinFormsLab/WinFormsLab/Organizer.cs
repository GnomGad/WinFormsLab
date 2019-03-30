using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLab
{
    public partial class Organizer : Form
    {
        public Organizer(string TextFromStart)
        {
            
            InitializeComponent();
            this.Text = Name + " for " + TextFromStart;
            Build();


        }

        private void Organizer_Load(object sender, EventArgs e)
        {
            

        }

        void Build()
        {
            initCombobox();
            AddTextInListView();
        }
        void AddTextInListView()
        {
            
            OrganizerFile organizerFile = new OrganizerFile();
            OrganizerXML[] Findings = organizerFile.SerializeFileRead();
            for (int i = 0;Findings!= null && i < Findings.Length; i++)
            {
                ListViewItem kek = new ListViewItem();
                string[] PAIN = Findings[i].Date.GetDateTimeFormats();
                kek.Text = PAIN[0];
                kek.SubItems.Add(Findings[i].Time.Hour+":"+ Findings[i].Time.Minute);
                kek.SubItems.Add(Findings[i].Text.ToString());
                listViewTasks.Items.Add(kek);
               // OrganizerFile kek1 = new OrganizerFile();
              //  kek1.kek();
            }
        }
        void AddTextInListView(object sender, EventArgs e)
        {

            OrganizerFile organizerFile = new OrganizerFile();
            OrganizerXML[] Findings = organizerFile.SerializeFileRead();
            for (int i = 0; Findings != null && i < Findings.Length; i++)
            {
                ListViewItem kek = new ListViewItem();
                string[] PAIN = Findings[i].Date.GetDateTimeFormats();
                kek.Text = PAIN[0];
                kek.SubItems.Add(Findings[i].Time.Hour + ":" + Findings[i].Time.Minute);
                kek.SubItems.Add(Findings[i].Text.ToString());
                listViewTasks.Items.Add(kek);
                // OrganizerFile kek1 = new OrganizerFile();
                //  kek1.kek();
            }
        }
        private void DeleteInListView(object sender, EventArgs e)
        {
            listViewTasks.Items.Clear();
        }


        void initCombobox()
        {
            comboBoxTask.Items.AddRange(new string[] { EvenCategoryLab.Memo.ToString(), EvenCategoryLab.Meeting.ToString(), EvenCategoryLab.Task.ToString() });
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
            addTask.FormClosing += DeleteInListView;
            addTask.FormClosed += AddTextInListView;
        }
    }
}
