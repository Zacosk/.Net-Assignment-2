using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dotNetAssignment2
{
    public partial class LoginForm : Form
    {
        LinkedList<User> users = new LinkedList<User>();
        public static User selectedUser;
        public LoginForm()
        {
            InitializeComponent();
            LoadLineDetails();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Exit program
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //Get username and password from text fields
            string username = userNameTxt.Text;
            string password = passwordTxt.Text;
            //Verify user inputted login details
            if (VerifyLoginDetails(username, password))
            {
                //If login details are valid open new text editor
                TextEditorForm textEditorForm = new TextEditorForm();
                textEditorForm.Show();
                this.Hide();
            }
        }
        private void LoadLineDetails()
        {
            //Load login details from login file into user list
            string[] fileText = File.ReadAllLines("login.txt");
            for (int i = 0; i < fileText.Length; i++)
            {
                string[] splitText = fileText[i].Split(',');
                User user = new User(splitText[0], splitText[1], splitText[2], splitText[3], splitText[4], splitText[5]);
                users.AddLast(user);
            }
        }

        private Boolean VerifyLoginDetails(string username, string password)
        {
            //Check each user within user list, return true if username and password match a user in user list, load user into current user
            for (int i = 0; i < users.Count; i++)
            {
                User currentUser = users.ElementAt(i);
                if (username == currentUser.username && password == currentUser.password)
                {
                    selectedUser = users.ElementAt(i);
                    return true;
                }
            }
            //Else return false, display error messagebox and clear login form text fields
            MessageBox.Show("Invalid login details", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            userNameTxt.Clear();
            passwordTxt.Clear();
            return false;
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            //Open new account form, hide this form
            CreateNewUserForm newAccountForm = new CreateNewUserForm();
            newAccountForm.Show();
            this.Hide();
        }
    }
    public class User
    {
        //User class to contain all user details
        public enum UserType
        {
            View,
            Edit
        }
        public string username { get; }
        public string password { get; }
        string firstName, lastName, dob;
        public UserType userType { get; }
        public User(string username, string password, string userType, string firstName, string lastName, string dob)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.userType = (UserType) Enum.Parse(typeof(UserType), userType);
        }
    }
}
