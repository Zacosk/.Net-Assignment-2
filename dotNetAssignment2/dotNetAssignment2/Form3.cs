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
        }

        private void SetControlPermissions(Boolean bol)
        {
            richTextBox1.Enabled = bol;
            topToolStrip.Enabled = bol;
            sideToolStrip.Enabled = bol;
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open a Text File";
            openFileDialog.Filter = "Rich Text Files (*.rtf) | *.rtf| All Files(*.*) | *.*";

            DialogResult dr = openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                richTextBox1.Lines = File.ReadAllLines(openFileDialog.FileName);
                openedFileName = openFileDialog.FileName;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        void NewFile()
        {
            richTextBox1.Clear();
            openedFileName = null;
        }

        void SaveAsFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Rich Text Files (*.rtf) | *.rtf| All Files(*.*) | *.*";
            DialogResult dr = saveFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MessageBox.Show("File Saved");
                File.WriteAllLines(saveFileDialog.FileName, richTextBox1.Lines);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        void SaveFile()
        {
            if (openedFileName == null)
            {
                SaveAsFile();
            } else
            {
                File.WriteAllLines(openedFileName, richTextBox1.Lines);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void topToolStripBoldBtn_Click(object sender, EventArgs e)
        {
            SetTextStyle(FontStyle.Bold);
        }

        private void topToolStripItalicBtn_Click(object sender, EventArgs e)
        {
            SetTextStyle(FontStyle.Italic);
        }

        void SetTextStyle (System.Drawing.FontStyle newFontStyle)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;

                switch(newFontStyle)
                {
                    case FontStyle.Italic:
                        if (richTextBox1.SelectionFont.Italic == true)
                        {
                            newFontStyle = FontStyle.Regular;
                        }
                        else
                        {
                            newFontStyle = FontStyle.Italic;
                        } break;
                    case FontStyle.Bold:
                        if (richTextBox1.SelectionFont.Bold == true)
                        {
                            newFontStyle = FontStyle.Regular;
                        }
                        else
                        {
                            newFontStyle = FontStyle.Bold;
                        }
                        break;
                    case FontStyle.Underline:
                        if (richTextBox1.SelectionFont.Underline == true)
                        {
                            newFontStyle = FontStyle.Regular;
                        }
                        else
                        {
                            newFontStyle = FontStyle.Underline;
                        }
                        break;
                }

                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        private void topToolStripUnderlineBtn_Click(object sender, EventArgs e)
        {
            SetTextStyle(FontStyle.Underline);
        }

        private void sideToolStripCutBtn_Click(object sender, EventArgs e)
        {
            CutSelectedText();
        }

        void CutSelectedText()
        {
            if (richTextBox1.SelectedText != null)
            {
                richTextBox1.Cut();
            }
        }

        void PasteSelectedText()
        {
            if (richTextBox1.SelectedText != null)
            {
                richTextBox1.Paste();
            }
        }

        void CopySelectedText()
        {
            if (richTextBox1.SelectedText != null)
            {
                richTextBox1.Copy();
            }
        }

        private void sideToolStripCopyBtn_Click(object sender, EventArgs e)
        {
            CopySelectedText();
        }

        private void sideToolStripPasteBtn_Click(object sender, EventArgs e)
        {
            PasteSelectedText();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutSelectedText();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopySelectedText();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteSelectedText();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;

                richTextBox1.SelectionFont = new Font(
                   currentFont.FontFamily,
                   Convert.ToInt32(topToolStripSizeComboBox.SelectedItem),
                   currentFont.Style
                );
            }
        }
    }
}
