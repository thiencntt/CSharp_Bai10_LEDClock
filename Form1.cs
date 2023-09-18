using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Bai10_LEDClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Tham khảo: https://www.youtube.com/watch?v=sR7wTNR5asA
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Đưa form lên góc trên bên phải màn hình
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, 0);
        }
    }
}
