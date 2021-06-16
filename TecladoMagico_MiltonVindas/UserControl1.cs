using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoMagico_MiltonVindas
{
    public partial class UserControl1: UserControl
    {
        public Dictionary<char, int> keyboard;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void calculateMov(object sender, EventArgs e)
        {
            keyboard = new Dictionary<char, int>();

            string config = boxSecuencia.Text;
            setConfig(config);
              
            string word = boxTexto.Text;
            getResult(word);

        }

        public void setConfig(string config)
        {
            int value = 0;
            foreach (char c in config)
            {
                keyboard.Add(c, value);
                value += 1;
            }
        }

        public void getResult(string word)
        {
            int result = 0;
            int value;
            int startingPoint = 0;
            foreach (char c in word)
            {
                if (keyboard.TryGetValue(c, out value))
                {
                    result += Math.Abs(value - startingPoint);
                    startingPoint = value;
                }
                else
                {
                    boxResult.Text = "Error";
                }
            }
            boxResult.Text = result.ToString();
        }
    }
}
