using DesktopBaseTask.Models;
using DesktopBaseTask.Services;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Effects;

namespace DesktopBaseTask.ViewModels
{
    public class ContactsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set
            {
                _contacts = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Contact> _currentContacts;
        public ObservableCollection<Contact> CurrentContacts
        {
            get => _currentContacts;
            set
            {
                _currentContacts = value;
                OnPropertyChanged();
            }
        }

        DateTime _startDate;
        public DateTime StartDate
        {
            get => _startDate;
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }

        DateTime _endDate;
        public DateTime EndDate
        {
            get => _endDate;
            set
            {
                _endDate = value;
                OnPropertyChanged();
            }
        }

        RelayCommand _filterCommand;
        public RelayCommand FilterCommand
        {
            get => _filterCommand ??
                (_filterCommand = new RelayCommand((obj) =>
                {
                        FilterContacts();
                }));
        }


        RelayCommand _resetFilterCommand;
        public RelayCommand ResetFilterCommand
        {
            get => _resetFilterCommand ??
                (_resetFilterCommand = new RelayCommand((obj) =>
                {
                    CurrentContacts = Contacts;
                }));
        }

        /// <summary>
        /// Фильтрует контакты по условиям
        /// </summary>
        private async void FilterContacts()
        {
            await Task.Factory.StartNew(() =>
            {
                ObservableCollection<Contact> filterContacts = new ObservableCollection<Contact>();
                foreach (var item in Contacts)
                {
                    if (item.From > StartDate && item.To < EndDate && item.To.Subtract(item.From).TotalMinutes >= 5)
                    {
                        filterContacts.Add(item);
                    }
                }
                CurrentContacts = filterContacts;
            });
        }

        public ContactsViewModel()
        {
            Contacts = new LoadDataJson().GetContacts();
            CurrentContacts = Contacts;
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
