using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Plugin.SimpleLogger
{
    /// <summary>
    /// Interface for SimpleLogger
    /// </summary>
    public class SimpleLoggerImplementation : ISimpleLogger
    {
        private string _datetimeFormat = "G";
        private CultureInfo _cultureInfo;
        private string _filename;
        private string _foldername;
        private string _defaultFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private string _logPath => Path.Combine(_defaultFolder, _foldername, _filename);
        private object lockObject = new object();

        /// <summary>
        /// You can pass culture string and datetime format
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="foldername"></param>
        /// <param name="cultureString"></param>
        /// <param name="datetimeFormat"></param>
        public SimpleLoggerImplementation(string filename = "log.txt", string foldername = "", string cultureString = "en-US", string datetimeFormat = "G")
        {
            _datetimeFormat = datetimeFormat;
            _filename = filename;
            _foldername = foldername;
            _cultureInfo = new CultureInfo(cultureString);
            CheckFolderExists();
        }

        private void CheckFolderExists()
        {
            if(string.IsNullOrEmpty(_foldername)) return;
            
            var folderPath = Path.Combine(_defaultFolder, _foldername);
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }

        public void Warn(string text)
        {
            Log(text, LogType.Warn);
        }

        public void Error(string text)
        {
            Log(text, LogType.Error);
        }

        public void Critical(string text)
        {
            Log(text, LogType.Critical);
        }

        public void Info(string text)
        {
            Log(text, LogType.Info);
        }

        private void Log(string text, LogType logType)
        {
            try
            {
                lock (lockObject)
                {
                    var formattedString = $"{logType}: {text} {DateTime.Now.ToString(_datetimeFormat, _cultureInfo)}" + Environment.NewLine;
                    File.AppendAllText(_logPath, formattedString, Encoding.UTF8);
                }
            }
            catch (Exception)
            {
                
            }
        }

        public string GetLogText()
        {
            try
            {
                return File.ReadAllText(_logPath);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private enum LogType
        {
            Warn, Critical, Error, Info
        }
    }
}
