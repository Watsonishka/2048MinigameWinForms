namespace _2048ClassLibrary
{
    public class User
    {
        private string name;
        private int score;
        public string Name
        {
            get => name;
            set
            {
                if (!InputValidator.CheckNameIsValid(value, out string errorMessage))
                {
                    throw new ArgumentException(errorMessage);
                }
                name = InputValidator.NormalizeName(value);
            }
        }
        public int Score
        {
            get => score;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Значение не может быть ниже нуля!");
                }
                score = value;
            }
        }
        public User(string name)
        {
            this.name = name;
            score = 0;
        }
        public void IncreaseScore(int number)
        {
            score += number;
        }
    }
}
