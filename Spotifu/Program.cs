using Spotifu.Sound;

namespace Spotifu
{
    class Program
    {
        static void Main()
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

            // Create a menu to choose an artist
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Spotifu - Vælg en artist");
                Console.WriteLine("1. Kendrick Lamar");
                Console.WriteLine("2. J. Cole");
                Console.WriteLine("3. Drake");
                Console.WriteLine("4. Exit");

                Console.Write("Indtast dit valg: ");
                string artistChoice = Console.ReadLine();

                if (artistChoice == "4")
                {
                    Console.WriteLine("Programmet slukkes");
                    return;
                }

                Artist selectedArtist = null;

                switch (artistChoice)
                {
                    case "1":
                        selectedArtist = artist1;
                        break;
                    case "2":
                        selectedArtist = artist2;
                        break;
                    case "3":
                        selectedArtist = artist3;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg.");
                        break;
                }

                if (selectedArtist != null)
                {
                    // Create a menu to choose an album for the selected artist
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Artist: {selectedArtist.Name} - Vælg et Album:");
                        int albumCount = 1;

                        foreach (var album in selectedArtist.Albums)
                        {
                            Console.WriteLine($"{albumCount}. {album.Title}");
                            albumCount++;
                        }

                        Console.WriteLine($"{albumCount}. Tilbage til Artist");

                        Console.Write("Indtast dit valg: ");
                        string albumChoice = Console.ReadLine();

                        if (albumChoice == albumCount.ToString())
                        {
                            break;
                        }

                        if (int.TryParse(albumChoice, out int albumIndex) && albumIndex >= 1 && albumIndex <= selectedArtist.Albums.Count)
                        {
                            Album selectedAlbum = selectedArtist.Albums[albumIndex - 1];

                            // Create a menu to choose a song from the selected album
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine($"Vælg en sang fra: {selectedArtist.Name} - {selectedAlbum.Title}");
                                int songCount = 1;

                                foreach (var song in selectedAlbum.Songs)
                                {
                                    Console.WriteLine($"{songCount}. {song.Title}");
                                    songCount++;
                                }

                                Console.WriteLine($"{songCount}. Tilbage til Album");

                                Console.Write("Indtast dit valg: ");
                                string songChoice = Console.ReadLine();

                                if (songChoice == songCount.ToString())
                                {
                                    break;
                                }

                                if (int.TryParse(songChoice, out int songIndex) && songIndex >= 1 && songIndex <= selectedAlbum.Songs.Count)
                                {
                                    Player player = new Player();
                                    player.PlaySong(selectedAlbum.Songs[songIndex - 1]);
                                }
                                else
                                {
                                    Console.WriteLine("Ugyldigt valg. Prøv igen");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt valg. Prøv igen");
                        }
                    }
                }
            }
        }
    }
}