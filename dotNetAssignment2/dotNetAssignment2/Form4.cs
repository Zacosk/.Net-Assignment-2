using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dotNetAssignment2
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            TextEditorForm textEditorForm = new TextEditorForm();
            textEditorForm.Show();
            this.Hide();
        }
    }
}
