using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dotNetAssignment2
{
    public partial class TextEditorForm : Form
    {
        public TextEditorForm()
        {
            InitializeComponent();
            userNameLabel.Text = "User Name: " + LoginForm.selectedUser.username;
            if (LoginForm.selectedUser.userType.ToString() == "View")
            {
                //Set file as view only
                SetControlPermissions(false);
            } else if (LoginForm.selectedUser.userType.ToString() == "Edit")
            {
                //set file as edit
                SetControlPermissions(true);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
            this.Hide();
        }

        private void SetControlPermissions(Boolean bol)
        {
            richTextBox1.Enabled = bol;
            topToolStrip.Enabled = bol;
            sideToolStrip.Enabled = bol;
        }
    }
}
