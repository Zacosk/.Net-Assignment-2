using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace dotNetAssignment2
{
    public partial class CreateNewUserForm : Form
    {
        LinkedList<string> existingUserNames = new LinkedList<string>();
        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginForm = new LoginPage();
            loginForm.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            existingUserNames.Clear();
            LoadExistingUserNames();
            string username = usernameTxt.Text;
            string password1 = password1Txt.Text;
            string password2 = password2Txt.Text;
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            string date = dobPicker.Value.ToString("dd-MM-yyyy");
            if (!existingUserNames.Contains(username))
            {
                try
                {
                    string type = userTypeComboBox.SelectedItem.ToString();
                    if (password1 == password2)
                    {
                        File.AppendAllText("login.txt", "\n" + username + "," + password1 + "," + type + "," + firstName + "," + lastName + "," + date);
                        this.Hide();
                        LoginPage loginForm = new LoginPage();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error, passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        password1Txt.Clear();
                        password2Txt.Clear();
                    }
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show("Error, no usertype selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error, username not unique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Clear();
            }
        }
        void LoadExistingUserNames()
        {
            string[] fileText = File.ReadAllLines("login.txt");
            for (int i = 0; i < fileText.Length; i++)
            {
                string[] splitText = fileText[i].Split(',');
                existingUserNames.AddLast(splitText[0]);
                //MessageBox.Show(existingUserNames.ElementAt(0), "test");
            }
        }
    }
}
