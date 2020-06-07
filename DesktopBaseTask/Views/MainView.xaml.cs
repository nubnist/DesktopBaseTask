using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace DesktopBaseTask.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        PersonsView personsView;
        ContactsView contactsView;
        public MainView()
        {
            InitializeComponent();
            personsView = new PersonsView();
            contactsView = new ContactsView();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        //private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
        //    {
        //        case "ItemPeople":
        //            //SlowOpaciy(personsView);
        //            FrameMain.Content = personsView;
        //            break;
        //        case "ItemContacts":
        //            //SlowOpaciy(contactsView);
        //            FrameMain.Content = contactsView;
        //            break;
        //        default:
        //            break;
        //    }
        //}

        private void HeadWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void closeWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private async void SlowOpaciy(Page page)
        //{
        //    await Task.Factory.StartNew(() =>
        //    {
        //        for (double i = 1.0; i > 0; i-=0.1)
        //        {
        //            Page currentPage = (Page)FrameMain.Content;
        //            currentPage.Opacity = i;
        //        }

        //        for (double i = 0; i < 1.1; i += 0.1)
        //        {
        //            page.Opacity = i;
        //        }
        //    });
        //}
    }
}
