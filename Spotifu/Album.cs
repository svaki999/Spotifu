namespace Spotifu
{
    class Album
    {
        public string Title { get; }
        public List<Song> Songs { get; }

        public Album(string title)
        {
            Title = title;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
    }
}
