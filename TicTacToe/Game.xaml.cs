using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        bool checker = false; // false:X true:O
        public Game()
        {
            InitializeComponent();
        }

        private string XorO()
        {
            if (checker == false)
            {
                txtOne.Background = Brushes.White;
                txtTwo.Background = Brushes.MediumPurple;
                checker = true;
                return "X";
            }
            else
            {
                txtTwo.Background = Brushes.White;
                txtOne.Background = Brushes.MediumPurple;
                checker = false;
                return "O";
            }

        }

        private void btnEnable()
        {
            btn1.IsEnabled = false;
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn4.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            btn7.IsEnabled = false;
            btn8.IsEnabled = false;
            btn9.IsEnabled = false;
        }
        private void MessageControls(MessageBoxResult result)
        {
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Restart();
                    break;
                case MessageBoxResult.No:
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    base.Close();
                    break;
            }
        }
        private void Restart(object sender, EventArgs e)
        {
            Restart();
        }
        private void Restart()
        {

            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;


            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
        }

        private void Score()
        {
            if ((string)btn1.Content == "X" && (string)btn2.Content == "X" && (string)btn3.Content == "X")
            {
                btnEnable();
                MessageBoxResult result=MessageBox.Show("1. oyuncu kazandı \n Tekrar oynamak ister Misiniz?","Oyun Bitti",MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn4.Content == "X" && (string)btn5.Content == "X" && (string)btn6.Content == "X")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("1. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn7.Content == "X" && (string)btn8.Content == "X" && (string)btn9.Content == "X")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("1. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn1.Content == "O" && (string)btn2.Content == "O" && (string)btn3.Content == "O")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("2. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn4.Content == "O" && (string)btn5.Content == "O" && (string)btn6.Content == "O")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("2. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn7.Content == "O" && (string)btn8.Content == "O" && (string)btn9.Content == "O")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("2. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn1.Content == "X" && (string)btn4.Content == "X" && (string)btn7.Content == "X")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("1. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn2.Content == "X" && (string)btn5.Content == "X" && (string)btn8.Content == "X")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("1. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn3.Content == "X" && (string)btn6.Content == "X" && (string)btn9.Content == "X")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("1. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn1.Content == "O" && (string)btn4.Content == "O" && (string)btn7.Content == "O")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("2. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn2.Content == "O" && (string)btn5.Content == "O" && (string)btn8.Content == "O")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("2. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn3.Content == "O" && (string)btn6.Content == "O" && (string)btn9.Content == "O")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("2. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn1.Content == "X" && (string)btn5.Content == "X" && (string)btn9.Content == "X")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("1. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn3.Content == "X" && (string)btn5.Content == "X" && (string)btn7.Content == "X")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("1. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn1.Content == "O" && (string)btn5.Content == "O" && (string)btn9.Content == "O")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("2. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else if ((string)btn3.Content == "O" && (string)btn5.Content == "O" && (string)btn7.Content == "O")
            {
                btnEnable();
                MessageBoxResult result = MessageBox.Show("2. oyuncu kazandı \n Tekrar oynamak ister Misiniz?", "Oyun Bitti", MessageBoxButton.YesNo);
                MessageControls(result);
            }
            else
            {

            }

        }
        private void GameExit(object sender, EventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Oyundan Çıkmak istediğinize emin misiniz?", "Tic Tac Toe", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    base.Close();
                    break;
                case MessageBoxResult.No:
                    break;
                default:
                    break;
            }
        }
        private void btn1Click(object sender, EventArgs e)
        { 
            btn1.Content = XorO();
            btn1.IsEnabled = false;
            Score();

        }
        private void btn2Click(object sender, EventArgs e)
        {
            btn2.Content = XorO();
            btn2.IsEnabled = false;
            Score();
        }
        private void btn3Click(object sender, EventArgs e)
        {
            btn3.Content = XorO();
            btn3.IsEnabled = false;
            Score();
        }
        private void btn4Click(object sender, EventArgs e)
        {
            btn4.Content = XorO();
            btn4.IsEnabled = false;
            Score();
        }
        private void btn5Click(object sender, EventArgs e)
        {
            btn5.Content = XorO();
            btn5.IsEnabled = false;
            Score();
        }
        private void btn6Click(object sender, EventArgs e)
        {
            btn6.Content = XorO();
            btn6.IsEnabled = false;
            Score();
        }
        private void btn7Click(object sender, EventArgs e)
        {
            btn7.Content = XorO();
            btn7.IsEnabled = false;
            Score();
        }
        private void btn8Click(object sender, EventArgs e)
        {
            btn8.Content = XorO();
            btn8.IsEnabled = false;
            Score();
        }
        private void btn9Click(object sender, EventArgs e)
        {
            btn9.Content = XorO();
            btn9.IsEnabled = false;
            Score();
        }
    }
}
