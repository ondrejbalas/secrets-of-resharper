using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using ResharperTalk.Abstractions;
using ResharperTalk.Annotations;

namespace ResharperTalk.Classes
{
    public class Car : IVehicle, INotifyPropertyChanged
    {
        private IEngine _engine;
        private readonly Driver _driver;

        public Car(IEngine engine)
        {
            var myPattern = new Regex("Hello Music \\w+ Code!");
            Engine = engine;
            _driver = new Driver();
        }

        public IEngine Engine
        {
            get { return _engine; }
            set
            {
                if (Equals(value, _engine)) return;
                _engine = value;
                OnPropertyChanged();
            }
        }

        public void Alert()
        {
            throw new System.NotImplementedException();
        }

        public void SetSpeed(int speed)
        {
            throw new System.NotImplementedException();
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }

        public int CurrentSpeed { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}