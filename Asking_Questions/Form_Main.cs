using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace Asking_Questions
{
    public partial class Form_Main : Form
    {
        private int Count_Question;
        public static string Path;

        public static List<string> questions = new List<string>();

        public Form_Main()
        {
            InitializeComponent();
            openFileQuestions.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileQuestions.FileName = "Questions.txt";
        }

        public void CountLoadQuestion()
        {
            Count_Load_Question.Text = $"Questions Load: {questions.Count}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CountLoadQuestion();
        }

        private void ButtonLoadQuestions_Click(object sender, EventArgs e)
        {
            openFileQuestions.ShowDialog();
            Path = openFileQuestions.FileName;

            try
            {
                using StreamReader sr = new StreamReader(Path, System.Text.Encoding.Default);
                string line;

                questions.Clear();

                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(line);
                }
            }
            catch (Exception)
            {

            }
            CountLoadQuestion();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (Path == null || questions.Count == 0)
            {
                MessageBox.Show("Upload questions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Random rnd = new Random();
                int indexEnd = questions.Count - 1;

                for (int i = 0; i <= indexEnd; indexEnd--)
                {
                    Count_Question++;
                    int index = rnd.Next(0, indexEnd);

                    if (questions.Count == 1)
                    {
                        index = 0;
                    }

                    MessageBox.Show(questions[index], $"Question #: {Count_Question} | Questions left: {questions.Count}", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    questions.RemoveAt(index);
                }
            }
            CountLoadQuestion();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Count_Question = 0;
            CountLoadQuestion();
        }

        private void ButtonCreateQuestions_Click(object sender, EventArgs e)
        {
            Form_CreateQuestions form_CreateQuestions = new Form_CreateQuestions();
            form_CreateQuestions.ShowDialog();
            CountLoadQuestion();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Each question should be seperate on a new line without blank lines", "How to use");
        }
    }
}
