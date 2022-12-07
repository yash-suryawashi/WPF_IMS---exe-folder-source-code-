using Interface_Lib;
using RWClass_Lib;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WPF_IMS.View
{
    public partial class Update_dialog : Window
    {
        ObservableCollection<Instruments> selectedList = new ObservableCollection<Instruments>();
        List<string> userList;
        List<string> projectList;

        RWClass i = new RWClass();

        public Update_dialog()
        {
            InitializeComponent();

            userList = new List<string> { "Yash S", "Vinayak G", "Shailesh S", "Ajinkya A", "Pradumna S", "Nikhil C" };
            projectList = new List<string> { "project-1", "project-2", "project-3", "project-4" };
            cmbUserUpdate.ItemsSource = userList;
            lbProjectsUpdate.ItemsSource = projectList;

            lbInstruments.ItemsSource = i.getInstruments();
        }

        private void lbInstruments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedList.Clear();
            if (this.lbInstruments.SelectedItem is Instruments)
            {
                selectedList.Add(((Instruments)this.lbInstruments.SelectedItem));
            }
            foreach (var item in selectedList)
            {
                var q = item.Project;
                txtNameUpdate.Text = item.Name;
                cmbUserUpdate.SelectedValue = item.User;
                lbProjectsUpdate.ItemsSource = projectList;

                var pr = item.Project.Split(" ");
                foreach (var i in pr)
                {
                    if (projectList.Contains(i))
                    {
                        lbProjectsUpdate.SelectedItems.Add(i);
                    }
                }
            }
        }
    }
}