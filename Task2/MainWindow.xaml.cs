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

namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private PantherViewModel _viewModelPanther;
        private DogViewModel _viewModelDog;
        private TurtleViewModel _viewModelTurtle;

        public MainWindow()
        {
            InitializeComponent();
            _viewModelPanther = new PantherViewModel();
            _viewModelDog = new DogViewModel();
            _viewModelTurtle = new TurtleViewModel();
            DataContext = this;
        }

        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeToPantherDataContext();
            _viewModelPanther.Move();
        }

        private void StandButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeToPantherDataContext();
            _viewModelPanther.Stand();
        }

        private void RoarButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_viewModelPanther.Roar());
        }

        private void ClimbTreeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_viewModelPanther.ClimbTree());
        }

        private void ChangeToPantherDataContext()
        {
            DataContext = _viewModelPanther;  
        }

        private void ChangeToDogDataContext()
        {
            DataContext = _viewModelDog;
        }

        private void ChangeToTurtleDataContext()
        {
            DataContext = _viewModelTurtle;
        }

        private void MoveButton_ClickDog(object sender, RoutedEventArgs e)
        {
            ChangeToDogDataContext();
            _viewModelDog.Move();
        }

        private void StandButton_ClickDog(object sender, RoutedEventArgs e)
        {
            ChangeToDogDataContext();
            _viewModelDog.Stand();
        }

        private void RoarButton_ClickDog(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_viewModelDog.Roar());
        }
        private void MoveButton_ClickTurtle(object sender, RoutedEventArgs e)
        {
            ChangeToTurtleDataContext();
            _viewModelTurtle.Move();
        }

        private void StandButton_ClickTurtle(object sender, RoutedEventArgs e)
        {
            ChangeToTurtleDataContext();
            _viewModelTurtle.Stand();
        }
    }
}

