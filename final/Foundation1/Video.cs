
public class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int Length { get; }

        public Video(string _title, string _author, int _length)
        {
            Title = _title;
            Author = _author;
            Length = _length;
            comments = new List<Comment>();
        }

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