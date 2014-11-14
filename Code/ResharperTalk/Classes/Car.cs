using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ResharperTalk.Abstractions;
using ResharperTalk.Annotations;

namespace ResharperTalk.Classes
{
    public class Car : IVehicle, INotifyPropertyChanged
    {
        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void SetSpeed(int speed)
        {
            throw new NotImplementedException();
        }

        public void Alert()
        {
            Log("Logging {0}", "something");
        }

        [StringFormatMethod("text")]
        public void Log(string text, params string[] args)
        {
            
        }

        private int _topSpeed;

        public int TopSpeed
        {
            get { return _topSpeed; }
            private set
            {
                if (value == _topSpeed) return;
                _topSpeed = value;
                OnPropertyChanged();
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}