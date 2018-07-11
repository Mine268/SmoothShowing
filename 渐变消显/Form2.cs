using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 渐变消显
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Shown += Show_f;
            this.FormClosing += Hide_f;
        }

        void Form2_Shown(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Show_f(object sender, EventArgs e)
        {
            double i = 0.0;
            while (i <= 1.0)
            {
                this.Opacity = Math.Sin((Math.PI / 2) * i);
                i = i + 0.05;
                System.Threading.Thread.Sleep(1);
            }
        }

        private void Hide_f(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            double i = 0.0;
            while (i <= 1.0)
            {
                this.Opacity = Math.Cos((Math.PI / 2) * i);
                i = i + 0.1;
                System.Threading.Thread.Sleep(1);
            }
            this.Dispose();
        }
    }
}
