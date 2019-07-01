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

namespace SharpForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Folder_Create();
        }

        private void Folder_Create() {
            // Specify the directory you want to manipulate.
            string path = @"c:\MyDir\a" + textBox1.Text + textBox2.Text;

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    _ = MessageBox.Show("That path exists already.", "Error", MessageBoxButtons.OK);
                    //Console.WriteLine("That path exists already.");
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                _ = MessageBox.Show("The directory was created successfully at "+ Directory.GetCreationTime(path)+".", "Complete", MessageBoxButtons.OK);
                //Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception a)
            {
                _ = MessageBox.Show("The process failed: "+a, "Mission Failed", MessageBoxButtons.OK);
                //Console.WriteLine("The process failed: {0}", a.ToString());
            }
            finally { }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
