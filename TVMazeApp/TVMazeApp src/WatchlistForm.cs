﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVMazeApp
{
    public partial class WatchlistForm : Form
    {
        public WatchlistForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form2 = new Form1();
            form2.Closed += (s, args) => Close();
            form2.Show();
        }
    }
}
