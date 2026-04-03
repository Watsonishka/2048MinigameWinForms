namespace _2048WinFormsApp
{
    partial class MainForm
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
            scoreLabel = new Label();
            recordLabel = new Label();
            userNameLabel = new Label();
            menuStrip1 = new MenuStrip();
            MenuToolStripMenuItem = new ToolStripMenuItem();
            рестToolStripMenuItem = new ToolStripMenuItem();
            рестартToolStripMenuItem = new ToolStripMenuItem();
            правилаToolStripMenuItem = new ToolStripMenuItem();
            rulesToolStripMenuItem = new ToolStripMenuItem();
            предыдущиеИгрыToolStripMenuItem = new ToolStripMenuItem();
            gameTableToolStripMenuItem = new ToolStripMenuItem();
            gameModeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Arial", 16F);
            scoreLabel.Location = new Point(12, 39);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(84, 25);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Счет: 0";
            // 
            // recordLabel
            // 
            recordLabel.AutoSize = true;
            recordLabel.Font = new Font("Arial", 16F);
            recordLabel.Location = new Point(211, 39);
            recordLabel.Name = "recordLabel";
            recordLabel.Size = new Size(109, 25);
            recordLabel.TabIndex = 2;
            recordLabel.Text = "Рекорд: 0";
            // 
            // userNameLabel
            // 
            userNameLabel.BackColor = SystemColors.Control;
            userNameLabel.Font = new Font("Arial", 16F);
            userNameLabel.Location = new Point(12, 83);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(372, 60);
            userNameLabel.TabIndex = 3;
            userNameLabel.Text = "Игрок: Имя";
            userNameLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuToolStripMenuItem, правилаToolStripMenuItem, предыдущиеИгрыToolStripMenuItem, gameModeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(396, 25);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            MenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { рестToolStripMenuItem, рестартToolStripMenuItem });
            MenuToolStripMenuItem.Font = new Font("Arial", 11F);
            MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            MenuToolStripMenuItem.Size = new Size(58, 21);
            MenuToolStripMenuItem.Text = "Меню";
            // 
            // рестToolStripMenuItem
            // 
            рестToolStripMenuItem.Name = "рестToolStripMenuItem";
            рестToolStripMenuItem.Size = new Size(131, 22);
            рестToolStripMenuItem.Text = "Рестарт";
            рестToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // рестартToolStripMenuItem
            // 
            рестартToolStripMenuItem.Name = "рестартToolStripMenuItem";
            рестартToolStripMenuItem.Size = new Size(131, 22);
            рестартToolStripMenuItem.Text = "Выход";
            рестартToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // правилаToolStripMenuItem
            // 
            правилаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rulesToolStripMenuItem });
            правилаToolStripMenuItem.Font = new Font("Arial", 11F);
            правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            правилаToolStripMenuItem.Size = new Size(78, 21);
            правилаToolStripMenuItem.Text = "Правила";
            // 
            // rulesToolStripMenuItem
            // 
            rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            rulesToolStripMenuItem.Size = new Size(170, 22);
            rulesToolStripMenuItem.Text = "Правила игры";
            rulesToolStripMenuItem.Click += rulesToolStripMenuItem_Click;
            // 
            // предыдущиеИгрыToolStripMenuItem
            // 
            предыдущиеИгрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gameTableToolStripMenuItem });
            предыдущиеИгрыToolStripMenuItem.Font = new Font("Arial", 11F);
            предыдущиеИгрыToolStripMenuItem.Name = "предыдущиеИгрыToolStripMenuItem";
            предыдущиеИгрыToolStripMenuItem.Size = new Size(145, 21);
            предыдущиеИгрыToolStripMenuItem.Text = "Предыдущие игры";
            // 
            // gameTableToolStripMenuItem
            // 
            gameTableToolStripMenuItem.Name = "gameTableToolStripMenuItem";
            gameTableToolStripMenuItem.Size = new Size(202, 22);
            gameTableToolStripMenuItem.Text = "Смотреть таблицу";
            gameTableToolStripMenuItem.Click += gameTableToolStripMenuItem_Click;
            // 
            // gameModeToolStripMenuItem
            // 
            gameModeToolStripMenuItem.Font = new Font("Arial", 11F);
            gameModeToolStripMenuItem.Name = "gameModeToolStripMenuItem";
            gameModeToolStripMenuItem.Size = new Size(64, 21);
            gameModeToolStripMenuItem.Text = "Режим";
            gameModeToolStripMenuItem.Click += gameModeToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 587);
            Controls.Add(userNameLabel);
            Controls.Add(recordLabel);
            Controls.Add(scoreLabel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Игра 2048";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private Label recordLabel;
        private Label userNameLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuToolStripMenuItem;
        private ToolStripMenuItem правилаToolStripMenuItem;
        private ToolStripMenuItem предыдущиеИгрыToolStripMenuItem;
        private ToolStripMenuItem рестToolStripMenuItem;
        private ToolStripMenuItem рестартToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem gameTableToolStripMenuItem;
        private ToolStripMenuItem gameModeToolStripMenuItem;
    }
}
