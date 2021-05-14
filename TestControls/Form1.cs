using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestControls {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e) {
            Console.WriteLine(1);
        }

        private void Form1_Load(object sender, EventArgs e) {
            customToggle1.Checked = true;
            //customToggle1.Checked = false;
        }
    }
}
