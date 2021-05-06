using ClassLibrary;
using System.ComponentModel;

namespace Lab2_UI_V2
{
    class DataItemChangedEvent : IDataErrorInfo, INotifyPropertyChanged
    {
        float xCoord, imagineValue, yCoord, realValue;
        public DataItemChangedEvent(ref V2DataCollection dataItems)
        {
            collection = dataItems;
        }
        V2DataCollection collection;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string proChange = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(proChange));
        }
        public float X
        {
            get { return xCoord; }
            set
            {
                xCoord = value;
                OnPropertyChanged("X");
                OnPropertyChanged("Y");
            }
        }

        public float Y
        {
            get { return yCoord; }
            set
            {
                yCoord = value;
                OnPropertyChanged("Y");
                OnPropertyChanged("X");
            }
        }

        public float Real
        {
            get { return realValue; }
            set
            {
                realValue = value;
                OnPropertyChanged("Real");
                OnPropertyChanged("Imagine");
            }
        }

        public float Imagine
        {
            get { return imagineValue; }
            set
            {
                imagineValue = value;
                OnPropertyChanged("Imagine");
                OnPropertyChanged("Real");
            }
        }

        public string this[string index]
        {
            get
            {
                string _error = null;
                switch (index)
                {
                    case "X":
                        foreach (DataItem item in collection.dataItems)
                        {
                            if (item.Vector.X == X && item.Vector.Y == Y)
                            {
                                _error = "Coordinates already exist";
                                break;
                            }
                        }
                        break;
                    case "Y":
                        foreach (DataItem item in collection.dataItems)
                        {
                            if (item.Vector.X == X && item.Vector.Y == Y)
                            {
                                _error = "Coordinates already exist";
                                break;
                            }
                        }
                        break;

                    case "Real":
                        if (Real == 0 || Imagine == 0)
                        {
                            _error = "Modulus cannot be zero";
                        }
                        break;
                    case "Imagine":
                        if (Real == 0 || Imagine == 0)
                        {
                            _error = "Modulus cannot be zero";
                        }
                        break;
                    default:
                        break;
                }
                return _error;
            }
        }

        public string Error
        {
            get { return "Error:"; }
            //set { _error = value; }
        }

        public void Add()
        {
            collection.Add(new DataItem(new System.Numerics.Vector2(X, Y),
                           new System.Numerics.Complex(Real, Real)));
            OnPropertyChanged("X");
            OnPropertyChanged("Real");
            OnPropertyChanged("Y");
            OnPropertyChanged("Imagine");

        }
    }
}
