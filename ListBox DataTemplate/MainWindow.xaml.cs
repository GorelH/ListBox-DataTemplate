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
using ListBox_DataTemplate.ListBox;
using ListBox_DataTemplate.ListBox.Template1;
using ListBox_DataTemplate.Class.Employer;

namespace ListBox_DataTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();

            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });

            MylistBox1.ItemsSource = ListBoxTemplate1.GetEmplist ();
            MylistBox2.ItemsSource = ListBoxTemplate1.GetEmplist();
           
        }


        

        public class TodoItem {
            public string Title { get; set; }
            public int Completion { get; set; }
        }

        

        


    }

    
}

