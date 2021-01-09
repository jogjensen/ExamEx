using System;
using System.Collections.Generic;
using System.Text;

namespace EnviromentModelLib.model
{
    public class Measurement
    {

        private int _id;
        private double _pressure;
        private double _humidity;
        private double _temperature;
        private DateTime _timeStamp;

        public Measurement()
        { }

        public Measurement(int id, double pressure, double humidity, double temperature, DateTime timeStamp)
        {
            _id = id;
            _pressure = pressure;
            _humidity = humidity;
            _temperature = temperature;
            _timeStamp = timeStamp;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Pressure
        {
            get { return _pressure; }
            set { _pressure = value; }
        }

        public double Humidity
        {
            get { return _humidity; }
            set { _humidity = value; }
        }

        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Pressure)}: {Pressure}, {nameof(Humidity)}: {Humidity}, {nameof(Temperature)}: {Temperature}, {nameof(TimeStamp)}: {TimeStamp}";
        }
    }
}
