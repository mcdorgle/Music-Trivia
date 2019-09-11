namespace Music_Trivia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ScoresBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreDisplay = new System.Windows.Forms.ListView();
            this.Player1NameBox = new System.Windows.Forms.TextBox();
            this.Player6 = new System.Windows.Forms.Label();
            this.Player2NameBox = new System.Windows.Forms.TextBox();
            this.Player5 = new System.Windows.Forms.Label();
            this.Player3NameBox = new System.Windows.Forms.TextBox();
            this.Player4NameBox = new System.Windows.Forms.TextBox();
            this.Player4 = new System.Windows.Forms.Label();
            this.Player5NameBox = new System.Windows.Forms.TextBox();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player6NameBox = new System.Windows.Forms.TextBox();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.AddPointsButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.GroupBox();
            this.Player6PointsBox = new System.Windows.Forms.TextBox();
            this.Player5PointsBox = new System.Windows.Forms.TextBox();
            this.Player4PointsBox = new System.Windows.Forms.TextBox();
            this.Player3PointsBox = new System.Windows.Forms.TextBox();
            this.Player2PointsBox = new System.Windows.Forms.TextBox();
            this.Player1PointsBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SetNameButton = new System.Windows.Forms.Button();
            this.ScoresBox.SuspendLayout();
            this.AdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoresBox
            // 
            this.ScoresBox.Controls.Add(this.label1);
            this.ScoresBox.Controls.Add(this.ScoreDisplay);
            this.ScoresBox.Location = new System.Drawing.Point(61, 46);
            this.ScoresBox.Name = "ScoresBox";
            this.ScoresBox.Size = new System.Drawing.Size(626, 364);
            this.ScoresBox.TabIndex = 18;
            this.ScoresBox.TabStop = false;
            this.ScoresBox.Text = "ScoresBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Display Scores with the highest showing on top new score each line font size of 1" +
    "6";
            // 
            // ScoreDisplay
            // 
            this.ScoreDisplay.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ScoreDisplay.ForeColor = System.Drawing.Color.Chartreuse;
            this.ScoreDisplay.Location = new System.Drawing.Point(6, 19);
            this.ScoreDisplay.Name = "ScoreDisplay";
            this.ScoreDisplay.Size = new System.Drawing.Size(614, 339);
            this.ScoreDisplay.TabIndex = 0;
            this.ScoreDisplay.UseCompatibleStateImageBehavior = false;
            this.ScoreDisplay.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Player1NameBox
            // 
            this.Player1NameBox.Location = new System.Drawing.Point(81, 35);
            this.Player1NameBox.Name = "Player1NameBox";
            this.Player1NameBox.Size = new System.Drawing.Size(100, 20);
            this.Player1NameBox.TabIndex = 2;
            // 
            // Player6
            // 
            this.Player6.AutoSize = true;
            this.Player6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player6.Location = new System.Drawing.Point(6, 205);
            this.Player6.Name = "Player6";
            this.Player6.Size = new System.Drawing.Size(73, 20);
            this.Player6.TabIndex = 10;
            this.Player6.Text = "Player 6";
            // 
            // Player2NameBox
            // 
            this.Player2NameBox.Location = new System.Drawing.Point(81, 70);
            this.Player2NameBox.Name = "Player2NameBox";
            this.Player2NameBox.Size = new System.Drawing.Size(100, 20);
            this.Player2NameBox.TabIndex = 11;
            // 
            // Player5
            // 
            this.Player5.AutoSize = true;
            this.Player5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player5.Location = new System.Drawing.Point(6, 167);
            this.Player5.Name = "Player5";
            this.Player5.Size = new System.Drawing.Size(73, 20);
            this.Player5.TabIndex = 9;
            this.Player5.Text = "Player 5";
            // 
            // Player3NameBox
            // 
            this.Player3NameBox.Location = new System.Drawing.Point(81, 106);
            this.Player3NameBox.Name = "Player3NameBox";
            this.Player3NameBox.Size = new System.Drawing.Size(100, 20);
            this.Player3NameBox.TabIndex = 12;
            // 
            // Player4NameBox
            // 
            this.Player4NameBox.Location = new System.Drawing.Point(81, 140);
            this.Player4NameBox.Name = "Player4NameBox";
            this.Player4NameBox.Size = new System.Drawing.Size(100, 20);
            this.Player4NameBox.TabIndex = 13;
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4.Location = new System.Drawing.Point(6, 138);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(73, 20);
            this.Player4.TabIndex = 8;
            this.Player4.Text = "Player 4";
            // 
            // Player5NameBox
            // 
            this.Player5NameBox.Location = new System.Drawing.Point(81, 169);
            this.Player5NameBox.Name = "Player5NameBox";
            this.Player5NameBox.Size = new System.Drawing.Size(100, 20);
            this.Player5NameBox.TabIndex = 14;
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3.Location = new System.Drawing.Point(6, 102);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(73, 20);
            this.Player3.TabIndex = 7;
            this.Player3.Text = "Player 3";
            // 
            // Player6NameBox
            // 
            this.Player6NameBox.Location = new System.Drawing.Point(81, 207);
            this.Player6NameBox.Name = "Player6NameBox";
            this.Player6NameBox.Size = new System.Drawing.Size(100, 20);
            this.Player6NameBox.TabIndex = 15;
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.Location = new System.Drawing.Point(6, 66);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(73, 20);
            this.Player2.TabIndex = 6;
            this.Player2.Text = "Player 2";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(6, 33);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(73, 20);
            this.Player1.TabIndex = 5;
            this.Player1.Text = "Player 1";
            // 
            // AddPointsButton
            // 
            this.AddPointsButton.Location = new System.Drawing.Point(230, 233);
            this.AddPointsButton.Name = "AddPointsButton";
            this.AddPointsButton.Size = new System.Drawing.Size(75, 23);
            this.AddPointsButton.TabIndex = 16;
            this.AddPointsButton.Text = "Add Points";
            this.AddPointsButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(418, 78);
            this.label8.TabIndex = 2;
            this.label8.Text = resources.GetString("label8.Text");
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name";
            // 
            // AdminPanel
            // 
            this.AdminPanel.Controls.Add(this.Player6PointsBox);
            this.AdminPanel.Controls.Add(this.Player5PointsBox);
            this.AdminPanel.Controls.Add(this.Player4PointsBox);
            this.AdminPanel.Controls.Add(this.Player3PointsBox);
            this.AdminPanel.Controls.Add(this.Player2PointsBox);
            this.AdminPanel.Controls.Add(this.Player1PointsBox);
            this.AdminPanel.Controls.Add(this.label11);
            this.AdminPanel.Controls.Add(this.label10);
            this.AdminPanel.Controls.Add(this.label9);
            this.AdminPanel.Controls.Add(this.SetNameButton);
            this.AdminPanel.Controls.Add(this.AddPointsButton);
            this.AdminPanel.Controls.Add(this.Player1);
            this.AdminPanel.Controls.Add(this.Player2);
            this.AdminPanel.Controls.Add(this.Player6NameBox);
            this.AdminPanel.Controls.Add(this.Player3);
            this.AdminPanel.Controls.Add(this.Player5NameBox);
            this.AdminPanel.Controls.Add(this.Player4);
            this.AdminPanel.Controls.Add(this.Player4NameBox);
            this.AdminPanel.Controls.Add(this.Player3NameBox);
            this.AdminPanel.Controls.Add(this.Player5);
            this.AdminPanel.Controls.Add(this.Player2NameBox);
            this.AdminPanel.Controls.Add(this.Player6);
            this.AdminPanel.Controls.Add(this.Player1NameBox);
            this.AdminPanel.Location = new System.Drawing.Point(666, 416);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(334, 267);
            this.AdminPanel.TabIndex = 17;
            this.AdminPanel.TabStop = false;
            this.AdminPanel.Text = "Admin Panel";
            // 
            // Player6PointsBox
            // 
            this.Player6PointsBox.Location = new System.Drawing.Point(219, 207);
            this.Player6PointsBox.Name = "Player6PointsBox";
            this.Player6PointsBox.Size = new System.Drawing.Size(100, 20);
            this.Player6PointsBox.TabIndex = 24;
            // 
            // Player5PointsBox
            // 
            this.Player5PointsBox.Location = new System.Drawing.Point(219, 169);
            this.Player5PointsBox.Name = "Player5PointsBox";
            this.Player5PointsBox.Size = new System.Drawing.Size(100, 20);
            this.Player5PointsBox.TabIndex = 23;
            // 
            // Player4PointsBox
            // 
            this.Player4PointsBox.Location = new System.Drawing.Point(219, 140);
            this.Player4PointsBox.Name = "Player4PointsBox";
            this.Player4PointsBox.Size = new System.Drawing.Size(100, 20);
            this.Player4PointsBox.TabIndex = 22;
            // 
            // Player3PointsBox
            // 
            this.Player3PointsBox.Location = new System.Drawing.Point(219, 104);
            this.Player3PointsBox.Name = "Player3PointsBox";
            this.Player3PointsBox.Size = new System.Drawing.Size(100, 20);
            this.Player3PointsBox.TabIndex = 21;
            // 
            // Player2PointsBox
            // 
            this.Player2PointsBox.Location = new System.Drawing.Point(219, 68);
            this.Player2PointsBox.Name = "Player2PointsBox";
            this.Player2PointsBox.Size = new System.Drawing.Size(100, 20);
            this.Player2PointsBox.TabIndex = 20;
            // 
            // Player1PointsBox
            // 
            this.Player1PointsBox.Location = new System.Drawing.Point(219, 35);
            this.Player1PointsBox.Name = "Player1PointsBox";
            this.Player1PointsBox.Size = new System.Drawing.Size(100, 20);
            this.Player1PointsBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Add Points";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Set Name";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // SetNameButton
            // 
            this.SetNameButton.Location = new System.Drawing.Point(93, 233);
            this.SetNameButton.Name = "SetNameButton";
            this.SetNameButton.Size = new System.Drawing.Size(75, 23);
            this.SetNameButton.TabIndex = 16;
            this.SetNameButton.Text = "Set Name";
            this.SetNameButton.UseVisualStyleBackColor = true;
            this.SetNameButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 758);
            this.Controls.Add(this.ScoresBox);
            this.Controls.Add(this.AdminPanel);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ScoresBox.ResumeLayout(false);
            this.ScoresBox.PerformLayout();
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ScoresBox;
        private System.Windows.Forms.ListView ScoreDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Player1NameBox;
        private System.Windows.Forms.Label Player6;
        private System.Windows.Forms.TextBox Player2NameBox;
        private System.Windows.Forms.Label Player5;
        private System.Windows.Forms.TextBox Player3NameBox;
        private System.Windows.Forms.TextBox Player4NameBox;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.TextBox Player5NameBox;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.TextBox Player6NameBox;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Button AddPointsButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox AdminPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SetNameButton;
        private System.Windows.Forms.TextBox Player6PointsBox;
        private System.Windows.Forms.TextBox Player5PointsBox;
        private System.Windows.Forms.TextBox Player4PointsBox;
        private System.Windows.Forms.TextBox Player3PointsBox;
        private System.Windows.Forms.TextBox Player2PointsBox;
        private System.Windows.Forms.TextBox Player1PointsBox;
        private System.Windows.Forms.Label label11;
    }
}

