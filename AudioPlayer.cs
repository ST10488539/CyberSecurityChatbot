using System;
using System.Media;

namespace CyberSecurityChatbot
{
    class AudioPlayer
    {
        public void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Audio file not found.");
            }
        }
    }
}