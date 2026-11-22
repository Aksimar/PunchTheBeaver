namespace PunchTheBeaver.Forms
{
    partial class HighScoresPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Back_button = new System.Windows.Forms.Button();
            this.HighScorsLable = new System.Windows.Forms.Label();
            this.ScorsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.57394F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.85212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.57395F));
            this.tableLayoutPanel1.Controls.Add(this.Back_button, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.HighScorsLable, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ScorsPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 961);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Back_button
            // 
            this.Back_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Back_button.Location = new System.Drawing.Point(504, 877);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HighScorsLable
            // 
            this.HighScorsLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HighScorsLable.Font = new System.Drawing.Font("Showcard Gothic", 8.25F);
            this.HighScorsLable.Location = new System.Drawing.Point(226, 0);
            this.HighScorsLable.Name = "HighScorsLable";
            this.HighScorsLable.Size = new System.Drawing.Size(631, 144);
            this.HighScorsLable.TabIndex = 1;
            this.HighScorsLable.Text = "HighScors";
            this.HighScorsLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HighScorsLable.Resize += new System.EventHandler(this.LabelScore_Resize);
            // 
            // ScorsPanel
            // 
            this.ScorsPanel.AutoScroll = true;
            this.ScorsPanel.ColumnCount = 2;
            this.ScorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ScorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ScorsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScorsPanel.Location = new System.Drawing.Point(226, 147);
            this.ScorsPanel.Name = "ScorsPanel";
            this.ScorsPanel.RowCount = 1;
            this.ScorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScorsPanel.Size = new System.Drawing.Size(631, 666);
            this.ScorsPanel.TabIndex = 2;
            // 
            // HighScoresPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 961);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HighScoresPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HighScoresPage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label HighScorsLable;
        private System.Windows.Forms.TableLayoutPanel ScorsPanel;
    }
}