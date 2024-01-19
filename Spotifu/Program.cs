using Spotifu.Sound;

namespace Spotifu
{
    class Program
    {
        static void Main()
        {
            

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