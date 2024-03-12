using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PantherViewModel : INotifyPropertyChanged
    {
        private Panther _panther;

        private string _speedText;
        public string SpeedText
        {
            get { return _speedText; }
            set
            {
                _speedText = value;
                OnPropertyChanged();
            }
        }


        public PantherViewModel()
        {
            _panther = new Panther();
        }

        public int Speed
        {
            get { return _panther.Speed; }
            set
            {
                _panther.Speed = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Move()
        {
            _panther.Move();
            Speed = _panther.Speed;
            SpeedText = $"Скорость: {Speed}";
        }

        public void Stand()
        {
            _panther.Stand();
            Speed = _panther.Speed;
            SpeedText = $"Скорость: {Speed}";
        }


        public string Roar()
        {
            return _panther.Roar();
        }

        public string ClimbTree()
        {
            return _panther.ClimbTree();
        }
    }
}
