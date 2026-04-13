namespace CybersecurityBot
{
    public static class ResponseEngine
    {
        private static readonly Dictionary<string, string> Responses = new()
        {
            ["how are you"] = "I'm running smoothly and fully patched! 😄 Ready to help you stay secure online.",
            ["your purpose"] = "My purpose is to raise cybersecurity awareness! I can teach you about passwords, phishing, safe browsing, and more.",
            ["what can i ask"] = "You can ask me about:\n  • Password safety\n  • Phishing\n  • Safe browsing\n  • 2FA\n  • Malware\n  • Social engineering",
            ["password"] = "🔑 Password Tips:\n  • Use 12+ characters with letters, numbers & symbols.\n  • Never reuse passwords.\n  • Use a password manager.\n  • Avoid personal info in passwords.",
            ["phishing"] = "🎣 Phishing Tips:\n  • Verify sender email addresses.\n  • Hover over links before clicking.\n  • Legit companies never ask for passwords via email.",
            ["browsing"] = "🌐 Safe Browsing:\n  • Look for HTTPS before entering data.\n  • Avoid public Wi-Fi for sensitive tasks.\n  • Consider using a VPN.",
            ["two-factor"] = "🔐 2FA adds a second layer beyond your password. Use an authenticator app over SMS where possible.",
            ["2fa"] = "🔐 Enable 2FA everywhere! Use Google Authenticator or Authy for best security.",
            ["malware"] = "🦠 Malware Protection:\n  • Keep your OS updated.\n  • Use antivirus software.\n  • Don't download from untrusted sources.",
            ["ransomware"] = "💀 Ransomware Prevention:\n  • Back up your data regularly.\n  • Never open unexpected attachments.\n  • Keep software patched.",
            ["social engineering"] = "🎭 Social Engineering:\n  • Be suspicious of urgent requests.\n  • Always verify identities before sharing data.",
        };

        public static string GetResponse(string input)
        {
            string lower = input.ToLower().Trim();
            foreach (var entry in Responses)
            {
                if (lower.Contains(entry.Key))
                    return entry.Value;
            }
            return string.Empty;
        }
    }
}