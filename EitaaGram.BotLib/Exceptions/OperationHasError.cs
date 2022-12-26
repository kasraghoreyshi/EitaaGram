﻿using System;

namespace EitaaGram.BotLib.Exceptions
{
    public class OperationHasError : Exception
    {
        public OperationHasError()
        {
        }

        public OperationHasError(string message) : base(message)
        {
        }

        public OperationHasError(string message, int errorCode) : base($"Error : {message}, Code : {errorCode.ToString()}")
        {
        }
    }
}
