using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    public class Logger
    {

        #region Singleton


        public static Logger _instance;

        public static Logger GetInstance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }
        private Logger()
        {
            LogFileName = "Example";
            LogFileExtension = ".log";
        }

        #endregion

        public StreamWriter Writer { get; set; }

        private string _LogPath;

        public string LogPath
        {
            get { return _LogPath ?? (_LogPath = AppDomain.CurrentDomain.BaseDirectory); }
            set { _LogPath = value; }
        } 

        public string LogFileName { get; set; }

        public string LogFileExtension { get; set; }

        public string LogFile { get { return LogFileName + LogFileExtension; } }

        public string LogFullPath { get { return Path.Combine(LogPath, LogFile); } }

        public bool LogExists { get { return File.Exists(LogFullPath); } }

        public void WriteLineToLog(string inLogMessage)
        {
            WriteToLog(inLogMessage + Environment.NewLine);
        }

        public void WriteToLog(string inLogMessage)
        {
            if (!Directory.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
            }
            if (Writer == null)
            {
                Writer = new StreamWriter(LogFullPath, true);
            }

            Writer.Write(inLogMessage);
            Writer.Flush();
        }

        public static void WriteLine(string inLogMessage)
        {
            _instance.WriteLineToLog(inLogMessage);
        }

        public static void Write(string inLogMessage)
        {
            _instance.WriteToLog(inLogMessage);
        }
    }
}
