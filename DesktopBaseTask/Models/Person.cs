using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DesktopBaseTask.Models
{
    public class Person : INotifyPropertyChanged
    {
        private uint _id;
        public uint ID { 
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
