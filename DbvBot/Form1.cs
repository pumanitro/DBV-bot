using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tibia;
using Tibia.Objects;

namespace DbvBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Process Dbv = Process.GetProcessesByName("DBV")[0];
            }
            catch
            {
                MessageBox.Show("Please run DBV client");
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
