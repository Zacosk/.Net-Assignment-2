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
    public partial class LoginPage : Form
    {
        LinkedList<User> users = new LinkedList<User>();
        public LoginPage()
        {
            InitializeComponent();
            LoadLineDetails();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userNameTxt.Text;
            string password = passwordTxt.Text;
            if (VerifyLoginDetails(username, password))
            {
                MessageBox.Show("Login accepted", "Login");
                //Form2 textForm = new Form2();
                //textForm.Show();
                //this.Hide();
            }
        }
        private void LoadLineDetails()
        {
            
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
            for (int i = 0; i < users.Count; i++)
            {
                User currentUser = users.ElementAt(i);
                if (username == currentUser.username && password == currentUser.password)
                { 
                    //this.Hide();
                    return true;
                }
            }
            MessageBox.Show("Invalid login details", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            userNameTxt.Clear();
            passwordTxt.Clear();
            return false;
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //New form
        }
    }
    class User
    {
        enum UserType
        {
            View,
            Edit
        }
        public string username { get; }
        public string password { get; }
        string firstName, lastName, dob;
        UserType userType;
        public User(string username, string password, string userType, string firstName, string lastName, string dob)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dob = dob;
            this.userType = (UserType) Enum.Parse(typeof(UserType), userType);
        }
        string PrintableLine()
        {
            string text = username + "," + password + "," + userType.ToString() + "," + firstName + "," + lastName + "," + dob;
            return text;
        }
    }
}
