﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleformsAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstnameValue = Firstname.Text;
            string MiddlenameValue = Middlename.Text;
            string LastnameValue = Lastname.Text;
            string SuffixValue = Suffix.Text;
            DialogResult result = MessageBox.Show($"Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello There! {FirstnameValue} {MiddlenameValue} {LastnameValue} {SuffixValue}", "Greetings my Dear Friend!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
