﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filedialog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = Resource1.Add;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string BeirtSzoveg = textBox1.Text;
                listBox1.Items.Add(BeirtSzoveg);
            }
            catch (Exception)
            {

                MessageBox.Show("nem írtál be semmit!"); // ez így nem jó, de most így hagyom
            }
        }
    }
}
