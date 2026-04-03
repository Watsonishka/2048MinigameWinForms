namespace _2048WinFormsApp
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            ruleLabel.Text = "Управление:" + Environment.NewLine +
                "Используйте клавиши со стрелками." + Environment.NewLine +
                Environment.NewLine +
                "Объединение плиток:" + Environment.NewLine +
                "При сдвиге плитки перемещаются до упора." + Environment.NewLine +
                "Если две одинаковые плитки сталкиваются, они объединяются в одну с суммой значений." + Environment.NewLine +
                Environment.NewLine +
                "Появление новых плиток:" + Environment.NewLine +
                "После каждого хода на пустой клетке появляется новая плитка." + Environment.NewLine +
                "В 80% случаев выпадает 2, в 20% - выпадает 4." + Environment.NewLine +
                Environment.NewLine +
                "Счет:" + Environment.NewLine +
                "Очки начисляются за каждое объединение." + Environment.NewLine +
                "Количество очков равно значению полученной плитки.";
            endGameLabel.Text = "Игра заканчивается поражением, если все клетки поля заполнены (нет пустых)." +
                "и нет возможности объединить соседние плитки ни в одном направлении." + Environment.NewLine +
                "Игра заканчивается победой, если вы собрали плитку со значением 2048. После победы можно продолжить игру, " +
                "чтобы установить рекорд.";
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
