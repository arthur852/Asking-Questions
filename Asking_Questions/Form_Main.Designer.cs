
namespace Asking_Questions
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.Start = new System.Windows.Forms.Button();
            this.Load_Questions = new System.Windows.Forms.Button();
            this.Create_Question = new System.Windows.Forms.Button();
            this.openFileQuestions = new System.Windows.Forms.OpenFileDialog();
            this.Count_Load_Question = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start
            // 
            resources.ApplyResources(this.Start, "Start");
            this.Start.Name = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Load_Questions
            // 
            resources.ApplyResources(this.Load_Questions, "Load_Questions");
            this.Load_Questions.Name = "Load_Questions";
            this.Load_Questions.UseVisualStyleBackColor = true;
            this.Load_Questions.Click += new System.EventHandler(this.ButtonLoadQuestions_Click);
            // 
            // Create_Question
            // 
            resources.ApplyResources(this.Create_Question, "Create_Question");
            this.Create_Question.Name = "Create_Question";
            this.Create_Question.UseVisualStyleBackColor = true;
            this.Create_Question.Click += new System.EventHandler(this.ButtonCreateQuestions_Click);
            // 
            // openFileQuestions
            // 
            this.openFileQuestions.FileName = "openFileQuestions";
            resources.ApplyResources(this.openFileQuestions, "openFileQuestions");
            // 
            // Count_Load_Question
            // 
            resources.ApplyResources(this.Count_Load_Question, "Count_Load_Question");
            this.Count_Load_Question.Name = "Count_Load_Question";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // Form_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Count_Load_Question);
            this.Controls.Add(this.Create_Question);
            this.Controls.Add(this.Load_Questions);
            this.Controls.Add(this.Start);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Load_Questions;
        private System.Windows.Forms.Button Create_Question;
        private System.Windows.Forms.OpenFileDialog openFileQuestions;
        private System.Windows.Forms.Label Count_Load_Question;
        private System.Windows.Forms.Button button1;
    }
}

