﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roster.Model;
using Roster.Forms;

namespace Roster
{
    public partial class Form1 : Form
    {
        public AddStudentForm AddStudent = new AddStudentForm();
        public FindStudentForm FindStudent = new FindStudentForm();
        public Context Context = new Model.Context();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

  
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent.ShowDialog(Context);
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindStudent.ShowDialog(Context);
        }
    }
}
