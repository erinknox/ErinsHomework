using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TIcTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxTurn.Text = "X's Turn";
        }

        public void ResetGame()
        {
            foreach (Button button in uxGrid.Children)
            {
                button.Content = null;
                button.IsEnabled = true;
                uxTurn.Text = "X's Turn";
            }
        }

        public void DisableGame()
        {
            foreach (Button button in uxGrid.Children)
            {
                button.IsEnabled = false;
            }
        }

        public void IsGameOver()
        {
            bool gameOver = true;
            foreach (Button button in uxGrid.Children)
            {
                if (button.Content == null)
                {
                    gameOver = false;
                }

            }

            if (gameOver == true)
            {
                DisableGame();
                MessageBox.Show("Game Over!");
                ResetGame();
            }
        }

        public void CheckGameStatus()
        {
            string[] Rows = new string[9];
           
            foreach (Button button in uxGrid.Children)
            {
                if ((string)button.Tag == "0,0" && button.Content != null)
                {
                    Rows[0] = button.Content.ToString();
                }

                if ((string)button.Tag == "0,1" && button.Content != null)
                {
                    Rows[1] = button.Content.ToString();
                }
                if ((string)button.Tag == "0,2" && button.Content != null)
                {
                    Rows[2] = button.Content.ToString();
                }
                if ((string)button.Tag == "1,0" && button.Content != null)
                {
                    Rows[3] = button.Content.ToString();
                }
                if ((string)button.Tag == "1,1" && button.Content != null)
                {
                    Rows[4] = button.Content.ToString();
                }
                if ((string)button.Tag == "1,2" && button.Content != null)
                {
                    Rows[5] = button.Content.ToString();
                }
                if ((string)button.Tag == "2,0" && button.Content != null)
                {
                    Rows[6] = button.Content.ToString();
                }
                if ((string)button.Tag == "2,1" && button.Content != null)
                {
                    Rows[7] = button.Content.ToString();
                }
                if ((string)button.Tag == "2,2" && button.Content != null)
                {
                    Rows[8] = button.Content.ToString();
                }

            }
            if (Rows[0] == Rows[1] && Rows[0] == Rows[2])
            {
                if (Rows[0] == "X")
                {
                    DisableGame();
                    uxTurn.Text = "X is the winner";
                    MessageBox.Show("X Wins!");
                    ResetGame();
                }

                if (Rows[0] == "O")
                {
                    DisableGame();
                    uxTurn.Text = "O is the winner";
                    MessageBox.Show("O Wins!");
                    ResetGame();
                }
            }
            if (Rows[3] == Rows[4] && Rows[3] == Rows[5])
            {
                if (Rows[3] == "X")
                {
                    DisableGame();
                    uxTurn.Text = "X is the winner";
                    MessageBox.Show("X Wins!");
                    ResetGame();
                }

                if (Rows[3] == "O")
                {
                    DisableGame();
                    uxTurn.Text = "O is the winner";
                    MessageBox.Show("O Wins!");
                    ResetGame();
                }
            }
            if (Rows[6] == Rows[7] && Rows[6] == Rows[8])
            {
                if (Rows[6] == "X")
                {
                    DisableGame();
                    uxTurn.Text = "X is the winner";
                    MessageBox.Show("X Wins!");
                    ResetGame();
                }

                if (Rows[6] == "O")
                {
                    DisableGame();
                    uxTurn.Text = "O is the winner";
                    MessageBox.Show("O Wins!");
                    ResetGame();
                }
            }
            if (Rows[0] == Rows[3] && Rows[0] == Rows[6])
            {
                if (Rows[0] == "X")
                {
                    DisableGame();
                    uxTurn.Text = "X is the winner";
                    MessageBox.Show("X Wins!");
                    ResetGame();
                }

                if (Rows[0] == "O")
                {
                    DisableGame();
                    uxTurn.Text = "O is the winner";
                    MessageBox.Show("O Wins!");
                    ResetGame();
                }
            }
            if (Rows[1] == Rows[4] && Rows[1] == Rows[7])
            {
                if (Rows[1] == "X")
                {
                    DisableGame();
                    uxTurn.Text = "X is the winner";
                    MessageBox.Show("X Wins!");
                    ResetGame();
                }

                if (Rows[1] == "O")
                {
                    DisableGame();
                    uxTurn.Text = "O is the winner";
                    MessageBox.Show("O Wins!");
                    ResetGame();
                }
            }
            if (Rows[2] == Rows[5] && Rows[2] == Rows[8])
            {
                if (Rows[2] == "X")
                {
                    DisableGame();
                    uxTurn.Text = "X is the winner";
                    MessageBox.Show("X Wins!");
                    ResetGame();
                }

                if (Rows[2] == "O")
                {
                    DisableGame();
                    uxTurn.Text = "O is the winner";
                    MessageBox.Show("O Wins!");
                    ResetGame();
                }
            }
            if (Rows[0] == Rows[4] && Rows[0] == Rows[8])
            {
                if (Rows[0] == "X")
                {
                    DisableGame();
                    uxTurn.Text = "X is the winner";
                    MessageBox.Show("X Wins!");
                    ResetGame();
                }

                if (Rows[0] == "O")
                {
                    DisableGame();
                    uxTurn.Text = "O is the winner";
                    MessageBox.Show("O Wins!");
                    ResetGame();
                }
            }
            if (Rows[2] == Rows[4] && Rows[2] == Rows[6])
            {
                if (Rows[2] == "X")
                {
                    DisableGame();
                    uxTurn.Text = "X is the winner";
                    MessageBox.Show("X Wins!");
                    ResetGame();
                }

                if (Rows[2] == "O")
                {
                    DisableGame();
                    uxTurn.Text = "O is the winner";
                    MessageBox.Show("O Wins!");
                    ResetGame();
                }
            }
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            ResetGame();
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var pushedButton = (Button)sender;

            if (uxTurn.Text == "X's Turn" && pushedButton.Content == null)
            {
                pushedButton.Content = ("X");
                uxTurn.Text = "O's Turn";
                CheckGameStatus();
                IsGameOver();
            }
            else if (uxTurn.Text == "O's Turn" && pushedButton.Content == null)
            {
                pushedButton.Content = ("O");
                uxTurn.Text = "X's Turn";
                CheckGameStatus();
                IsGameOver();
            }
            
        }
    }
}
