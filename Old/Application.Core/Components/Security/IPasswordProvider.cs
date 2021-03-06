﻿namespace Application.Components.Security
{
    public interface IPasswordProvider
    {
        bool Match(string password, string hash);

        string GenerateHash(string password);
    }
}
