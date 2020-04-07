﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class UpdatePoint : Form
    {
        private string MSSV;
        private string Name1;
        private String Name2;
        private string Course;
        public UpdatePoint(string MSSV, string Name1, string Name2, string Course)
        {
            InitializeComponent();
            this.MSSV = MSSV;
            this.Name1 = Name1;
            this.Name2 = Name2;
            this.Course = Course;
            FillTextBox();
        }

        public void FillTextBox()
        {
            textBoxMSSV.Text = MSSV;
            textBoxName.Text = Name2 + " " + Name1;
            textBoxCourse.Text = Course;
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {          
            this.Dispose();
        }

        private void buttonUpdatePoint_Click(object sender, EventArgs e)
        {

        }
    }
}