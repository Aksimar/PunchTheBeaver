namespace PunchTheBeaver.Forms
{
    partial class Pause_menu
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
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.ExitFromTheGameButton = new System.Windows.Forms.Button();
            this.ExiteToMenuButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LoadGameButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveGameButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ExitFromTheGameButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ExiteToMenuButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 961);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadGameButton.BackColor = System.Drawing.Color.White;
            this.LoadGameButton.FlatAppearance.BorderSize = 5;
            this.LoadGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.LoadGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadGameButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.LoadGameButton.ForeColor = System.Drawing.Color.Black;
            this.LoadGameButton.Location = new System.Drawing.Point(342, 45);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(400, 150);
            this.LoadGameButton.TabIndex = 4;
            this.LoadGameButton.Text = "Load Game";
            this.LoadGameButton.UseVisualStyleBackColor = false;
            this.LoadGameButton.Click += new System.EventHandler(this.LoadGameButton_Click);
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveGameButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.SaveGameButton.Location = new System.Drawing.Point(342, 285);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(400, 150);
            this.SaveGameButton.TabIndex = 3;
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // ExitFromTheGameButton
            // 
            this.ExitFromTheGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitFromTheGameButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.ExitFromTheGameButton.Location = new System.Drawing.Point(342, 765);
            this.ExitFromTheGameButton.Name = "ExitFromTheGameButton";
            this.ExitFromTheGameButton.Size = new System.Drawing.Size(400, 150);
            this.ExitFromTheGameButton.TabIndex = 3;
            this.ExitFromTheGameButton.Text = "Exit";
            this.ExitFromTheGameButton.UseVisualStyleBackColor = true;
            this.ExitFromTheGameButton.Click += new System.EventHandler(this.ExitFromTheGameButton_Click);
            // 
            // ExiteToMenuButton
            // 
            this.ExiteToMenuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExiteToMenuButton.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.ExiteToMenuButton.Location = new System.Drawing.Point(342, 525);
            this.ExiteToMenuButton.Name = "ExiteToMenuButton";
            this.ExiteToMenuButton.Size = new System.Drawing.Size(400, 150);
            this.ExiteToMenuButton.TabIndex = 5;
            this.ExiteToMenuButton.Text = "Exite to Menu";
            this.ExiteToMenuButton.UseVisualStyleBackColor = true;
            this.ExiteToMenuButton.Click += new System.EventHandler(this.ExiteToMenuButton_Click);
            // 
            // Pause_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 961);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Pause_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pause_menu";
            this.Click += new System.EventHandler(this.LoadGameButton_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.Button SaveGameButton;
        private System.Windows.Forms.Button ExitFromTheGameButton;
        private System.Windows.Forms.Button ExiteToMenuButton;
    }
}