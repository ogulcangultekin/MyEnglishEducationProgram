
namespace UserInterface
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addVocubaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allVocabularyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vocabularyList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVocubaToolStripMenuItem,
            this.allVocabularyListToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addVocubaToolStripMenuItem
            // 
            this.addVocubaToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F);
            this.addVocubaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.addVocubaToolStripMenuItem.Name = "addVocubaToolStripMenuItem";
            this.addVocubaToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.addVocubaToolStripMenuItem.Text = "Add Vocabulary ";
            this.addVocubaToolStripMenuItem.Click += new System.EventHandler(this.addVocubaToolStripMenuItem_Click);
            // 
            // allVocabularyListToolStripMenuItem
            // 
            this.allVocabularyListToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F);
            this.allVocabularyListToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.allVocabularyListToolStripMenuItem.Name = "allVocabularyListToolStripMenuItem";
            this.allVocabularyListToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.allVocabularyListToolStripMenuItem.Text = "All Vocabulary List";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 24);
            this.toolStripMenuItem1.Text = "Exercise";
            // 
            // vocabularyList
            // 
            this.vocabularyList.BackgroundColor = System.Drawing.Color.Cyan;
            this.vocabularyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vocabularyList.Location = new System.Drawing.Point(0, 31);
            this.vocabularyList.Name = "vocabularyList";
            this.vocabularyList.ReadOnly = true;
            this.vocabularyList.RowHeadersWidth = 51;
            this.vocabularyList.RowTemplate.Height = 24;
            this.vocabularyList.Size = new System.Drawing.Size(477, 358);
            this.vocabularyList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(706, 395);
            this.Controls.Add(this.vocabularyList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vocabularyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addVocubaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allVocabularyListToolStripMenuItem;
        private System.Windows.Forms.DataGridView vocabularyList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

