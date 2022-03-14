using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie4
{
    public partial class Transmitter : Form
    {
        public static class Globals
        {
            public static String message;
            public static String bitmessage;
        }
        public Transmitter()
        {
            InitializeComponent();
            this.newreceiver = new Receiver();
            newreceiver.Show();
        }
        private void buttonsend_Click(object sender, EventArgs e)
        {
            newreceiver.messagereceived(Globals.bitmessage);
            Globals.bitmessage = null;
        }
        private void buttoncode_Click(object sender, EventArgs e)
        {
            Globals.bitmessage = null;
            Globals.message = textboxmessagetransmitted.Text;
            for(int i = 0; i < Globals.message.Length; i++)
            {
                chartobit(Globals.message[i]);
            }
        }
        private void chartobit(char a)
        {
            Globals.bitmessage += '0';
            int charascii = (int)a;
            String binary = Convert.ToString(charascii, 2);
            while (binary.Length < 8)
            {
                binary = '0' + binary;
            }
            Globals.bitmessage += binary + "11";
        }


    }
}
