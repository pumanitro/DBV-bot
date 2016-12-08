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
            Client client = null;

            try
            {
                Process Dbv = Process.GetProcessesByName("DBV")[0];
                client = new Client(Dbv);
            }
            catch
            {
                MessageBox.Show("Please run DBV client");
                System.Windows.Forms.Application.Exit();
            }

            Player player = client.GetPlayer();

            playerName.Text = player.Name;

        }

    }
}
