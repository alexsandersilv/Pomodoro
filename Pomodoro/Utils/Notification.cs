using NAudio.Wave;
using System;
using System.IO;

namespace Pomodoro.Utils
{
    internal class Notification
    {
        private byte[] notification = Properties.Resources.notification;

        public void PlayNotification()
        {
            using (var memoryStream = new MemoryStream(notification))
            {
                using (var waveStream = new Mp3FileReader(memoryStream))
                {
                    using (var outputDevice = new WaveOutEvent())
                    {
                        outputDevice.Init(waveStream);
                        outputDevice.Play();

                        while (outputDevice.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
        }
    }
}
