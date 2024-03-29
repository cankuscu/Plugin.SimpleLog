﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Plugin.SimpleLogger
{
    public interface ISimpleLogger
    {
        void Warn(string text);
        void Error(string text);
        void Critical(string text);
        void Info(string text);

        string GetLogText();
        void Configure(string filename = "SimpleLogger.txt",  string foldername = "SimpleLog", string cultureInfo = "en-US", string datetimeFormat = "G");
        string GetLogPath();
    }
}
