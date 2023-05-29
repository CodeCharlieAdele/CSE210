
public abstract class Activity
    {
        public DateTime Date { get; set; }
        public int Minutes { get; set; }

        public Activity(DateTime date, int minutes)
        {
            Date = date;
            Minutes = minutes;
        }

        public abstract double GetDistance();

        public virtual double GetSpeed()
        {
            return GetDistance() / (Minutes / 60.0);
        }

        public virtual double GetPace()
        {
            return Minutes / GetDistance();
        }

        public abstract string GetSummary();
    }