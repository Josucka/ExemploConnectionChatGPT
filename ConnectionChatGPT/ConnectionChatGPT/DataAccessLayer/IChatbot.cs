﻿namespace ConnectionChatGPT.DataAccessLayer
{
    public interface IChatbot
    {
        Task<string> GetResponse(string prompt);
    }
}
