using _2048ClassLibrary;

namespace _2048WinFormsApp
{
    public partial class GameTableForm : Form
    {
        public GameTableForm()
        {
            InitializeComponent();
            ShowTable();
        }
        public void ShowTable()
        {
            var gameResults = UserResultStorage.GetGameHistory();
            gameTableDataGridView.Rows.Clear();
            for (var i = 0; i < gameResults.Count; i++)
            {
                gameTableDataGridView.Rows.Add
                    (
                    gameResults[i].Name,
                    gameResults[i].Score
                    );
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
