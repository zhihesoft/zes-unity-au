using System.Collections.Generic;

namespace Au
{
    /// <summary>
    /// Simple log system
    /// </summary>
    public class Logger
    {
        private static Dictionary<string, Logger> loggers = new Dictionary<string, Logger>();

        /// <summary>
        /// Get a Logger from type
        /// </summary>
        /// <typeparam name="T">Class Type</typeparam>
        /// <returns>Logger</returns>
        public static Logger GetLogger<T>()
        {
            return GetLogger(typeof(T).FullName);
        }

        /// <summary>
        /// Get a Logger from name
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>Logger</returns>
        public static Logger GetLogger(string name)
        {
            if (loggers.TryGetValue(name, out Logger logger))
            {
                return logger;
            }
            logger = new Logger(name);
            loggers.Add(name, logger);
            return logger;
        }

        private Logger(string name)
        {
            this.name = name;
        }

        private string name;

        public void Info(object message)
        {
            UnityEngine.Debug.Log($"[INFO] [{name}] {message}");
        }

        public void Debug(object message)
        {
            UnityEngine.Debug.Log($"[DEBUG] [{name}] {message}");
        }

        public void Warn(object message)
        {
            UnityEngine.Debug.LogWarning($"[WARN] [{name}] {message}");
        }

        public void Error(object message)
        {
            UnityEngine.Debug.LogError($"[ERROR] [{name}] {message}");
        }
    }
}
