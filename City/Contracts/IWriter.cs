﻿namespace City.Contracts
{
    public interface IWriter
    {
        void Print(string msg, params object[] args);
    }
}