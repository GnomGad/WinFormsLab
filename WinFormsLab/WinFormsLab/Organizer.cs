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
            
            InitializeComponent(TextFromStart);
            this.Text = Name + " for " + TextFromStart;
        }

        private void Organizer_Load(object sender, EventArgs e)
        {

        }
    }
}
