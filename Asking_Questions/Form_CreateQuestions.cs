using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Asking_Questions
{
    public partial class Form_CreateQuestions : Form
    {
        readonly List<string> questions = new List<string>();

        public Form_CreateQuestions()
        {
            InitializeComponent();

            saveFileQuestions.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileQuestions.FileName = "New_Questions.txt";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAddQuestion_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("The question cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                questions.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void ButtonSaveQuestion_Click(object sender, EventArgs e)
        {

            saveFileQuestions.ShowDialog();
            string path;
            path = saveFileQuestions.FileName;

            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                foreach (var item in questions)
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes($"{item}\n");
                    fstream.Write(array, 0, array.Length);
                }
            }

            Form_Main.Path = path;

            Close();

        }
    }
}
