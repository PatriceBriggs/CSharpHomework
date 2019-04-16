using System;
using System.Windows;
using System.Windows.Controls;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.User user = new Models.User();

        public MainWindow()
        {
            InitializeComponent();
            uxSubmit.IsEnabled.Equals(false);
            uxContainer.DataContext = user;
        }

        public override void EndInit()
        {
            base.EndInit();
        }

        private void UxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(uxName.Text + ", your new password is: " + uxPassword.Text);

            uxName.Text = "";
            uxPassword.Text = "";

        }

        private void CheckForNull(object sender, TextChangedEventArgs e)
        {
            // Both fields empty -> uxSubmit is disabled
            // Only one field has text->uxSubmit is disabled
            if (String.IsNullOrEmpty(uxName.Text) || String.IsNullOrEmpty(uxPassword.Text))
            {
                uxSubmit.IsEnabled = false;
                return;
            }
            // Both fields have text -> uxSubmit is enabled
            if (!String.IsNullOrEmpty(uxName.Text) && !String.IsNullOrEmpty(uxPassword.Text))
            {
                uxSubmit.IsEnabled = true;
                return;
            }
        }
    }
}