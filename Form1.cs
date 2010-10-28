using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace git_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sayhello(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000);
        }

        private static void Exit(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
