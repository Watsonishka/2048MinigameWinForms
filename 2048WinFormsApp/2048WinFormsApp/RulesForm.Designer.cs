namespace _2048WinFormsApp
{
    partial class RulesForm
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
            label1 = new Label();
            goalLabel = new Label();
            label2 = new Label();
            ruleLabel = new Label();
            label3 = new Label();
            endGameLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.Location = new Point(137, 25);
            label1.Name = "label1";
            label1.Size = new Size(119, 22);
            label1.TabIndex = 0;
            label1.Text = "Цель игры:";
            // 
            // goalLabel
            // 
            goalLabel.Font = new Font("Arial", 9F);
            goalLabel.Location = new Point(12, 57);
            goalLabel.Name = "goalLabel";
            goalLabel.Size = new Size(360, 32);
            goalLabel.TabIndex = 1;
            goalLabel.Text = "Собрать плитку со значением 2048 (или выше), объединяя одинаковые числа.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold);
            label2.Location = new Point(137, 106);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 2;
            label2.Text = "Как играть:";
            // 
            // ruleLabel
            // 
            ruleLabel.Font = new Font("Arial", 9F);
            ruleLabel.Location = new Point(12, 142);
            ruleLabel.Name = "ruleLabel";
            ruleLabel.Size = new Size(360, 257);
            ruleLabel.TabIndex = 3;
            ruleLabel.Text = "Текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold);
            label3.Location = new Point(71, 399);
            label3.Name = "label3";
            label3.Size = new Size(257, 22);
            label3.TabIndex = 4;
            label3.Text = "Условия окончания игры:";
            // 
            // endGameLabel
            // 
            endGameLabel.Font = new Font("Arial", 9F);
            endGameLabel.Location = new Point(14, 430);
            endGameLabel.Name = "endGameLabel";
            endGameLabel.Size = new Size(360, 76);
            endGameLabel.TabIndex = 6;
            endGameLabel.Text = "Текст";
            // 
            // backButton
            // 
            backButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            backButton.Location = new Point(112, 518);
            backButton.Name = "backButton";
            backButton.Size = new Size(155, 35);
            backButton.TabIndex = 7;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // RulesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 587);
            Controls.Add(backButton);
            Controls.Add(endGameLabel);
            Controls.Add(label3);
            Controls.Add(ruleLabel);
            Controls.Add(label2);
            Controls.Add(goalLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RulesForm";
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Правила игры 2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label goalLabel;
        private Label label2;
        private Label ruleLabel;
        private Label label3;
        private Label endGameLabel;
        private Button backButton;
    }
}