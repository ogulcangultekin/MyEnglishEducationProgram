
namespace UserInterface
{
    partial class ExercisePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtTurengLink = new System.Windows.Forms.Label();
            this.linkLblTureng = new System.Windows.Forms.LinkLabel();
            this.btnRandomQuestion = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(31, 50);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(100, 28);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblAnswer.Location = new System.Drawing.Point(315, 50);
            this.lblAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(84, 28);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "Answer:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Enabled = false;
            this.txtQuestion.ForeColor = System.Drawing.Color.Red;
            this.txtQuestion.Location = new System.Drawing.Point(138, 47);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(170, 34);
            this.txtQuestion.TabIndex = 2;
            // 
            // txtAnswer
            // 
            this.txtAnswer.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtAnswer.Location = new System.Drawing.Point(406, 47);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(170, 34);
            this.txtAnswer.TabIndex = 3;
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // txtTurengLink
            // 
            this.txtTurengLink.AutoSize = true;
            this.txtTurengLink.Location = new System.Drawing.Point(31, 114);
            this.txtTurengLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTurengLink.Name = "txtTurengLink";
            this.txtTurengLink.Size = new System.Drawing.Size(80, 28);
            this.txtTurengLink.TabIndex = 4;
            this.txtTurengLink.Text = "Tureng:";
            // 
            // linkLblTureng
            // 
            this.linkLblTureng.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.linkLblTureng.AutoSize = true;
            this.linkLblTureng.Location = new System.Drawing.Point(107, 114);
            this.linkLblTureng.Name = "linkLblTureng";
            this.linkLblTureng.Size = new System.Drawing.Size(101, 28);
            this.linkLblTureng.TabIndex = 5;
            this.linkLblTureng.TabStop = true;
            this.linkLblTureng.Text = "linkLabel1";
            this.linkLblTureng.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblTureng_LinkClicked);
            // 
            // btnRandomQuestion
            // 
            this.btnRandomQuestion.BackColor = System.Drawing.Color.LightPink;
            this.btnRandomQuestion.Location = new System.Drawing.Point(595, 95);
            this.btnRandomQuestion.Name = "btnRandomQuestion";
            this.btnRandomQuestion.Size = new System.Drawing.Size(111, 47);
            this.btnRandomQuestion.TabIndex = 6;
            this.btnRandomQuestion.Text = "Try";
            this.btnRandomQuestion.UseVisualStyleBackColor = false;
            this.btnRandomQuestion.Click += new System.EventHandler(this.btnRandomQuestion_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Lime;
            this.btnCheck.Location = new System.Drawing.Point(595, 41);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(111, 47);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(31, 0);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(67, 28);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "Count";
            // 
            // ExercisePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(745, 277);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnRandomQuestion);
            this.Controls.Add(this.linkLblTureng);
            this.Controls.Add(this.txtTurengLink);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.SlateBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExercisePage";
            this.Text = "ExercisePage";
            this.Load += new System.EventHandler(this.ExercisePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label txtTurengLink;
        private System.Windows.Forms.LinkLabel linkLblTureng;
        private System.Windows.Forms.Button btnRandomQuestion;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCount;
    }
}