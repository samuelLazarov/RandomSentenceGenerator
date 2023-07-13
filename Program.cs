namespace RandomSentenceGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Чеченеца", "Мюмюн", "Айше", "Самет" };
            string[] places = { "София", "Пловдив", "Варна", "Бургас" };
            string[] verbs = { "яде", "държи", "гледа", "играе с", "носи" };
            string[] nouns = { "камъни", "торта", "ябълка", "лаптоп", "колело" };
            string[] advebs = { "бавно", "прилежно", "топло", "тъжно", "бързо" };
            string[] details = { "до реката", "вкъщи", "в парка" };

            Console.WriteLine("Hello, this is your first random-generated sentence: ");

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(advebs);
                string randomDetail = GetRandomWord(details);

                string who = $"{randomName} от {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetail}.";

                Console.WriteLine(sentence);
                Console.WriteLine("Click [Enter] to generate a new one.");
                Console.ReadLine();

            }

        }

        static string GetRandomWord(string[] words)
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];
            return word;
        }
        
    }
}