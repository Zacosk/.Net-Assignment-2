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
            //Hide this form and open new login form
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Load details in textboxes into string
            existingUserNames.Clear();
            //Load existing usernames into memory
            LoadExistingUserNames();
            string username = usernameTxt.Text;
            string password1 = password1Txt.Text;
            string password2 = password2Txt.Text;
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            string date = dobPicker.Value.ToString("dd-MM-yyyy");

            //Ensure username is unique by checking if it exists in existing username linkedlist
            if (!existingUserNames.Contains(username))
            {
                try
                {
                    string type = userTypeComboBox.SelectedItem.ToString();
                    if (password1 == password2)
                    {
                        //If username is unique and passwords match, add account details to text file, hide form and open login form
                        File.AppendAllText("login.txt", "\n" + username + "," + password1 + "," + type + "," + firstName + "," + lastName + "," + date);
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                    else
                    {
                        //if passwords do not match display error messagebox and clear password text fields
                        MessageBox.Show("Error, passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        password1Txt.Clear();
                        password2Txt.Clear();
                    }
                }
                catch (System.NullReferenceException)
                {
                    //if usertype not selected display appropriate error message in message box
                    MessageBox.Show("Error, no usertype selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //if username is not unique, display appropriate error message in message box
                MessageBox.Show("Error, username not unique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Clear();
            }
        }
        void LoadExistingUserNames()
        {
            //Load usernames from login file into linkedlist
            string[] fileText = File.ReadAllLines("login.txt");
            for (int i = 0; i < fileText.Length; i++)
            {
                string[] splitText = fileText[i].Split(',');
                existingUserNames.AddLast(splitText[0]);
            }
        }
    }
}
