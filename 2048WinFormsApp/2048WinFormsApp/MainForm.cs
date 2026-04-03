using _2048ClassLibrary;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private int mapSize;
        private Label[,] labelMap;
        private User user;
        private int recordScore;
        private bool gameIsContinueAfterWinning;
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        } 
        private void MainForm_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }
        private int GetMapSize()
        {
            var gameModeForm = new GameModeForm();
            if (gameModeForm.ShowDialog() == DialogResult.OK)
            {
                return gameModeForm.MapSize;
            }
            return 5;
        }
        private void StartNewGame()
        {
            RecreateMap();
            mapSize = GetMapSize();
            InitMap();
            user.Score = 0;
            gameIsContinueAfterWinning = false;
            recordScore = UserResultStorage.GetRecordScore();
            scoreLabel.Text = $"Счет: {user.Score}";
            userNameLabel.Text = $"Игрок: {user.Name}";
            recordLabel.Text = $"Рекорд: {recordScore}";
            GenerateNumber();
        }
        private void InitMap()
        {
            labelMap = new Label[mapSize, mapSize];
            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateCellLabel(i, j, i * mapSize + j);
                    Controls.Add(newLabel);
                    labelMap[i, j] = newLabel;
                }
            }
        }
        private void RecreateMap()
        {
            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    if (labelMap != null && labelMap[i, j] != null)
                    {
                        Controls.Remove(labelMap[i, j]);
                        labelMap[i, j].Dispose();
                    }
                }
            }
        }
        private bool WinGame()
        {
            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    if (labelMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private Label CreateCellLabel(int indexRow, int indexColoumn, int widthCell)
        {
            var cellNumberLabel = new Label();
            var cellSize = GetCellSize();
            cellNumberLabel.Name = "cellNumberLabel";
            cellNumberLabel.Size = new Size(cellSize[0], cellSize[0]);
            cellNumberLabel.BackColor = SystemColors.ControlLight;
            cellNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cellNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            cellNumberLabel.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cellNumberLabel.TabIndex = 0;

            var x = 10 + indexColoumn * cellSize[1];
            var y = 150 + indexRow * cellSize[1];
            cellNumberLabel.Location = new Point(x, y);

            return cellNumberLabel;
        }
        private List<int> GetCellSize()
        {
            switch (mapSize)
            {
                case 4: return new List<int>(2) { 89, 95 };
                case 5: return new List<int>(2) { 70, 76 };
                case 6: return new List<int>(2) { 61, 63 };
                case 7: return new List<int>(2) { 50, 55 };
            }
            return new List<int>();
        }
        private void GenerateNumber()
        {
            while (true)
            {
                var random = new Random();
                var randomIndexLabel = random.Next(mapSize * mapSize);
                var indexRow = randomIndexLabel / mapSize;
                var indexColoumn = randomIndexLabel % mapSize;
                if (labelMap[indexRow, indexColoumn].Text == string.Empty)
                {
                    var value = random.Next(100) < 80 ? 2 : 4;
                    labelMap[indexRow, indexColoumn].Text = value.ToString();
                    labelMap[indexRow, indexColoumn].BackColor = ColorsStorage.GetCellColor(value);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
        private void CheckNewRecord(int score)
        {
            if (score > recordScore)
            {
                recordScore = score;
            }
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                for (var i = 0; i < mapSize; i++)
                {
                    for (var j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelMap[i, j].Text != string.Empty)
                        {
                            for (var k = j - 1; k >= 0; k--)
                            {
                                if (labelMap[i, k].Text != string.Empty)
                                {
                                    if (labelMap[i, j].Text == labelMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelMap[i, j].Text);
                                        labelMap[i, j].Text = (number * 2).ToString();
                                        user.IncreaseScore(number * 2);
                                        CheckNewRecord(user.Score);
                                        recordLabel.Text = $"Рекорд: {recordScore}";
                                        scoreLabel.Text = $"Счет: {user.Score}";
                                        labelMap[i, j].BackColor = ColorsStorage.GetCellColor(number * 2);
                                        labelMap[i, k].Text = string.Empty;
                                        labelMap[i, k].BackColor = SystemColors.ControlLight;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (var i = 0; i < mapSize; i++)
                {
                    for (var j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelMap[i, j].Text == string.Empty)
                        {
                            for (var k = j - 1; k >= 0; k--)
                            {
                                if (labelMap[i, k].Text != string.Empty)
                                {
                                    labelMap[i, j].Text = labelMap[i, k].Text;
                                    labelMap[i, j].BackColor = ColorsStorage.GetCellColor(int.Parse(labelMap[i, j].Text));
                                    labelMap[i, k].Text = string.Empty;
                                    labelMap[i, k].BackColor = SystemColors.ControlLight;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                for (var i = 0; i < mapSize; i++)
                {
                    for (var j = 0; j < mapSize; j++)
                    {
                        if (labelMap[i, j].Text != string.Empty)
                        {
                            for (var k = j + 1; k < mapSize; k++)
                            {
                                if (labelMap[i, k].Text != string.Empty)
                                {
                                    if (labelMap[i, j].Text == labelMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelMap[i, j].Text);
                                        labelMap[i, j].Text = (number * 2).ToString();
                                        labelMap[i, j].BackColor = ColorsStorage.GetCellColor(number * 2);
                                        user.IncreaseScore(number * 2);
                                        CheckNewRecord(user.Score);
                                        recordLabel.Text = $"Рекорд: {recordScore}";
                                        scoreLabel.Text = $"Счет: {user.Score}";
                                        labelMap[i, k].Text = string.Empty;
                                        labelMap[i, k].BackColor = SystemColors.ControlLight;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (var i = 0; i < mapSize; i++)
                {
                    for (var j = 0; j < mapSize; j++)
                    {
                        if (labelMap[i, j].Text == string.Empty)
                        {
                            for (var k = j + 1; k < mapSize; k++)
                            {
                                if (labelMap[i, k].Text != string.Empty)
                                {
                                    labelMap[i, j].Text = labelMap[i, k].Text;
                                    labelMap[i, j].BackColor = ColorsStorage.GetCellColor(int.Parse(labelMap[i, j].Text));
                                    labelMap[i, k].Text = string.Empty;
                                    labelMap[i, k].BackColor = SystemColors.ControlLight;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    for (var i = 0; i < mapSize; i++)
                    {
                        if (labelMap[i, j].Text != string.Empty)
                        {
                            for (var k = i + 1; k < mapSize; k++)
                            {
                                if (labelMap[k, j].Text != string.Empty)
                                {
                                    if (labelMap[i, j].Text == labelMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelMap[i, j].Text);
                                        labelMap[i, j].Text = (number * 2).ToString();
                                        user.IncreaseScore(number * 2);
                                        CheckNewRecord(user.Score);
                                        recordLabel.Text = $"Рекорд: {recordScore}";
                                        scoreLabel.Text = $"Счет: {user.Score}";
                                        labelMap[i, j].BackColor = ColorsStorage.GetCellColor(number * 2);
                                        labelMap[k, j].Text = string.Empty;
                                        labelMap[k, j].BackColor = SystemColors.ControlLight;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (var j = 0; j < mapSize; j++)
                {
                    for (var i = 0; i < mapSize; i++)
                    {
                        if (labelMap[i, j].Text == string.Empty)
                        {
                            for (var k = i + 1; k < mapSize; k++)
                            {
                                if (labelMap[k, j].Text != string.Empty)
                                {
                                    labelMap[i, j].Text = labelMap[k, j].Text;
                                    labelMap[i, j].BackColor = ColorsStorage.GetCellColor(int.Parse(labelMap[i, j].Text));
                                    labelMap[k, j].Text = string.Empty;
                                    labelMap[k, j].BackColor = SystemColors.ControlLight;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    for (var i = mapSize - 1; i >= 0; i--)
                    {
                        if (labelMap[i, j].Text != string.Empty)
                        {
                            for (var k = i - 1; k >= 0; k--)
                            {
                                if (labelMap[k, j].Text != string.Empty)
                                {
                                    if (labelMap[i, j].Text == labelMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelMap[i, j].Text);
                                        labelMap[i, j].Text = (number * 2).ToString();
                                        user.IncreaseScore(number * 2);
                                        CheckNewRecord(user.Score);
                                        recordLabel.Text = $"Рекорд: {recordScore}";
                                        scoreLabel.Text = $"Счет: {user.Score}";
                                        labelMap[i, j].BackColor = ColorsStorage.GetCellColor(number * 2);
                                        labelMap[k, j].Text = string.Empty;
                                        labelMap[k, j].BackColor = SystemColors.ControlLight;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (var j = 0; j < mapSize; j++)
                {
                    for (var i = mapSize - 1; i >= 0; i--)
                    {
                        if (labelMap[i, j].Text == string.Empty)
                        {
                            for (var k = i - 1; k >= 0; k--)
                            {
                                if (labelMap[k, j].Text != string.Empty)
                                {
                                    labelMap[i, j].Text = labelMap[k, j].Text;
                                    labelMap[i, j].BackColor = ColorsStorage.GetCellColor(int.Parse(labelMap[i, j].Text));
                                    labelMap[k, j].Text = string.Empty;
                                    labelMap[k, j].BackColor = SystemColors.ControlLight;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (GameIsEnd())
            {
                FinishGame();
                return;
            }
            if (WinGame() && !gameIsContinueAfterWinning)
            {
                if (!AskPlayerToContinue())
                {
                    FinishGame();
                    return;
                }
                gameIsContinueAfterWinning = true;
            }
            GenerateNumber();
        }
        private bool AskPlayerToContinue()
        {
            var result = MessageBox.Show(
                "Поздравляем! Вы достигли 2048! Хотите продолжить эту игру?",
                "Победа!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            return result == DialogResult.Yes;
        }
        private bool GameIsEnd()
        {
            for (var i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    if (labelMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                    var currentValue = int.Parse(labelMap[i, j].Text);
                    if (j + 1 < mapSize)
                    {
                        if (labelMap[i, j + 1].Text != string.Empty)
                        {
                            var rightValue = int.Parse(labelMap[i, j + 1].Text);
                            if (currentValue == rightValue)
                            {
                                return false;
                            }
                        }
                    }
                    if (i + 1 < mapSize)
                    {
                        if (labelMap[i + 1, j].Text != string.Empty)
                        {
                            var downValue = int.Parse(labelMap[i + 1, j].Text);
                            if (currentValue == downValue)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
        private void FinishGame()
        {
            UserResultStorage.SaveGameResultToFile(user);
            MessageBox.Show($"Игра закончена! Твой результат: {user.Score}");
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Score > 0)
            {
                FinishGame();
            }
            StartNewGame();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (user.Score > 0)
            {
                FinishGame();
            }
            Application.Exit();
        }
        private void gameTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gameTableForm = new GameTableForm();
            gameTableForm.Show();
        }
        private void gameModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinishGame();
            StartNewGame();
        }
        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rulesForm = new RulesForm();
            rulesForm.Show();
        }
    }
}
