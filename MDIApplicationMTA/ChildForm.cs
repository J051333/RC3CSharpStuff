﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplicationMTA {
    public partial class ChildForm : Form {
        public ChildForm() {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e) {
            Text = DateTime.Now.ToString();
        }
    }
}
