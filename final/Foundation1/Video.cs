class Video {
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds) {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public string GetTitle() {
        return _title;
    }

    public string GetAuthor() {
        return _author;
    }

    public int GetLengthInSeconds() {
        return _lengthInSeconds;
    }

    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }

    public int GetCommentCount() {
        return _comments.Count;
    }

    public List<Comment> GetComments() {
        return new List<Comment>(_comments);
    }
}