using System.Text;

namespace _2048ClassLibrary
{
    public class InputValidator
    {
        public static bool CheckNameIsValid(string inputName, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(inputName))
            {
                errorMessage = "Некорректный ввод! Ввод не может быть пустым!";
                return false;
            }
            if (!InputValidator.ContainsRussianLetters(Convert.ToString(inputName[0])))
            {
                errorMessage = "Некорректный ввод! Первый символ всегда должен быть РУССКОЙ буквой!";
                return false;
            }
            if (!InputValidator.IsAllowedNameSymbol(inputName))
            {
                errorMessage = "Полный ввод может содержать только РУССКИЕ буквы, пробелы, апостроф и тире!";
                return false;
            }
            return true;
        }
        public static string NormalizeName(string inputName)
        {
            inputName = inputName.ToLower().Trim(' ', '-', '\'');
            var userName = new StringBuilder();
            var previousCharWasSymbol = false;

            for (var i = 0; i < inputName.Length; i++)
            {
                var currentChar = inputName[i];
                if ((currentChar == ' ' || currentChar == '-' || currentChar == '\'') && previousCharWasSymbol)
                {
                    continue;
                }

                if (i == 0 || previousCharWasSymbol)
                {
                    userName.Append(char.ToUpper(currentChar));
                }
                else
                {
                    userName.Append(currentChar);
                }
                previousCharWasSymbol = currentChar == ' ' || currentChar == '-' || currentChar == '\'';
            }
            return userName.ToString();
        }
        public static bool ContainsRussianLetters(string input)
        {
            var isСontainsRussianLetters = false;
            for (var i = 0; i < input.Length; i++)
            {
                if ((input[i] >= 'A' && input[i] <= 'Z') || (input[i] >= 'a' && input[i] <= 'z'))
                {
                    return false;
                }

                if ((input[i] >= 'А' && input[i] <= 'я') || input[i] == 'Ё' || input[i] == 'ё')
                {
                    isСontainsRussianLetters = true;
                }
            }
            return isСontainsRussianLetters;
        }
        public static bool IsAllowedNameSymbol(string inputName)
        {
            for (var i = 0; i < inputName.Length; i++)
            {
                if ((inputName[i] < 'А' || inputName[i] > 'я')
                    && inputName[i] != 'Ё'
                    && inputName[i] != 'ё'
                    && inputName[i] != '-'
                    && inputName[i] != ' '
                    && inputName[i] != '\'')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
