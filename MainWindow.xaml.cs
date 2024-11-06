using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace tiktakto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; } = true;
        public int Counter { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            NewGame();
        }

        public void NewGame()
        {
            IsPlayer1Turn = false;
            Counter = 0;

            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_3_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_3_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;
            Button_3_2.Content = string.Empty;
            Button_0_3.Content = string.Empty;
            Button_1_3.Content = string.Empty;
            Button_2_3.Content = string.Empty;
            Button_3_3.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_3_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_3_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
            Button_3_2.Background = Brushes.White;
            Button_0_3.Background = Brushes.White;
            Button_1_3.Background = Brushes.White;
            Button_2_3.Background = Brushes.White;
            Button_3_3.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            IsPlayer1Turn ^= true;
            Counter++;

            if (Counter > 16)
            {
                NewGame();
                return;
            }

            var button = sender as Button;

            button.Content = IsPlayer1Turn ? "O" : "X"; ;

            if (CheckIfPlayerWon())
            {
                Counter = 16;
            }
        }

        private bool CheckIfPlayerWon()
        {
            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content && Button_0_2.Content == Button_0_3)
            {
                Button_0_0.Background = Brushes.Red;
                Button_0_1.Background = Brushes.Red;
                Button_0_2.Background = Brushes.Red;
                Button_0_3.Background = Brushes.Red;
                return true;
            }

            if (Button_1_0.Content.ToString() != string.Empty && Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content && Button_1_2.Content == Button_1_3)
            {
                Button_1_0.Background = Brushes.Red;
                Button_1_1.Background = Brushes.Red;
                Button_1_2.Background = Brushes.Red;
                Button_1_3.Background = Brushes.Red;
                return true;
            }

            if (Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content && Button_2_2.Content == Button_2_3)
            {
                Button_2_0.Background = Brushes.Red;
                Button_2_1.Background = Brushes.Red;
                Button_2_2.Background = Brushes.Red;
                Button_2_3.Background = Brushes.Red;
                return true;
            }

            if (Button_3_0.Content.ToString() != string.Empty && Button_2_0.Content == Button_3_1.Content && Button_3_1.Content == Button_3_2.Content && Button_3_2.Content == Button_3_3)
            {
                Button_3_0.Background = Brushes.Red;
                Button_3_1.Background = Brushes.Red;
                Button_3_2.Background = Brushes.Red;
                Button_3_3.Background = Brushes.Red;
                return true;
            }





            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content && Button_2_0.Content == Button_3_0)
            {
                Button_0_0.Background = Brushes.Red;
                Button_1_0.Background = Brushes.Red;
                Button_2_0.Background = Brushes.Red;
                Button_3_0.Background = Brushes.Red;
                return true;
            }

            if (Button_0_1.Content.ToString() != string.Empty && Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content && Button_2_1.Content == Button_3_1)
            {
                Button_0_1.Background = Brushes.Red;
                Button_1_1.Background = Brushes.Red;
                Button_2_1.Background = Brushes.Red;
                Button_3_1.Background = Brushes.Red;
                return true;
            }

            if (Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content && Button_2_2.Content == Button_3_2)
            {
                Button_0_2.Background = Brushes.Red;
                Button_1_2.Background = Brushes.Red;
                Button_2_2.Background = Brushes.Red;
                Button_3_2.Background = Brushes.Red;
                return true;
            }

            if (Button_0_3.Content.ToString() != string.Empty && Button_0_3.Content == Button_1_3.Content && Button_1_3.Content == Button_2_3.Content && Button_2_3.Content == Button_3_3)
            {
                Button_0_3.Background = Brushes.Red;
                Button_1_3.Background = Brushes.Red;
                Button_2_3.Background = Brushes.Red;
                Button_3_3.Background = Brushes.Red;
                return true;
            }




            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content && Button_2_2.Content == Button_3_3)
            {
                Button_0_2.Background = Brushes.Red;
                Button_1_2.Background = Brushes.Red;
                Button_2_2.Background = Brushes.Red;
                Button_3_2.Background = Brushes.Red;
                return true;
            }

            if (Button_3_0.Content.ToString() != string.Empty && Button_3_0.Content == Button_2_1.Content && Button_2_1.Content == Button_1_2.Content && Button_1_2.Content == Button_0_3)
            {
                Button_3_0.Background = Brushes.Red;
                Button_2_1.Background = Brushes.Red;
                Button_1_2.Background = Brushes.Red;
                Button_0_3.Background = Brushes.Red;
                return true;
            }

            return false;
        }
    }
}