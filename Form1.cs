using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bluexcreen bluexcreen = new bluexcreen();
            bluexcreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            redscreen redscreen = new redscreen();
            redscreen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Noctrl noctrl = new Noctrl();
               noctrl.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
