using System;

namespace DbUp.Engine.Output
{
    /// <summary>
    /// A log that writes to the console in a colorful way.
    /// </summary>
    public class ConsoleUpgradeLog : IUpgradeLog
    {
        /// <summary>
        /// Writes an informational message to the log.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WriteInformation(string format, params object[] args)
        {
#if NETPCL
#else
            Write(ConsoleColor.White, format, args);
#endif
        }

        /// <summary>
        /// Writes an error message to the log.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WriteError(string format, params object[] args)
        {
#if NETPCL
#else
            Write(ConsoleColor.Red, format, args);
#endif
        }

        /// <summary>
        /// Writes a warning message to the log.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WriteWarning(string format, params object[] args)
        {
#if NETPCL
#else
            Write(ConsoleColor.Yellow, format, args);
#endif
        }

#if !NETPCL
        private static void Write(ConsoleColor color, string format, object[] args)
        {
#if !MONO
            Console.ForegroundColor = color;
#endif
            Console.WriteLine(format, args);
#if !MONO
            Console.ResetColor();
#endif
        }
#endif
    }
}