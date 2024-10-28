using System;
using System.Windows;

namespace KeyboardTrainer
{
    
    
    public partial class MainWindow : Window
    {
        private string[] textsToType = { "包揽", "SolarCreator", "your mom" };
        private string currentText;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            currentText = textsToType[random.Next(textsToType.Length)];
            TextToType.Text = currentText;
            UserInput.Clear();
            ResultText.Text = string.Empty;
            UserInput.Focus();
        }

        private void UserInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (UserInput.Text == currentText)
            {
                ResultText.Text = "Правильно!";
            }
            else if (currentText.StartsWith(UserInput.Text))
            {
                ResultText.Text = "Продолжайте...";
            }
            else
            {
                ResultText.Text = "Ошибка!";
            }
        }
    }
}