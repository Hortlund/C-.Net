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

/*
 * Andreas Hortlund 2020-03-06
 * 
 * 
 */

namespace Word_and_filehandeling
{
    public partial class Form1 : Form
    {


      // Funktion för att sätta ett * på ändrade dokument.
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
            //sätter titeln till ett default dokument namn.
            this.Text = "dok1.txt";

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            fileStatus.Text = "";
            //Räknar antalet tecken med och utan mellanslag
            charCount.Text = "Chars w space: " + textArea.Text.Length;
            charCount2.Text = "Chars w/0 space: " + ((textArea.Text.Length) - (textArea.Text.Split(' ').Length) +1);
            //Sätter tecken som ska räknas bort vid räkning av orden.
            char[] delim = new char[] { ' ', '\r', '\n' };
            wordCount.Text = "Words: " + textArea.Text.Split(delim, StringSplitOptions.RemoveEmptyEntries).Length;
            //Tecken för rader
            char[] delim2 = new char[] { '\r', '\n' };
            rowCount.Text = "Rows: " + textArea.Text.Split(delim2).Length;
            markName();


        }
        
        

        public void saveFileDialog()
        {
            //Skapar en ny save dialog
            SaveFileDialog savefile = new SaveFileDialog();
           //Sätter filter till default .txt och att man kan välja alla sorter.
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                //ifall användaren ok:ar så skrivs texten till filen och den sparas med anget namn.
                File.WriteAllText(savefile.FileName, textArea.Text);
                fileStatus.Text = "File saved!";
                this.Text = Path.GetFileName(savefile.FileName);
            }
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            //Kallar på spardialogen
            saveFileDialog();
        }

        //Håller i öppnade filens sökväg för "Spara" funktionen.
        string p;

        private void save_Click(object sender, EventArgs e)
        {
            //Tar titlen namnet till filnamnet.
            string fileName = this.Text;
            if (fileName.Contains("dok1.txt"))
            {
                //ifall filnamnet är default så spara som.
                saveFileDialog();
            }
            else if(fileName.Contains("*"))
            {
                //Ifall det är osparat så spara filen till den öppnade filens sökväg
                FileInfo filePath = new FileInfo(fileName.Remove(fileName.Length -1, 1));
                File.WriteAllText(p, textArea.Text);
                this.Text = this.Text.Remove(this.Text.Length - 1, 1);
                fileStatus.Text = "File saved!";
                
            }
            

        }


        private void open_Click(object sender, EventArgs e)
        {

            if (textArea.TextLength == 0)
            {
                //Ifall textarean är tom så öppnas en ny fil direkt och texten laddas till textarean.
                OpenFileDialog openfile = new OpenFileDialog();

                openfile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    textArea.Text = File.ReadAllText(openfile.FileName);
                    p = openfile.FileName;
                    this.Text = openfile.SafeFileName;
                }

            }
            else if(this.Text.Contains("*"))
            {
                //Ifall filen inte är spara så frågas användaren om detta
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
            else
            {
                //Om inget av de ovanstånde gäller så öppnas en ny vald fil direkt.
                OpenFileDialog openfile = new OpenFileDialog();

                openfile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    textArea.Text = File.ReadAllText(openfile.FileName);
                    this.Text = openfile.SafeFileName;
                }
            }

            
           
           
           
        }

        private void ny_Click(object sender, EventArgs e)
        {
            //Ifall texten är tom eller filnamnet inte innehåller * så skapas en ny skrivyta.
            if(textArea.TextLength == 0)
            {
                textArea.Text = "";
                this.Text = "dok1.txt";
                
            }
            else if(!(this.Text.Contains("*")))
            {
                textArea.Text = "";
                this.Text = "dok1.txt";
                
                
            }
            else
            {
                //Annars så ombeds användaren spara dokumentet.
                DialogResult result = MessageBox.Show("Spara nuvarande fil?", "Spara fil?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    saveFileDialog();
                }
                textArea.Text = "";
                this.Text = "dok1.txt";
            }
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            //Om filen inte är sparad så frågas användaren om att göra det. Och sedan så stängs dokumentet
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
                //Annars så töms alla fält.
                textArea.Text = "";
                this.Text = "dok1.txt";
            }
        }
        
    }
}
