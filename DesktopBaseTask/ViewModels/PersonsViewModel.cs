using DesktopBaseTask.Models;
using DesktopBaseTask.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopBaseTask.ViewModels
{
    public class PersonsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get => _persons;
            set
            {
                _persons = value;
                OnPropertyChanged();
            }
        }

        private string _filterName;
        public string FilterName
        {
            get => _filterName;
            set
            {
                _filterName = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _filterNameCommand;
        public RelayCommand FilterNameCommand
        {
            get => _filterNameCommand ??
                (new RelayCommand((obj) =>
                {
                    int sum = 0;
                    int count = 0;
                    foreach (var item in Persons)
                    {
                        if (item.Name == FilterName)
                        {
                            sum += item.Age;
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        MessageBox.Show($"Средний возраст: {sum / count}");
                    }
                    else
                    {
                        MessageBox.Show($"Никого с таким именем не нашлось!");
                    }
                    
                }));
        }

        public PersonsViewModel()
        {
            Persons = new LoadDataJson().GetPersons();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
