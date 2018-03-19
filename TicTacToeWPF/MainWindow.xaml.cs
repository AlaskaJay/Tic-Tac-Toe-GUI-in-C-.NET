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

namespace TicTacToeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TicTacToe board;

        public MainWindow()
        {
            InitializeComponent();
            board = new TicTacToe();
        }

        private void drawBoard()
        {
            butt00.Content = board.getSpace(0, 0);
            butt01.Content = board.getSpace(0, 1);
            butt02.Content = board.getSpace(0, 2);
            butt10.Content = board.getSpace(1, 0);
            butt11.Content = board.getSpace(1, 1);
            butt12.Content = board.getSpace(1, 2);
            butt20.Content = board.getSpace(2, 0);
            butt21.Content = board.getSpace(2, 1);
            butt22.Content = board.getSpace(2, 2);
        }

        private void calls(int x, int y)
        {
            board.takeTurn(x, y);
            drawBoard();
        }

        private void butt00_Click(object sender, RoutedEventArgs e)
        {
            calls(0, 0);
        }

        private void butt01_Click(object sender, RoutedEventArgs e)
        {
            calls(0, 1);
        }

        private void butt02_Click(object sender, RoutedEventArgs e)
        {
            calls(0, 2);
        }

        private void butt10_Click(object sender, RoutedEventArgs e)
        {
            calls(1, 0);
        }

        private void butt11_Click(object sender, RoutedEventArgs e)
        {
            calls(1, 1);
        }

        private void butt12_Click(object sender, RoutedEventArgs e)
        {
            calls(1, 2);
        }

        private void butt20_Click(object sender, RoutedEventArgs e)
        {
            calls(2, 0);
        }

        private void butt21_Click(object sender, RoutedEventArgs e)
        {
            calls(2, 1);
        }

        private void butt22_Click(object sender, RoutedEventArgs e)
        {
            calls(2, 2);
        }
    }
}
