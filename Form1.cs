using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Encrypter : Form
    {
        public Encrypter()
        {
            InitializeComponent();
        }
        public string key;
        public string phrase;
        public bool encrypt_select = true;
        private void encrypt_CheckedChanged(object sender, EventArgs e)
        {
            encrypt_decript.Text = "Code to Encrypt";
            action.Text = "Encrypt Now";
            encrypt_select = true;
        }

        private void decrypt_CheckedChanged(object sender, EventArgs e)
        {
            encrypt_decript.Text = "Code to Decrypt";
            action.Text = "Decrypt Now";
            encrypt_select = false;
        }

        private void action_Click(object sender, EventArgs e)
        {
            key = password.Text;
            phrase = codebox.Text;

            foreach (char c in key)
            {
                switch (c)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("Case 1");
                        break;
                    case 'b':
                    case 'B':
                        Console.WriteLine("Case 2");
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }

            if (encrypt_select == true)
            {

            }
        }
    }
}
