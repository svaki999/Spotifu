namespace Spotifu
{
    class Artist
    {
        public string Name { get; }
        public List<Album> Albums { get; }

        public Artist(string name)
        {
            Name = name;
            Albums = new List<Album>();
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }
    }
}
