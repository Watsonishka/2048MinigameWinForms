using Newtonsoft.Json;

namespace _2048ClassLibrary
{
    public class UserResultStorage
    {
        private const string gameHistoryFilePath = "GameHistory.json";
        public string QuizHistoryFilePath
        {
            get => gameHistoryFilePath;
        }
        static UserResultStorage()
        {
            if (!File.Exists(gameHistoryFilePath))
            {
                FileManager.RewriteTextFile(gameHistoryFilePath, "[]");
            }
        }
        public static void SaveGameResultToFile(User user)
        {
            var users = GetGameHistory();
            users.Add(user);
            var jsonData = JsonConvert.SerializeObject(users);
            FileManager.RewriteTextFile(gameHistoryFilePath, jsonData);
        }
        public static List<User> GetGameHistory()
        {
            return FileManager.ReadTextFile<User>(gameHistoryFilePath);
        }
        public static int GetRecordScore()
        {
            var users = GetGameHistory();
            var recordScore = 0;
            if (users.Count > 0)
            {
                for (var i = 0; i < users.Count; i++)
                {
                    if (recordScore < users[i].Score)
                    {
                        recordScore = users[i].Score;
                    }
                }
            }
            return recordScore;
        }
    }
}
