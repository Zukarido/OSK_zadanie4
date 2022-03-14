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
    public partial class Receiver : Form
    {
        public static class Globals
        {
            public static String currentword;
            public static bool foundcurse = false;
            
        }
        public Receiver()
        {
            InitializeComponent();
        }
        public void messagereceived(String messagetodecode)
        {

            String messagedecoded= decode(messagetodecode);
            textboxmessagereceived.Text = messagedecoded;
        }
        private String decode(String message)
        {
            Globals.currentword = null;
            String decodedmessage = null;
            for(int i = 0; i < message.Length ; i+=11)
            {
                decodedmessage+=getcharfrombinary(message.Substring(i+1,8));
                if (Globals.foundcurse)
                {
                    decodedmessage = decodedmessage.Substring(0, i/11+1 - Globals.currentword.Length);
                    for (int j =0; j< Globals.currentword.Length; j++)
                    {
                        decodedmessage += '*';
                    }
                    Globals.currentword = null;
                    Globals.foundcurse = false;
                }
            }
            return decodedmessage;
        }
        private char getcharfrombinary(String asciichar)
        {
            char character = (char)Convert.ToInt32(asciichar, 2);
            
            if (character==' ' || character=='.' || character==',')
            {
                Globals.currentword = null;
            }
            else
            {
                Globals.currentword += character;
                Globals.foundcurse = censor(Globals.currentword);
            }

            return character;
        }
        private bool censor(String word)
        {
            word= word.ToLower();
            if (word == "cholera" || word=="witam" || word=="zdrowie" || word=="pytam") {
                return true;
                    }
            return false;
        }


    }
}
