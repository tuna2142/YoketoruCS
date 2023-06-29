namespace YoketoruCS
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            labelGameOver = new Label();
            buttonTitle = new Button();
            labelScore = new Label();
            labelHighScore = new Label();
            labelCopyright = new Label();
            labelTimer = new Label();
            labelClear = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(370, 162);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(205, 59);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(392, 252);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(160, 52);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート!!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelGameOver
            // 
            labelGameOver.AutoSize = true;
            labelGameOver.Font = new Font("Yu Gothic UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameOver.Location = new Point(353, 162);
            labelGameOver.Name = "labelGameOver";
            labelGameOver.Size = new Size(238, 59);
            labelGameOver.TabIndex = 2;
            labelGameOver.Text = "Game Over";
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(392, 281);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(160, 52);
            buttonTitle.TabIndex = 3;
            buttonTitle.Text = "タイトルへ";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttonTitle_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(420, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(105, 45);
            labelScore.TabIndex = 4;
            labelScore.Text = "00000";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelHighScore.Location = new Point(377, 54);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(191, 30);
            labelHighScore.TabIndex = 5;
            labelHighScore.Text = "High Score: 00000";
            labelHighScore.Click += labelHighScore_Click;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Font = new Font("Yu Gothic UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCopyright.Location = new Point(416, 473);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(112, 19);
            labelCopyright.TabIndex = 6;
            labelCopyright.Text = "(C) 2023 関岡 光";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(861, 447);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(71, 45);
            labelTimer.TabIndex = 7;
            labelTimer.Text = "000";
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Yu Gothic UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(400, 162);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(145, 59);
            labelClear.TabIndex = 8;
            labelClear.Text = "Clear!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(labelClear);
            Controls.Add(labelTimer);
            Controls.Add(labelCopyright);
            Controls.Add(labelHighScore);
            Controls.Add(labelScore);
            Controls.Add(buttonTitle);
            Controls.Add(labelGameOver);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Label labelGameOver;
        private Button buttonTitle;
        private Label labelScore;
        private Label labelHighScore;
        private Label labelCopyright;
        private Label labelTimer;
        private Label labelClear;
    }
}