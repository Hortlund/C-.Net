using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Word_and_filehandeling
{
    public partial class Form1 : Form
    {


      
        public void markName()
        {
            
            if (!this.Text.Contains("*"))
            {
                this.Text += "*";
            }
        }

        

        public Form1()
        {
            InitializeComponent();
            this.Text = "dok1.txt";

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            fileStatus.Text = "";
            charCount.Text = "Chars w space: " + textArea.Text.Length;
            charCount2.Text = "Chars w/0 space: " + ((textArea.Text.Length) - (textArea.Text.Split(' ').Length) +1);
            char[] delim = new char[] { ' ', '\r', '\n' };
            wordCount.Text = "Words: " + textArea.Text.Split(delim, StringSplitOptions.RemoveEmptyEntries).Length;
            char[] delim2 = new char[] { '\r', '\n' };
            rowCount.Text = "Rows: " + textArea.Text.Split(delim2).Length;
            markName();


        }
        
        

        public void saveFileDialog()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(savefile.FileName, textArea.Text);
                fileStatus.Text = "File saved!";
                this.Text = Path.GetFileName(savefile.FileName);
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string fileName = this.Text;
            if (fileName.Contains("dok1.txt"))
            {
                saveFileDialog();
            }
            else
            {
                FileInfo filePath = new FileInfo(fileName.Remove(fileName.Length -1, 1));
                Console.WriteLine(filePath);
                string fullname = filePath.FullName;
              
                File.WriteAllText(fullname, textArea.Text);
                this.Text = this.Text.Remove(this.Text.Length - 1, 1);
                fileStatus.Text = "File saved!";
                
            }
            

        }

        private void open_Click(object sender, EventArgs e)
        {

            if (textArea.TextLength == 0)
            {

                OpenFileDialog openfile = new OpenFileDialog();

                openfile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    textArea.Text = File.ReadAllText(openfile.FileName);
                    this.Text = openfile.SafeFileName;
                }

            }
            else
            {

                DialogResult result = MessageBox.Show("Spara nuvarande fil?", "Spara fil?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveFileDialog();
                }
                else if (result == DialogResult.No)
                {
                    OpenFileDialog openfile = new OpenFileDialog();

                    openfile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (openfile.ShowDialog() == DialogResult.OK)
                    {
                        textArea.Text = File.ReadAllText(openfile.FileName);
                        this.Text = openfile.SafeFileName;
                    }
                }

            }

            
           
           
           
        }

        private void ny_Click(object sender, EventArgs e)
        {
            if(textArea.TextLength == 0)
            {
                textArea.Text = "";
                this.Text = "dok1.txt";
                
            }
            else
            {
                DialogResult result = MessageBox.Show("Spara nuvarande fil?", "Spara fil?", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    saveFileDialog();
                }
                textArea.Text = "";
                this.Text = "dok1.txt";
                
            }
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            if(this.Text.Contains("*"))
            {
                DialogResult result = MessageBox.Show("Spara nuvarande fil?", "Spara fil?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveFileDialog();
                }
                else if (result == DialogResult.No)
                {
                    textArea.Text = "";
                    this.Text = "dok1.txt";
                }
                
                
            }
            else
                {
                
                textArea.Text = "";
                this.Text = "dok1.txt";
            }
        }
        
    }
}
