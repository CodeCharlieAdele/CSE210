
public class LectureEvent : Event
    {
        private string SpeakerName;
        private int Capacity;

        public LectureEvent(string title, string description, DateTime date, DateTime time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
        {
            this.SpeakerName = speakerName;
            this.Capacity = capacity;
        }

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nSpeaker: {SpeakerName}\nCapacity: {Capacity}";
        }
    }