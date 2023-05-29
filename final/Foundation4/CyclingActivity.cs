
public class CyclingActivity : Activity
    {
        private double Distance;

        public CyclingActivity(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            this.Distance = distance;
        }

        public override double GetDistance()
        {
            return Distance;
        }

        public override string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} Cycling ({Minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }