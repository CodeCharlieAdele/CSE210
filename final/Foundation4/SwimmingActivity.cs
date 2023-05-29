
class SwimmingActivity : Activity
    {
        private int Laps;

        public SwimmingActivity(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            this.Laps = laps;
        }

        public override double GetDistance()
        {
            // Each lap is 50 meters
            double distanceKm = Laps * 50.0 / 1000.0;
            double distanceMiles = distanceKm * 0.62;
            return distanceMiles;
        }

        public override string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} Swimming ({Minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }