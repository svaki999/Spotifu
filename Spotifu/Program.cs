using Spotifu.Sound;

namespace Spotifu
{
    class Program
    {
        static void Main()
        {
            List<Artist> artists = MusicLibrary.InitializeMusicLibrary();

            // Create a menu to choose an artist
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Spotifu - Vælg en artist");
                for (int i = 0; i < artists.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {artists[i].Name}");
                }
                Console.WriteLine($"{artists.Count + 1}. Exit");

                Console.Write("Indtast dit valg: ");
                string artistChoice = Console.ReadLine();

                if (artistChoice == (artists.Count + 1).ToString())
                {
                    Console.WriteLine("Programmet slukkes");
                    return;
                }

                if (int.TryParse(artistChoice, out int artistIndex) && artistIndex >= 1 && artistIndex <= artists.Count)
                {
                    Artist selectedArtist = artists[artistIndex - 1];

                    // Create a menu to choose an album for the selected artist
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine($"Artist: {selectedArtist.Name} - Vælg et Album:");
                        for (int i = 0; i < selectedArtist.Albums.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {selectedArtist.Albums[i].Title}");
                        }
                        Console.WriteLine($"{selectedArtist.Albums.Count + 1}. Tilbage til Artist");

                        Console.Write("Indtast dit valg: ");
                        string albumChoice = Console.ReadLine();

                        if (albumChoice == (selectedArtist.Albums.Count + 1).ToString())
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
                                for (int i = 0; i < selectedAlbum.Songs.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {selectedAlbum.Songs[i].Title}");
                                }
                                Console.WriteLine($"{selectedAlbum.Songs.Count + 1}. Tilbage til Album");

                                Console.Write("Indtast dit valg: ");
                                string songChoice = Console.ReadLine();

                                if (songChoice == (selectedAlbum.Songs.Count + 1).ToString())
                                {
                                    break;
                                }

                                if (int.TryParse(songChoice, out int songIndex) && songIndex >= 1 && songIndex <= selectedAlbum.Songs.Count)
                                {
                                    Song selectedSong = selectedAlbum.Songs[songIndex - 1];
                                    Player player = new Player();
                                    player.PlaySong(selectedSong);
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
                else
                {
                    Console.WriteLine("Ugyldigt valg.");
                }
            }
        }
    }
}