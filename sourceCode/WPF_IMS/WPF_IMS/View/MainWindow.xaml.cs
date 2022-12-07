using System.Collections.Generic;
using System.Windows;

namespace WPF_IMS.View
{
    public partial class MainWindow : Window
    {
        List<string> userList;
        List<string> projectList;

        public MainWindow()
        {
            InitializeComponent();

            userList = new List<string> { "Yash S", "Vinayak G", "Shailesh S", "Ajinkya A", "Pradumna S", "Nikhil C" };
            projectList = new List<string> { "project-1", "project-2", "project-3", "project-4" };
        }

        private void addNewBtn_Click(object sender, RoutedEventArgs e)
        {
            Add_dialog ad = new Add_dialog();
            ad.Show();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            Update_dialog upd = new Update_dialog();
            upd.Show();
        }
    }
}
