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
    public partial class Find : Form
    {
        public Find()
        {
            
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Constants.FindDate = monthCalendar1.SelectionRange.Start;
            Close();
        }

        private void Find_FormClosed(object sender, FormClosedEventArgs e)
        {
            Constants.FindDate = monthCalendar1.SelectionRange.Start;
        }
    }
}
