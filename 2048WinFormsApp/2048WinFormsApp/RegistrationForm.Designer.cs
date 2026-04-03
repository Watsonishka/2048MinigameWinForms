namespace _2048WinFormsApp
{
    partial class RegistrationForm
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
            greetingsLabel = new Label();
            ruleLabel = new Label();
            userNameTextBox = new TextBox();
            nextButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // greetingsLabel
            // 
            greetingsLabel.AutoSize = true;
            greetingsLabel.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            greetingsLabel.Location = new Point(82, 31);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new Size(144, 32);
            greetingsLabel.TabIndex = 0;
            greetingsLabel.Text = "Игра 2048";
            // 
            // ruleLabel
            // 
            ruleLabel.AutoSize = true;
            ruleLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ruleLabel.Location = new Point(73, 75);
            ruleLabel.Name = "ruleLabel";
            ruleLabel.Size = new Size(169, 24);
            ruleLabel.TabIndex = 1;
            ruleLabel.Text = "Введи свое имя!";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(35, 124);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(235, 23);
            userNameTextBox.TabIndex = 2;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(94, 240);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(114, 40);
            nextButton.TabIndex = 3;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(35, 158);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(235, 70);
            errorLabel.TabIndex = 4;
            errorLabel.Text = "Ошибка";
            errorLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 320);
            Controls.Add(errorLabel);
            Controls.Add(nextButton);
            Controls.Add(userNameTextBox);
            Controls.Add(ruleLabel);
            Controls.Add(greetingsLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegistrationForm";
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greetingsLabel;
        private Label ruleLabel;
        private TextBox userNameTextBox;
        private Button nextButton;
        private Label errorLabel;
    }
}