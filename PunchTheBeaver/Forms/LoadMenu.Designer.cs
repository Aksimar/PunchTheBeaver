namespace PunchTheBeaver.Forms
{
    partial class LoadMenu
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
            this.Layer1 = new System.Windows.Forms.TableLayoutPanel();
            this.BackButtonLoadMenu = new System.Windows.Forms.Button();
            this.LoadsTable = new System.Windows.Forms.TableLayoutPanel();
            this.HeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.Difficulty = new System.Windows.Forms.Label();
            this.SaveTime = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.SavesScrolablePanel = new System.Windows.Forms.Panel();
            this.SavesTable = new System.Windows.Forms.TableLayoutPanel();
            this.LoadMenuName = new System.Windows.Forms.Label();
            this.Layer1.SuspendLayout();
            this.LoadsTable.SuspendLayout();
            this.HeaderTable.SuspendLayout();
            this.SavesScrolablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layer1
            // 
            this.Layer1.ColumnCount = 1;
            this.Layer1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1084F));
            this.Layer1.Controls.Add(this.BackButtonLoadMenu, 0, 2);
            this.Layer1.Controls.Add(this.LoadsTable, 0, 1);
            this.Layer1.Controls.Add(this.LoadMenuName, 0, 0);
            this.Layer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layer1.Location = new System.Drawing.Point(0, 0);
            this.Layer1.Name = "Layer1";
            this.Layer1.RowCount = 3;
            this.Layer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Layer1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Layer1.Size = new System.Drawing.Size(1084, 961);
            this.Layer1.TabIndex = 0;
            // 
            // BackButtonLoadMenu
            // 
            this.BackButtonLoadMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackButtonLoadMenu.Location = new System.Drawing.Point(384, 860);
            this.BackButtonLoadMenu.Name = "BackButtonLoadMenu";
            this.BackButtonLoadMenu.Size = new System.Drawing.Size(316, 56);
            this.BackButtonLoadMenu.TabIndex = 1;
            this.BackButtonLoadMenu.Text = "Back";
            this.BackButtonLoadMenu.UseVisualStyleBackColor = true;
            this.BackButtonLoadMenu.Click += new System.EventHandler(this.BackButtonLoadMenu_Click);
            // 
            // LoadsTable
            // 
            this.LoadsTable.ColumnCount = 1;
            this.LoadsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LoadsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LoadsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LoadsTable.Controls.Add(this.HeaderTable, 0, 0);
            this.LoadsTable.Controls.Add(this.SavesScrolablePanel, 0, 1);
            this.LoadsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadsTable.Location = new System.Drawing.Point(3, 147);
            this.LoadsTable.Name = "LoadsTable";
            this.LoadsTable.RowCount = 2;
            this.LoadsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.54219F));
            this.LoadsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.45781F));
            this.LoadsTable.Size = new System.Drawing.Size(1078, 666);
            this.LoadsTable.TabIndex = 3;
            // 
            // HeaderTable
            // 
            this.HeaderTable.ColumnCount = 3;
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.HeaderTable.Controls.Add(this.Difficulty, 0, 0);
            this.HeaderTable.Controls.Add(this.SaveTime, 2, 0);
            this.HeaderTable.Controls.Add(this.Score, 1, 0);
            this.HeaderTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderTable.Location = new System.Drawing.Point(3, 3);
            this.HeaderTable.Name = "HeaderTable";
            this.HeaderTable.RowCount = 1;
            this.HeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.HeaderTable.Size = new System.Drawing.Size(1074, 90);
            this.HeaderTable.TabIndex = 0;
            // 
            // Difficulty
            // 
            this.Difficulty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Difficulty.AutoSize = true;
            this.Difficulty.CausesValidation = false;
            this.Difficulty.Cursor = System.Windows.Forms.Cursors.Default;
            this.Difficulty.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.Difficulty.ForeColor = System.Drawing.Color.White;
            this.Difficulty.Location = new System.Drawing.Point(3, 28);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(208, 33);
            this.Difficulty.TabIndex = 0;
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveTime
            // 
            this.SaveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTime.AutoSize = true;
            this.SaveTime.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.SaveTime.ForeColor = System.Drawing.Color.White;
            this.SaveTime.Location = new System.Drawing.Point(485, 28);
            this.SaveTime.Name = "SaveTime";
            this.SaveTime.Size = new System.Drawing.Size(586, 33);
            this.SaveTime.TabIndex = 2;
            this.SaveTime.Text = "Time";
            this.SaveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            this.Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(217, 28);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(262, 33);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavesScrolablePanel
            // 
            this.SavesScrolablePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SavesScrolablePanel.AutoScroll = true;
            this.SavesScrolablePanel.Controls.Add(this.SavesTable);
            this.SavesScrolablePanel.Font = new System.Drawing.Font("Showcard Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavesScrolablePanel.Location = new System.Drawing.Point(3, 99);
            this.SavesScrolablePanel.Name = "SavesScrolablePanel";
            this.SavesScrolablePanel.Size = new System.Drawing.Size(1074, 564);
            this.SavesScrolablePanel.TabIndex = 1;
            // 
            // SavesTable
            // 
            this.SavesTable.AutoSize = true;
            this.SavesTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SavesTable.ColumnCount = 3;
            this.SavesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SavesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.SavesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SavesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.SavesTable.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavesTable.Location = new System.Drawing.Point(0, 0);
            this.SavesTable.Name = "SavesTable";
            this.SavesTable.RowCount = 1;
            this.SavesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.SavesTable.Size = new System.Drawing.Size(1074, 50);
            this.SavesTable.TabIndex = 0;
            // 
            // LoadMenuName
            // 
            this.LoadMenuName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadMenuName.AutoSize = true;
            this.LoadMenuName.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadMenuName.ForeColor = System.Drawing.Color.White;
            this.LoadMenuName.Location = new System.Drawing.Point(458, 42);
            this.LoadMenuName.Name = "LoadMenuName";
            this.LoadMenuName.Size = new System.Drawing.Size(168, 60);
            this.LoadMenuName.TabIndex = 4;
            this.LoadMenuName.Text = "SAVES";
            this.LoadMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 961);
            this.Controls.Add(this.Layer1);
            this.Name = "LoadMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Layer1.ResumeLayout(false);
            this.Layer1.PerformLayout();
            this.LoadsTable.ResumeLayout(false);
            this.HeaderTable.ResumeLayout(false);
            this.HeaderTable.PerformLayout();
            this.SavesScrolablePanel.ResumeLayout(false);
            this.SavesScrolablePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layer1;
        private System.Windows.Forms.Button BackButtonLoadMenu;
        private System.Windows.Forms.TableLayoutPanel LoadsTable;
        private System.Windows.Forms.Label LoadMenuName;
        private System.Windows.Forms.TableLayoutPanel HeaderTable;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label SaveTime;
        private System.Windows.Forms.Panel SavesScrolablePanel;
        private System.Windows.Forms.TableLayoutPanel SavesTable;
    }
}