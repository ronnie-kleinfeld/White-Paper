namespace BE.Log
{
    public enum LogLevelEnum
    {
        /// <summary>
        /// Fine grained info events that are most useful to debug an application
        /// </summary>
        Debug = 0,

        /// <summary>
        /// Info messages that highlight the progress of the app at grained level
        /// </summary>
        Info = 1,

        /// <summary>
        /// Potentially harmful situations
        /// </summary>
        Warning = 2,

        /// <summary>
        /// Error events that might still allow the app to continue running
        /// </summary>
        Error = 3,

        /// <summary>
        /// Very severe error events that will presumably lead. The app to abort
        /// </summary>
        Fatal = 4
    }
}