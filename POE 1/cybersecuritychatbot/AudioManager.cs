using System;
using System.IO;
using System.Runtime.InteropServices;

namespace CybersecurityBot
{
    public static class AudioManager
    {
        public static void PlayGreeting()
        {
            try
            {
                if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    DisplayManager.PrintColored(
                        "[Audio] Sound playback is only supported on Windows. Skipping.",
                        ConsoleColor.DarkYellow);
                    return;
                }

                string audioPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

                if (File.Exists(audioPath))
                {
                    using var player = new System.Media.SoundPlayer(audioPath);
                    player.PlaySync();
                }
                else
                {
                    DisplayManager.PrintColored(
                        "[Audio] Voice greeting file not found. Skipping.",
                        ConsoleColor.DarkYellow);
                }
            }
            catch (Exception ex)
            {
                DisplayManager.PrintColored(
                    $"[Audio Error] {ex.Message}",
                    ConsoleColor.Red);
            }
        }
    }
}