﻿using System.Collections.Generic;
using System.Windows;

namespace WPF_IMS.View
{
    public partial class Add_dialog : Window
    {
        List<string> userList;
        List<string> projectList;
        public Add_dialog()
        {
            InitializeComponent();

            txtName.Text = string.Empty;
            cmbUser.SelectedIndex = -1;
            lbProjects.SelectedIndex = -1;

            userList = new List<string> { "Yash S", "Vinayak G", "Shailesh S", "Ajinkya A", "Pradumna S", "Nikhil C" };
            projectList = new List<string> { "project-1", "project-2", "project-3", "project-4" };
            cmbUser.ItemsSource = userList;
            lbProjects.ItemsSource = projectList;
        }
    }
}