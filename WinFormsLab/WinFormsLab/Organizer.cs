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
            ListViewItem kek = new ListViewItem();
            kek.Text = "12.12.2000";
            kek.SubItems.Add("18:20");
            kek.SubItems.Add("Sleep");
            listViewTasks.Items.Add(kek);
            OrganizerFile kek1 = new OrganizerFile();
            kek1.kek();
        }

        void initCombobox()
        {
            comboBoxTask.Items.AddRange(new string[] { EvenCategoryLab.Memo.ToString(), EvenCategoryLab.Meeting.ToString(), EvenCategoryLab.Task.ToString() });
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
        }
    }
}
