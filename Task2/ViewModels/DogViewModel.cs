using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class DogViewModel : INotifyPropertyChanged
    {
        private Dog _dog;

        private string _speedText;
        public string SpeedTextDog
        {
            get { return _speedText; }
            set
            {
                _speedText = value;
                OnPropertyChanged();
            }
        }


        public DogViewModel()
        {
            _dog = new Dog();
        }

        public int Speed
        {
            get { return _dog.Speed; }
            set
            {
                _dog.Speed = value;
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
            _dog.Move();
            Speed = _dog.Speed;
            SpeedTextDog = $"Скорость: {Speed}";
        }

        public void Stand()
        {
            _dog.Stand();
            Speed = _dog.Speed;
            SpeedTextDog = $"Скорость: {Speed}";
        }

        public string Roar()
        {
            return _dog.Roar();
        }
    }
}
