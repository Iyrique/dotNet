using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class TurtleViewModel : INotifyPropertyChanged
    {
        private Turtle _turtle;

        private string _speedText;
        public string SpeedTextTurtle
        {
            get { return _speedText; }
            set
            {
                _speedText = value;
                OnPropertyChanged();
            }
        }


        public TurtleViewModel()
        {
            _turtle = new Turtle();
        }

        public int Speed
        {
            get { return _turtle.Speed; }
            set
            {
                _turtle.Speed = value;
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
            _turtle.Move();
            Speed = _turtle.Speed;
            SpeedTextTurtle = $"Скорость: {Speed}";
        }

        public void Stand()
        {
            _turtle.Stand();
            Speed = _turtle.Speed;
            SpeedTextTurtle = $"Скорость: {Speed}";
        }
    }
}
