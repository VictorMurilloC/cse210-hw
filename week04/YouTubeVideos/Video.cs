public class Video {
    public string _title;
    public string _author;
    public int _secondsLength;
    public List<Comment> _comments;

    public Video(string title, string author, int secondsLength) {
        _title = title;
        _author = author;
        _secondsLength = secondsLength;
        _comments = new List<Comment>();
    }

    public void AddComment(string userName, string comment) {
        _comments.Add(new Comment(userName, comment));
    }

    public int GetNumberOfComments() {
        return _comments.Count;
    }

}