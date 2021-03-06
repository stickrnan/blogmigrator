﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlogMigrator
{
    /// <summary>
    /// Interaction logic for ConnectionHelp.xaml
    /// </summary>
    public partial class ConnectionHelpWindow : Window
    {
        public ConnectionHelpWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the btnClose_Click event.
        /// </summary>
        /// <param name="sender">Close button click event.</param>
        /// <param name="e">Button click event arguments.</param>
        /// <history>
        /// Sean Patterson    11/5/2010   [Created]
        /// </history>
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
