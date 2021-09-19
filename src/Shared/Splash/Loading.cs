﻿using Helper;
using System;
using System.Drawing;
using System.Windows.Forms;
using Util;

namespace Vega
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            Size = new Size(Resolution.BoundsWidth, Resolution.BoundsHeight);

            Aligner.TopLeft(this, this);

            Aligner.Center(this, parrotCircleProgressBar1);
        }

        private void Loading_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}