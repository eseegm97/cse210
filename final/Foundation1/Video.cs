class Video {
    private string title;
    private string author;
    private int lengthInSeconds;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds) {
        this.title = title;
        this.author = author;
        this.lengthInSeconds = lengthInSeconds;
    }

    public string GetTitle() {
        return title;
    }

    public string GetAuthor() {
        return author;
    }

    public int GetLengthInSeconds() {
        return lengthInSeconds;
    }

    public void AddComment(Comment comment) {
        comments.Add(comment);
    }

    public int GetCommentCount() {
        return comments.Count;
    }

    public List<Comment> GetComments() {
        return new List<Comment>(comments);
    }
}