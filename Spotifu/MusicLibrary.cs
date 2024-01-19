namespace Spotifu
{
    public class MusicLibrary
    {
        public static List<Artist> InitializeMusicLibrary()
        {
            // Create artists
            Artist artist1 = new Artist("Kendrick Lamar");
            Artist artist2 = new Artist("J. Cole");
            Artist artist3 = new Artist("Drake");

            // Create albums for Kendrick Lamar
            Album album1 = new Album("DAMN.");
            Album album2 = new Album("To Pimp a Butterfly");

            // Create albums for J. Cole
            Album album3 = new Album("2014 Forest Hills Drive");
            Album album4 = new Album("KOD");

            // Create albums for Drake
            Album album5 = new Album("Scorpion");
            Album album6 = new Album("Views");

            // Create songs for Kendrick Lamar's albums
            Song song1 = new Song("HUMBLE.");
            Song song2 = new Song("DNA.");
            Song song3 = new Song("LOYALTY. (feat. Rihanna)");
            Song song4 = new Song("No Role Modelz");
            Song song5 = new Song("Love Yourz");

            // Create songs for J. Cole's albums
            Song song6 = new Song("Intro");
            Song song7 = new Song("Fire Squad");
            Song song8 = new Song("Lights Please");
            Song song9 = new Song("Immortal");
            Song song10 = new Song("ATM");

            // Create songs for Drake's albums
            Song song11 = new Song("God's Plan");
            Song song12 = new Song("In My Feelings");
            Song song13 = new Song("Nonstop");
            Song song14 = new Song("Controlla");
            Song song15 = new Song("Hotline Bling");

            // Add songs to albums
            album1.AddSong(song1);
            album1.AddSong(song2);
            album1.AddSong(song3);
            album1.AddSong(song4);
            album2.AddSong(song5);

            album3.AddSong(song6);
            album3.AddSong(song7);
            album4.AddSong(song8);
            album4.AddSong(song9);
            album4.AddSong(song10);

            album5.AddSong(song11);
            album5.AddSong(song12);
            album6.AddSong(song13);
            album6.AddSong(song14);
            album6.AddSong(song15);

            // Add albums to artists
            artist1.AddAlbum(album1);
            artist1.AddAlbum(album2);

            artist2.AddAlbum(album3);
            artist2.AddAlbum(album4);

            artist3.AddAlbum(album5);
            artist3.AddAlbum(album6);

            return new List<Artist> { artist1, artist2, artist3 };
        }
    }
}
