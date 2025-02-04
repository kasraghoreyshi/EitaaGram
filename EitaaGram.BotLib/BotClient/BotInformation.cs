﻿namespace EitaaGram.Bot.BotClient
{
    internal static class BotInformation
    {
        private static string Token;

        public static void SetToken(string token)
        {
            Token = token;
        }

        public static string GetToken()
        {
            return Token;
        }

        public static string GetAPIURL(string Method)
        {
            return $"https://eitaayar.ir/api/{Token}/{Method}";
        }

    }
}
