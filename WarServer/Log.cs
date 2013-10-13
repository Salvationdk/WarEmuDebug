using System;

namespace WarhammerEmu
{
    public static class Log
    {

        private static readonly ConsoleColor warn = ConsoleColor.Red;
        private static readonly ConsoleColor trace = ConsoleColor.Yellow;
        private static readonly ConsoleColor debug = ConsoleColor.Green;


        private static void write(object obj, ConsoleColor color)
        {
            Console.ResetColor();
            Console.ForegroundColor = color;
            Console.WriteLine(obj);
        }
        public static void Debug(object obj)
        {

            string sformat = string.Format("[Debug]: {0}", obj);
            write(sformat, debug);
        }
        public static void Trace(object obj)
        {
            string sformat = string.Format("[Trace]: {0}", obj);
            write(sformat, trace);
        }
        public static void Warn(object obj)
        {
            string sformat = string.Format("[Warn]: {0}", obj);
            write(sformat, warn);
        }
        public static void Error(object obj)
        {
            string sformat = string.Format("[Error]: {0}", obj);
            write(sformat, warn);
        }
        public static void Error(string t, object obj)
        {
            string sformat = string.Format("[Error]: {0} {1}", t, obj);
            write(sformat, warn);
        }
    }
}
