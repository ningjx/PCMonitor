﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIDA64Ext.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
        }

        private void timeControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (netSpeedControl1.DownloadBigger)
                netSpeedControl1.DownloadBigger = false;
            else
                netSpeedControl1.DownloadBigger = true;
            netSpeedControl1.Refresh();
        }
    }
}
