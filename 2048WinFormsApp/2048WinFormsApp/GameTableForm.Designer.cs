namespace _2048WinFormsApp
{
    partial class GameTableForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            backButton = new Button();
            label1 = new Label();
            gameTableDataGridView = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            scoreColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gameTableDataGridView).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Font = new Font("Arial", 14F, FontStyle.Bold);
            backButton.Location = new Point(115, 512);
            backButton.Name = "backButton";
            backButton.Size = new Size(155, 35);
            backButton.TabIndex = 8;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 14F, FontStyle.Bold);
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(337, 55);
            label1.TabIndex = 9;
            label1.Text = "Таблица предыдущих результатов игры";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // gameTableDataGridView
            // 
            gameTableDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gameTableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gameTableDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gameTableDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameColumn, scoreColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gameTableDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            gameTableDataGridView.Location = new Point(29, 102);
            gameTableDataGridView.Name = "gameTableDataGridView";
            gameTableDataGridView.RowHeadersVisible = false;
            gameTableDataGridView.Size = new Size(337, 375);
            gameTableDataGridView.TabIndex = 10;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Имя";
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 215;
            // 
            // scoreColumn
            // 
            scoreColumn.HeaderText = "Очки";
            scoreColumn.Name = "scoreColumn";
            scoreColumn.Width = 120;
            // 
            // GameTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 587);
            Controls.Add(gameTableDataGridView);
            Controls.Add(label1);
            Controls.Add(backButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameTableForm";
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameTableForm";
            ((System.ComponentModel.ISupportInitialize)gameTableDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button backButton;
        private Label label1;
        private DataGridView gameTableDataGridView;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn scoreColumn;
    }
}