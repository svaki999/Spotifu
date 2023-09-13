namespace Spotifu
{
    class Song
    {
        public string Title { get; }
        public List<Artist> Artists { get; }

        public Song(string title)
        {
            Title = title;
            Artists = new List<Artist>();
        }

        public void AddArtist(Artist artist)
        {
            Artists.Add(artist);
        }
    }

}
