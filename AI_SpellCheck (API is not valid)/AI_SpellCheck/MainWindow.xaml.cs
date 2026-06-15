using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json.Linq;

namespace AI_SpellCheck
{
    /// <summary>
    /// Основен прозорец на приложението. Съдържа интерфейс и логика за взаимодействие с потребителя.
    /// </summary>
    public partial class MainWindow : Window
    {
        // Ключ за достъп до външния API
        private const string ApiKey = "nCr7Om64whpDthF8ds8aGp9lkmiM7u2S";

        // URL адрес на API услугата за корекция
        private const string ApiUrl = "https://api.bggpt.ai/completions";

        // Конструктор на прозореца – инициализира компонентите
        public MainWindow()
        {
            InitializeComponent();
        }

        // Зарежда първия примерен текст в текстовото поле за вход
        private void Example1_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = "Аз съм ходил на кино вчера и съм гледал страхотен филъм. Утре ша ида пак, защото филъма беше много хубав.";
        }

        // Зарежда втори примерен текст
        private void Example2_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = "Вчера,аз и моите приятели сме отишли до парка,но незнам защо нямаше   да срещнем никого там.";
        }

        // Зарежда трети примерен текст
        private void Example3_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = "Телефона ми е счупен от 2 седмици и все още нямаше да го поправя макар,че ми е много нужен.";
        }

        // Изчиства съдържанието на текстовите полета
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            InputTextBox.Text = string.Empty;
            OutputTextBox.Text = "Тук ще се появи коригираният текст след натискане на бутона.";
        }

        // Извиква API за корекция на текста, като изпраща заявка с въведения от потребителя текст
        private async void CorrectButton_Click(object sender, RoutedEventArgs e)
        {
            // Извлича и премахва излишните интервали от текста
            string userText = InputTextBox.Text.Trim();

            // Създава подканващ текст (prompt), който ще се изпрати до езиковия модел
            string prompt = $"<bos><start_of_turn>user\nКоригирай правописа, словореда, изписването на думите, граматиката и пунктоацията в следния текст като препишеш целия текст " +
                $"или просто го напиши правилно. Също ако няма никакъв текст недей писа нищо. Искам само целия текст без никакви други думи:\n\"{userText}\"\n<end_of_turn>\n<start_of_turn>model\n";

            // Подготвя обект с параметри за заявката към API
            var requestBody = new
            {
                model = "insait/insait-gemma-2-27b-bg-mixed-19847",
                prompt = prompt,
                max_tokens = 1024,
                temperature = 0.1,
                top_k = 20,
                repetition_penalty = 1.1,
                stop = new[] { "<end_of_turn>", "<eos>" },
                stream = false
            };

            try
            {
                // Показва визуален индикатор за зареждане
                LoadingOverlay.Visibility = Visibility.Visible;

                // Създава клиент за HTTP заявка
                using (HttpClient client = new HttpClient())
                {
                    // Добавя API ключ към заглавките на заявката
                    client.DefaultRequestHeaders.Add("apikey", ApiKey);

                    // Създава тялото на заявката като JSON низ
                    var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

                    // Изпраща POST заявка към API-то
                    var response = await client.PostAsync(ApiUrl, content);

                    // Извлича резултата като текст
                    string result = await response.Content.ReadAsStringAsync();

                    // Преобразува резултата в JSON обект
                    JObject json = JObject.Parse(result);

                    // Извлича коригирания текст от отговора
                    string output = json["choices"]?[0]?["text"]?.ToString().Trim();

                    // Показва текста в изходното текстово поле
                    OutputTextBox.Text = output ?? "Няма отговор.";
                }
            }
            catch (Exception ex)
            {
                // Обработка на грешки при липса на интернет връзка или други проблеми
                if (ex.Message == "No such host is known. (api.bggpt.ai:443)")
                {
                    MessageBox.Show($"Възникна грешка. Проверете дали сте свързани с интернет мрежата и опитайте отново!", "Грешка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show($"Възникна грешка: {ex.Message}", "Грешка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            finally
            {
                // Скрива визуалния индикатор за зареждане, независимо от изхода
                LoadingOverlay.Visibility = Visibility.Collapsed;
            }
        }
    }
}