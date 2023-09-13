using System.Media;

namespace Spotifu.Sound
{
    class Player
    {
        public void PlaySong(Song song)
        {
            Console.WriteLine($"Spiller nu {song.Title}");

            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            string audioFilePath = Path.Combine(appDir, "Sound", "song.wav");
            if (File.Exists(audioFilePath))
            {
                using (SoundPlayer soundPlayer = new SoundPlayer(audioFilePath))
                {
                    soundPlayer.Play();

                    Console.WriteLine("Tryk på en knap for at stoppe afspilningen");
                    Console.ReadKey();

                    soundPlayer.Stop();
                }
            }
            else
            {
                Console.WriteLine("Lydfilen ikke fundet");
            }
        }
    }
}