using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WinFormsLab
{
    public partial class Start : Form
    {

        public Start()
        {
             
            InitializeComponent();
            Constants.FileTask_xml = Constants.ConstFileTask;
            textBoxLogin.Text = "ЖОПА";
            textBoxPassword.Text = "ГОРИТ";
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxPassword.Checked)
              textBoxPassword.PasswordChar = (char) 0;
            else
               textBoxPassword.PasswordChar = '*';
            Console.WriteLine((int)textBoxPassword.PasswordChar);

            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            StructAutorization StructAutorize = new StructAutorization();
            StartMenu menu = new StartMenu();

            if (textBoxLogin.Text.Trim(' ').Length == 0 || textBoxPassword.Text.Trim(' ').Length == 0 || menu.CheckNullInString(textBoxLogin.Text) || menu.CheckNullInString(textBoxPassword.Text))
                MessageBox.Show("Wrong login or password!");
            else
            {
                bool tus = false;
                StructAutorize.Login = textBoxLogin.Text;
                StructAutorize.Password = textBoxPassword.Text;
                StructAutorization[] StructAutorize1 = menu.ReadLoginPasswordAuthorizationBinaryFile(Constants.FileAutorizarion_dat);
                foreach (StructAutorization StrucAuto in StructAutorize1)
                {
                    if (menu.CheckLogin(StrucAuto.Login, StructAutorize.Login) && menu.CheckPassword(StrucAuto.Password, StructAutorize.Password))
                    {
                        //место входа
                        Constants.Name = StructAutorize.Login;
                        Organizer MenuOrganizer = new Organizer(StructAutorize.Login);
                        MenuOrganizer.Show();
                        MessageBox.Show("Добро пожаловать " + StructAutorize.Login, "Вход", MessageBoxButtons.OK);
                        tus = true;
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                        break;
                    }
                }
                
                 if (!tus)
                 {
                    DialogResult res = MessageBox.Show("Wrong login or password!\r\nСоздать запись?", "Создать запись?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(res == DialogResult.Yes)
                    {
                        for (int i = StructAutorize.Login.Length; i < 32; i++) 
                        {

                            StructAutorize.Login += "0";
                        }
                        for (int i = StructAutorize.Password.Length; i < 32; i++) 
                        {
                            StructAutorize.Password += "0";
                        }
                        menu.WriteLoginPasswordAuthorizationBinaryFile(WinFormsLab.Constants.FileAutorizarion_dat, StructAutorize);
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                    }
                }

                

            }



        }
    }
}
