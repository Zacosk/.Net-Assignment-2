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
    public partial class TextEditorForm : Form
    {
        string openedFileName;
        public TextEditorForm()
        {
            InitializeComponent();
            //Display users username in top tool strip label
            userNameLabel.Text = "User Name: " + LoginForm.selectedUser.username;
            //enable or disable rich textbox depending on user type
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
            //open login form, hide this form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open about form
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void SetControlPermissions(Boolean bol)
        {
            //enable or disable form components depending on user type
            richTextBox1.Enabled = bol;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //run open file method
            OpenFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //run save file method
            SaveAsFile();
        }

        void OpenFile()
        {
            //open a openfiledialog to allow the user to open a rich text file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a Text File";
            openFileDialog.Filter = "Rich Text Files (*.rtf) | *.rtf| All Files(*.*) | *.*";

            DialogResult dr = openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //if user opens appropriate file, load file into rich text box and load file name
                richTextBox1.Lines = File.ReadAllLines(openFileDialog.FileName);
                openedFileName = openFileDialog.FileName;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //run open file method
            OpenFile();
        }

        void NewFile()
        {
            //clear rich text box and clear opened file name
            richTextBox1.Clear();
            openedFileName = null;
        }

        void SaveAsFile()
        {
            //open savefiledialog to allow user to save richtextbox content to file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Files (*.rtf) | *.rtf| All Files(*.*) | *.*";
            DialogResult dr = saveFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                //if file saved open messagebox to show file saved feedback, save file
                File.WriteAllLines(saveFileDialog.FileName, richTextBox1.Lines);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //run new file method
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //run new file method
            NewFile();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //run saveasfile method
            SaveAsFile();
        }

        void SaveFile()
        {
            //save the current file
            if (openedFileName == null)
            {
                //if the file is new and hasn't been saved before, run save as method
                SaveAsFile();
            } else
            {
                //else save file with stored file name
                File.WriteAllLines(openedFileName, richTextBox1.Lines);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //run save file method
            SaveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //run save file method
            SaveFile();
        }

        private void topToolStripBoldBtn_Click(object sender, EventArgs e)
        {
            //run settextstyle method with bold text style
            SetTextStyle(FontStyle.Bold);
        }

        private void topToolStripItalicBtn_Click(object sender, EventArgs e)
        {
            //run settextstyle method with italic text style
            SetTextStyle(FontStyle.Italic);
        }

        void SetTextStyle (System.Drawing.FontStyle newFontStyle)
        {
            //if the user has selected text in the richtextbox
            if (richTextBox1.SelectionFont != null)
            {
                //load current font and instantiate existing font style variables
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                System.Drawing.FontStyle boldFontStyle = FontStyle.Regular;
                System.Drawing.FontStyle underlineFontStyle = FontStyle.Regular;
                System.Drawing.FontStyle italicFontStyle = FontStyle.Regular;

                //if the selected text is already bold, italic or underlined, set the variables to reflect this
                if (currentFont.Style == FontStyle.Bold)
                {
                    boldFontStyle = FontStyle.Bold;
                }
                if (currentFont.Style == FontStyle.Italic)
                {
                    italicFontStyle = FontStyle.Italic;
                }
                if (currentFont.Style == FontStyle.Underline)
                {
                    boldFontStyle = FontStyle.Underline;
                }

                //set new font style to be added to selection text or if text is already that style, remove that style from text
                switch (newFontStyle)
                {
                    case FontStyle.Italic:
                        if (richTextBox1.SelectionFont.Italic == true)
                        {
                            italicFontStyle = FontStyle.Regular;
                        }
                        else
                        {
                            italicFontStyle = FontStyle.Italic;
                        } break;
                    case FontStyle.Bold:
                        if (richTextBox1.SelectionFont.Bold == true)
                        {
                            boldFontStyle = FontStyle.Regular;
                        }
                        else
                        {
                            boldFontStyle = FontStyle.Bold;
                        }
                        break;
                    case FontStyle.Underline:
                        if (richTextBox1.SelectionFont.Underline == true)
                        {
                            underlineFontStyle = FontStyle.Regular;
                        }
                        else
                        {
                            underlineFontStyle = FontStyle.Underline;
                        }
                        break;
                }

                //apply user selected fontstyle to text
                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   underlineFontStyle | boldFontStyle | italicFontStyle
                );
            }
        }

        private void topToolStripUnderlineBtn_Click(object sender, EventArgs e)
        {
            //run settextstyle method with underline text style
            SetTextStyle(FontStyle.Underline);
        }

        private void sideToolStripCutBtn_Click(object sender, EventArgs e)
        {
            //run cutselectedtext method
            CutSelectedText();
        }

        void CutSelectedText()
        {
            //if the user can selected text cut it
            if (richTextBox1.SelectedText != null)
            {
                richTextBox1.Cut();
            }
        }

        void PasteSelectedText()
        {
            //if the user has selected text, paste it
            if (richTextBox1.SelectedText != null)
            {
                richTextBox1.Paste();
            }
        }

        void CopySelectedText()
        {
            //if the user has selected text, copy it
            if (richTextBox1.SelectedText != null)
            {
                richTextBox1.Copy();
            }
        }

        private void sideToolStripCopyBtn_Click(object sender, EventArgs e)
        {
            //run copyselectedtext method
            CopySelectedText();
        }

        private void sideToolStripPasteBtn_Click(object sender, EventArgs e)
        {
            //run pasteselectedtext method
            PasteSelectedText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //run cutselectedtext method
            CutSelectedText();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //run copyselectedtext method
            CopySelectedText();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //run pasteselectedtext method
            PasteSelectedText();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the user has selected text
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;

                //set text to be user selected size
                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   Convert.ToInt32(topToolStripSizeComboBox.SelectedItem),
                   currentFont.Style
                );
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            //open about form
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
