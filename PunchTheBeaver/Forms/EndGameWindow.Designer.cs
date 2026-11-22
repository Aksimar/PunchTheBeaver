namespace PunchTheBeaver.Forms
{
    partial class EndGameWindow
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
            this.ExiteButton = new System.Windows.Forms.Button();
            this.ScoreLablePanel = new System.Windows.Forms.Panel();
            this.LabelScore = new System.Windows.Forms.Label();
            this.EndGamePict = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.ScoreLablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndGamePict)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ExiteButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ScoreLablePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EndGamePict, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 961);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ExiteButton
            // 
            this.ExiteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExiteButton.Location = new System.Drawing.Point(504, 789);
            this.ExiteButton.Name = "ExiteButton";
            this.ExiteButton.Size = new System.Drawing.Size(75, 23);
            this.ExiteButton.TabIndex = 2;
            this.ExiteButton.Text = "Exite";
            this.ExiteButton.UseVisualStyleBackColor = true;
            this.ExiteButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ScoreLablePanel
            // 
            this.ScoreLablePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoreLablePanel.Controls.Add(this.LabelScore);
            this.ScoreLablePanel.Location = new System.Drawing.Point(294, 83);
            this.ScoreLablePanel.Name = "ScoreLablePanel";
            this.ScoreLablePanel.Size = new System.Drawing.Size(495, 153);
            this.ScoreLablePanel.TabIndex = 4;
            // 
            // LabelScore
            // 
            this.LabelScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelScore.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.LabelScore.ForeColor = System.Drawing.Color.Red;
            this.LabelScore.Location = new System.Drawing.Point(0, 0);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(495, 153);
            this.LabelScore.TabIndex = 0;
            this.LabelScore.Text = "label1";
            this.LabelScore.Resize += new System.EventHandler(this.LabelScore_Resize);
            // 
            // EndGamePict
            // 
            this.EndGamePict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndGamePict.Location = new System.Drawing.Point(0, 320);
            this.EndGamePict.Margin = new System.Windows.Forms.Padding(0);
            this.EndGamePict.Name = "EndGamePict";
            this.EndGamePict.Size = new System.Drawing.Size(1084, 320);
            this.EndGamePict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndGamePict.TabIndex = 5;
            this.EndGamePict.TabStop = false;
            // 
            // EndGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 961);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EndGameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EndGameWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ScoreLablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EndGamePict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ExiteButton;
        private System.Windows.Forms.Panel ScoreLablePanel;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.PictureBox EndGamePict;
    }
}