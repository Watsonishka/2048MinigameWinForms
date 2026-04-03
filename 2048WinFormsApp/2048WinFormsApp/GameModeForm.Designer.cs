namespace _2048WinFormsApp
{
    partial class GameModeForm
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
            size4Label = new Label();
            size5Label = new Label();
            size7Label = new Label();
            size6Label = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.Location = new Point(61, 28);
            label1.Name = "label1";
            label1.Size = new Size(216, 22);
            label1.TabIndex = 9;
            label1.Text = "Выбери размер поля!";
            // 
            // size4Label
            // 
            size4Label.BackColor = SystemColors.ActiveCaption;
            size4Label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            size4Label.Location = new Point(89, 73);
            size4Label.Name = "size4Label";
            size4Label.Size = new Size(70, 70);
            size4Label.TabIndex = 10;
            size4Label.Text = "4 x 4";
            size4Label.TextAlign = ContentAlignment.MiddleCenter;
            size4Label.Click += size4Label_Click;
            // 
            // size5Label
            // 
            size5Label.BackColor = SystemColors.ActiveCaption;
            size5Label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            size5Label.Location = new Point(182, 73);
            size5Label.Name = "size5Label";
            size5Label.Size = new Size(70, 70);
            size5Label.TabIndex = 11;
            size5Label.Text = "5 х 5";
            size5Label.TextAlign = ContentAlignment.MiddleCenter;
            size5Label.Click += size5Label_Click;
            // 
            // size7Label
            // 
            size7Label.BackColor = SystemColors.ActiveCaption;
            size7Label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            size7Label.Location = new Point(182, 159);
            size7Label.Name = "size7Label";
            size7Label.Size = new Size(70, 70);
            size7Label.TabIndex = 13;
            size7Label.Text = "7 х 7";
            size7Label.TextAlign = ContentAlignment.MiddleCenter;
            size7Label.Click += size7Label_Click;
            // 
            // size6Label
            // 
            size6Label.BackColor = SystemColors.ActiveCaption;
            size6Label.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            size6Label.Location = new Point(89, 159);
            size6Label.Name = "size6Label";
            size6Label.Size = new Size(70, 70);
            size6Label.TabIndex = 12;
            size6Label.Text = "6 x 6";
            size6Label.TextAlign = ContentAlignment.MiddleCenter;
            size6Label.Click += size6Label_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Arial Narrow", 10.75F);
            label2.Location = new Point(29, 245);
            label2.Name = "label2";
            label2.Size = new Size(280, 46);
            label2.TabIndex = 14;
            label2.Text = "Примечание: если ты нажмешь на \"Крестик\", то по умолчанию выберется размер поля 5 х 5!";
            // 
            // GameModeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 311);
            Controls.Add(label2);
            Controls.Add(size7Label);
            Controls.Add(size6Label);
            Controls.Add(size5Label);
            Controls.Add(size4Label);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameModeForm";
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра 2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label size4Label;
        private Label size5Label;
        private Label size7Label;
        private Label size6Label;
        private Label label2;
    }
}