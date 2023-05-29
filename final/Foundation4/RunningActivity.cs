
class RunningActivity : Activity
    {
        private double Distance;

        public RunningActivity(DateTime date, int minutes, double miles) : base(date, minutes)
        {
            this.Distance = miles;
        }

        public override double GetDistance()
        {
            return this.Distance;
        }

        public override string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} Running ({Minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }