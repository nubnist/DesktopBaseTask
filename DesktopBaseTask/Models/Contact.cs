using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBaseTask.Models
{
    public class Contact : INotifyPropertyChanged
    {
        private DateTime _from;
        public DateTime From
        {
            get => _from;
            set
            {
                _from = value;
                OnPropertyChanged();
            }
        }
        private DateTime _to;
        public DateTime To
        {
            get => _to;
            set
            {
                _to = value;
                OnPropertyChanged();
            }
        }
        private uint _member1_ID;
        public uint Member1_ID
        {
            get => _member1_ID;
            set
            {
                _member1_ID = value;
                OnPropertyChanged();
            }
        }
        private uint _member2_ID;
        public uint Member2_ID
        {
            get => _member2_ID;
            set
            {
                _member2_ID = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
