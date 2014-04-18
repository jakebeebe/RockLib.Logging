﻿using System;
using System.Threading.Tasks;

namespace Rock.Logging
{
    public class ConsoleLogProvider : LogProviderBase
    {
        public ConsoleLogProvider(ILogFormatterFactory logFormatterFactory)
            : base(logFormatterFactory)
        {
        }

        protected override Task Write(string formattedLogEntry)
        {
            Console.WriteLine(formattedLogEntry);
            return _completedTask;
        }
    }
}