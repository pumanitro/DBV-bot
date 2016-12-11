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
            

            //client = new Client(Dbv);
            //MessageBox.Show("Please run DBV client");
            //System.Windows.Forms.Application.Exit();



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Process Dbv = Process.GetProcessesByName("DBV")[0];
            IntPtr handle = Dbv.Handle;
            UInt32 Base = (UInt32)Dbv.MainModule.BaseAddress.ToInt32();

            // heal offset taken by cheat engine Base + 0x231D8C

            //We dont need Base adress bcs ReadInt32 take handle and then he adds offsets to this handle
            playerName.Text = Memory.ReadInt32(handle, Player.Health).ToString();
        }
    }
}
