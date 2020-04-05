using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEYEVENT
{
    public partial class Form1 : Form
    {
        //add PresentationCore and WindowsBase on your References menu
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            listBox1.Items.Add(e.KeyCode);
            //for multiple key
            if ((Keyboard.IsKeyDown(Key.LeftAlt) || Keyboard.IsKeyDown(Key.RightAlt)) && (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) && Keyboard.IsKeyDown(Key.F))
            {
                listBox1.Items.Add("alt + ctrl + f");
            }
            listBox1.TabIndex = listBox1.TopIndex;
        }
    }
}
