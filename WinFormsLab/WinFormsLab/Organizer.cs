using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
          //  listViewTasks.ContextMenu = this.menuStrip1.ContextMenu;
           // AddTextInListView();
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
               if(Findings[i].Name == Constants.Name) // что бы не видеть чужих пользователей
                    listViewTasks.Items.Add(kek);
               // OrganizerFile kek1 = new OrganizerFile();
              //  kek1.kek();
            }
            Constants.XML = Findings;
        }
        void AddTextInListView(OrganizerXML[] Findings)
        {


            for (int i = 0; Findings != null && i < Findings.Length; i++)
            {
                if (Findings[i] != null)
                {
                    ListViewItem kek = new ListViewItem();
                    string[] PAIN = Findings[i].Date.GetDateTimeFormats();
                    kek.Text = PAIN[0];
                    kek.SubItems.Add(Findings[i].Time.Hour + ":" + Findings[i].Time.Minute);
                    kek.SubItems.Add(Findings[i].Text.ToString());
                    if (Findings[i].Name == Constants.Name) // что бы не видеть чужих пользователей
                        listViewTasks.Items.Add(kek);
                }
                // OrganizerFile kek1 = new OrganizerFile();
                //  kek1.kek();
            }
            Constants.XML = Findings;
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
                if (Findings[i].Name == Constants.Name) // что бы не видеть чужих пользователей
                    listViewTasks.Items.Add(kek);
                // OrganizerFile kek1 = new OrganizerFile();
                //  kek1.kek();
            }
            Constants.XML = Findings;
        }
        void AddTextInListView(EvenCategoryLab Auto)
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
                if (Findings[i].Name == Constants.Name && Findings[i].EventCategory == Auto) // что бы не видеть чужих пользователей
                    listViewTasks.Items.Add(kek);
                // OrganizerFile kek1 = new OrganizerFile();
                //  kek1.kek();
            }
            Constants.XML = Findings;
        }
        private void DeleteInListView(object sender, EventArgs e)
        {
            listViewTasks.Items.Clear();
            Constants.XML = null;
        }
        private void DeleteInListView()
        {
            listViewTasks.Items.Clear();
            Constants.XML = null;
        }

        void initCombobox()
        {
            comboBoxTask.Items.AddRange(new string[] { EvenCategoryLab.Memo.ToString(), EvenCategoryLab.Meeting.ToString(), EvenCategoryLab.Task.ToString() });
            comboBoxTask.SelectedIndex = 0;
            
        }

        void RemoveElement(int elem)
        {
            int count = 0;
            OrganizerFile organizerFile = new OrganizerFile();
            OrganizerXML[] XML = new OrganizerXML[Constants.XML.Length - 1];
            for (int i =0,k =0; Constants.XML !=null && (i < Constants.XML.Length ); i++)
            {
                if (elem != i && Constants.XML[i].Name == Constants.Name)
                    XML[k++] = Constants.XML[i];
                if (Constants.XML[i].Name != Constants.Name) elem++;
                        
            } //а теперь надо зафигарить удаления файла ток в массив



            DeleteInListView();
            AddTextInListView(XML);
            OrganizerXML[] Pain =  organizerFile.SerializeFileRead();
            OrganizerXML[] Rain = new OrganizerXML[Pain.Length-XML.Length];
            for(int i=0,k=0; i<Pain.Length;i++)// в Rain запихать все остальные юзера поверх
            {
                if (elem != i && Constants.XML[i].Name != Constants.Name)
                    Rain[k] = Pain[i];
            }
            OrganizerXML[] ForWrite = new OrganizerXML[Pain.Length-1];
            for (int i =0; count < XML.Length; count++)// в Rain запихать все остальные юзера поверх
            {
                ForWrite[count] = XML[i++];
            }
            for(int i =0; count < ForWrite.Length;count++)
            {
                ForWrite[count] = Rain[i++];
            }


           // organizerFile.SerializeFileWrite(ForWrite);

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            addTask.Show();
           // addTask.FormClosing += DeleteInListView;
            addTask.FormClosed += RefreshList;
        }

        private void radioButtonAllEvents_CheckedChanged(object sender, EventArgs e)
        {
            DeleteInListView();
            AddTextInListView();
        }

        private void radioButtonAllByCategory_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
        private void radioButtonAllByCategory_CheckedChanged()
        {
            RefreshList();
        }
        private void comboBoxTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButtonAllByCategory_CheckedChanged();
        }
        
        private void RefreshList()
        {
            DeleteInListView();
            if (comboBoxTask.SelectedIndex == 0)
                AddTextInListView(EvenCategoryLab.Memo);
            else if (comboBoxTask.SelectedIndex == 1)
                AddTextInListView(EvenCategoryLab.Meeting);
            else if (comboBoxTask.SelectedIndex == 2)
                AddTextInListView(EvenCategoryLab.Task);

        }
        private void RefreshList(object sender, EventArgs e)
        {
            DeleteInListView();
            if (comboBoxTask.SelectedIndex == 0)
                AddTextInListView(EvenCategoryLab.Memo);
            else if (comboBoxTask.SelectedIndex == 1)
                AddTextInListView(EvenCategoryLab.Meeting);
            else if (comboBoxTask.SelectedIndex == 2)
                AddTextInListView(EvenCategoryLab.Task);

        }

        private void listViewTasks_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void listViewTasks_Click(object sender, EventArgs e)
        {

            //System.Windows.Forms.ListView.SelectedIndexCollection lis = listViewTasks.SelectedIndices;
              //MessageBox.Show(lis[0].ToString());
            
        }

        private void listViewTasks_ContextMenuStripChanged(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItemEdit_Click(object sender, EventArgs e)// edit
        {

        }

        private void toolStripMenuItemRemove_Click(object sender, EventArgs e)// remove
        {
            System.Windows.Forms.ListView.SelectedIndexCollection lis = listViewTasks.SelectedIndices;

            if (listViewTasks.SelectedIndices.Count > 0)
                RemoveElement(lis[0]);
        }



        private void Organizer_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control&& e.KeyCode == Keys.S)
            {
                saveFileDialog1.DefaultExt = ".xml";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName == null)
                    return;
                bool test = true;
                Constants.CreateTxtFilePaths();
                string[] tmp = Constants.ReadPaths();
                foreach (string str in tmp)
                { 
                    if (str == saveFileDialog1.FileName)
                    
                       test = false;
                }
                if (test)
                {
                    Constants.WritePaths(saveFileDialog1.FileName);
                }
                int i = 0, count = 0;

                OrganizerFile kek = new OrganizerFile();
                OrganizerXML[] XML = kek.SerializeFileRead();
                for (i = 0; i < XML.Length; i++)
                {
                    if (!radioButtonAllEvents.Checked)
                    {
                        if (XML[i].Name == Constants.Name && XML[i].EventCategory == (EvenCategoryLab)comboBoxTask.SelectedIndex)
                        {
                            count++;
                        }
                    }
                    else count = XML.Length;
                }
                OrganizerXML[] xxx = new OrganizerXML[count];
                i = 0;
                if (!radioButtonAllEvents.Checked) {
                    for (int k = 0; i < XML.Length; i++)
                    {
                        if (XML[i].Name == Constants.Name && XML[i].EventCategory == (EvenCategoryLab)comboBoxTask.SelectedIndex)
                        {
                            xxx[k++] = XML[i];
                        }
                    }
                }
                else
                {
                    xxx = XML;
                }
                if (File.Exists(saveFileDialog1.FileName))
                    File.Delete(saveFileDialog1.FileName);
                kek.SerializeFileWrite(Constants.XML, saveFileDialog1.FileName);
                
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName == null || openFileDialog1.FileName == "")
                    return;
                Constants.FileTask_xml = openFileDialog1.FileName;
                DeleteInListView();
                AddTextInListView();
            }
            if (e.KeyCode == Keys.Delete)
            {
                /// сделать это еще
            }
            if(e.Control && e.KeyCode == Keys.A)
            {
                Constants.FileTask_xml = Constants.ConstFileTask;
                DeleteInListView();
                AddTextInListView();
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Find f = new Find();
            f.Show();
            f.FormClosed += find;

        }

        void find(object sender, EventArgs e)
        {
            //string[] s = Constants.FindDate.GetDateTimeFormats();
            int count = 0;
            OrganizerFile OrgFile = new OrganizerFile();
            OrganizerXML[] ReadXML1 = OrgFile.SerializeFileRead();
            for (int i = 0; i < ReadXML1.Length; i++)
            {
                if (ReadXML1[i].Name == Constants.Name && ReadXML1[i].Date == Constants.FindDate)
                    count++;
            }
            OrganizerXML[] ReadXML = new OrganizerXML[count];
            for (int i = 0, k = 0; i < ReadXML1.Length && k < count; i++)
            {
                if (radioButtonAllEvents.Checked)
                {
                    if (ReadXML1[i].Name == Constants.Name && ReadXML1[i].Date == Constants.FindDate)
                    {
                        ReadXML[k++] = ReadXML1[i];
                    }
                }
                else
                {
                    if (ReadXML1[i].Name == Constants.Name && ReadXML1[i].EventCategory == (EvenCategoryLab)comboBoxTask.SelectedIndex && ReadXML1[i].Date == Constants.FindDate)
                    {
                        ReadXML[k++] = ReadXML1[i];
                    }
                }
            }
            DeleteInListView();
            AddTextInListView(ReadXML);
            Constants.XML =  ReadXML;
        }


        private void buttonSort_Click(object sender, EventArgs e)
        {
            Sort();
        }

        void Sort()
        {
            int count = 0;
            OrganizerFile OrgFile = new OrganizerFile();
            OrganizerXML[] ReadXML1 = OrgFile.SerializeFileRead();
            for(int i =0; i<ReadXML1.Length;i++)
            {
                if (ReadXML1[i].Name == Constants.Name)
                    count++;
            }
            OrganizerXML[]  ReadXML = new OrganizerXML[count];
            for(int i = 0,k=0; i<ReadXML1.Length&& k<count;i++)
            {
                if (radioButtonAllEvents.Checked)
                {
                    if (ReadXML1[i].Name == Constants.Name)
                    {
                        ReadXML[k++] = ReadXML1[i];
                    }
                }
                else
                {
                    if (ReadXML1[i].Name == Constants.Name && ReadXML1[i].EventCategory == (EvenCategoryLab)comboBoxTask.SelectedIndex)
                    {
                        ReadXML[k++] = ReadXML1[i];
                    }
                }
            }
            int l = 0;
            int r = ReadXML.Length-1;
            for (int i = l; i < r; i++)
            {
                int min = i;
                for (int j = i + 1; j <= r; j++)
                    if (ReadXML[j] != null&& ReadXML[min]!=null && ReadXML[j].Time.Hour < ReadXML[min].Time.Hour)
                        min = j;
                    else if (ReadXML[j] != null && ReadXML[min] != null && ReadXML[j].Time.Minute < ReadXML[min].Time.Minute)
                        min = j;

               Swap(ref ReadXML[i], ref ReadXML[min]);
            }

            DeleteInListView();
            AddTextInListView(ReadXML);
            Constants.XML =  ReadXML;

        }
        void Swap(ref OrganizerXML a, ref OrganizerXML b)
        {
            OrganizerXML tmp = a;
            a = b;
            b = tmp;
        }

    }
}
