﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardCore;

namespace CardMaker
{
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void ProjectForm_Close(object sender, EventArgs e)
        {
            EffectManager.GetInstance().Dispose();
            CardManager.GetInstance().Dispose();
            SetManager.GetInstance().Dispose();
        }
    }
}
