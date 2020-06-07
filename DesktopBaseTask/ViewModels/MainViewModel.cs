using DesktopBaseTask.Views;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopBaseTask.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        PersonsView personsView;
        ContactsView contactsView;

        Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }

        double _frameOpacity;
        public double FrameOpacity
        {
            get => _frameOpacity;
            set
            {
                _frameOpacity = value;
                OnPropertyChanged();
            }
        }

        RelayCommand _selectedPageCommand;
        public RelayCommand SelectedPageCommand
        {
            get => _selectedPageCommand ??
                (_selectedPageCommand = new RelayCommand((obj) =>
                {
                    if (obj != null)
                    {
                        switch (((ListViewItem)((ListView)obj).SelectedItem).Name)
                        {
                            case "ItemPeople":
                                SlowOpacity(personsView);
                                break;
                            case "ItemContacts":
                                SlowOpacity(contactsView); 
                                break;
                            default:
                                break;
                        }
                    }
                }));
        }

        private async void SlowOpacity(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0; i -= 0.01)
                {
                    FrameOpacity = i;
                    Thread.Sleep(1);
                }
                CurrentPage = page;
                Thread.Sleep(100);
                for (double i = 0; i < 1.1; i += 0.01)
                {
                    FrameOpacity = i;
                    Thread.Sleep(1);
                }
            });
        }


        public MainViewModel()
        {
            personsView = new PersonsView();
            contactsView = new ContactsView();

            SlowOpacity(personsView);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
