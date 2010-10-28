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

        private delegate int say();

        private void s(say s)
        {
            if (s() == 1)
            {
                Form1.ActiveForm.Text = "12313";
            };
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Sayhello(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1000);
            s(() => 1);
        }

        private static void Exit(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
