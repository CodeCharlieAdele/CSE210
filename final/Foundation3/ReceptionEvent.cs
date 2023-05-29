
    public class ReceptionEvent : Event
    {
        private string RsvpEmail;

        public ReceptionEvent(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail) : base(title, description, date, time, address)
        {
            this.RsvpEmail = rsvpEmail;
        }
        
        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nRSVP Email: {RsvpEmail}";
        }
    }