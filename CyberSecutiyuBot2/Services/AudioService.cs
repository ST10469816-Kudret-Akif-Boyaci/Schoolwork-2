using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
//using System.Windows.Extensions;

namespace CyberSecurityBot.Services
{
    internal class AudioService
    {

        private string audiopath;

        public AudioService()
        {
            audiopath = Path.Combine(AppContext.BaseDirectory, "assets", "greeting.wav");
        }

        //  method to play the audio

        public void Playgreeting()
        {
            //use try and catch to check if the file exists so that we can play it
            try
            {
                //conditional statement to check the file
                if (File.Exists(audiopath))
                {

                    SoundPlayer soundPlayer1 = new SoundPlayer();
                    soundPlayer1.PlaySync();
                }
                else
                {
                    Console.WriteLine("voice greeting file not found");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Audio error: {ex.Message}");

            }
        }
    }
}
