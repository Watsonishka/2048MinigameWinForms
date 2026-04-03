namespace _2048WinFormsApp
{
    public partial class GameModeForm : Form
    {
        public int MapSize;
        public GameModeForm()
        {
            InitializeComponent();
        }
        private void size4Label_Click(object sender, EventArgs e)
        {
            MapSize = 4;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void size5Label_Click(object sender, EventArgs e)
        {
            MapSize = 5;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void size6Label_Click(object sender, EventArgs e)
        {
            MapSize = 6;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void size7Label_Click(object sender, EventArgs e)
        {
            MapSize = 7;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
