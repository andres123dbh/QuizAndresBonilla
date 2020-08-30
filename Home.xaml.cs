using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizAndresBonilla
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string animeName = txtAnimeName.Text;
            string category = lblCategory.Content.ToString();
            string numberOfChapter = txtSlider.Text;
            string publicationDate = txtCalendar.Text;
            var item = (ComboBoxItem)finished.SelectedValue;
            var content = (string)item.Content;

            var add = animeName + "\n"+ category + "\nChapther: " 
                + numberOfChapter + "\nPublication Date: " + publicationDate
                + "\nYou Finished It?: " + content;
            txtResults.Inlines.Add(new Run(add));
            txtResults.Inlines.Add(new LineBreak());


        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtResults.Text = string.Empty;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new Login());
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.IsChecked.Value)
            {
                lblCategory.Content = rb.Content.ToString();
            }
        }

        private void SlpNumberOfChapthers_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int val = Convert.ToInt32(e.NewValue);
            string msgNumberOfChapter = String.Format("{0}", val);
            txtSlider.Text = msgNumberOfChapter;
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calPublicationDate = sender as Calendar;

            if (calPublicationDate.SelectedDate.HasValue)
            {
                DateTime date = calPublicationDate.SelectedDate.Value;
                txtCalendar.Text = date.ToShortDateString();
            }
        }

        
    }
}
