using System.Windows;
using ToDoApp.Services;
using ToDoApp.ViewModels;

namespace ToDoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var repository = new JsonTaskRepository("tasks.json");
            var viewModel = new MainViewModel(repository);
            DataContext = viewModel;

            Loaded += async (s, e) => await viewModel.LoadTasksAsync();
        }
    }
}