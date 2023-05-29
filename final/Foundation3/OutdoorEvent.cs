
public class OutdoorEvent : Event
    {
        private string WeatherStatement;

        public OutdoorEvent(string title, string description, DateTime date, DateTime time, Address address, string weatherStatement) : base(title, description, date, time, address)
        {
            this.WeatherStatement = weatherStatement;
        }
        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nWeather: {WeatherStatement}";
        }
    }