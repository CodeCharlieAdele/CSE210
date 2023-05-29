
public class Video
    {
        // Properties to store video title, author, and length (in seconds)
        public string title { get; }
        public string author { get; }
        public int length { get; }


        public Video(string _title, string _author, int _length)
        {
            title = _title;
            author = _author;
            length = _length;
            comments = new List<Comment>();
        }


        // A List to store comments
        private List<Comment> comments = new List<Comment>();

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public List<Comment> GetComments()
        {
            return comments;
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }
    }