using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace DiamonApp.Classes
{
    /// <summary>
    /// Класс для логирования событий в приложении
    /// </summary>
    public static class Logger
    {
        // Путь к папке с логами
        private static readonly string LogDirectory;

        static Logger()
        {
            string appDirectory = Application.StartupPath;
            LogDirectory = Path.Combine(appDirectory, "Logs");

            // Создаём папку, если её нет
            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }
        }

        /// <summary>
        /// Получить путь к файлу лога для сегодняшней даты
        /// </summary>
        private static string GetLogFilePath()
        {
            string fileName = $"log_{DateTime.Now:yyyy-MM-dd}.txt";
            return Path.Combine(LogDirectory, fileName);
        }

        /// <summary>
        /// Записать сообщение в лог
        /// </summary>
        private static void WriteLog(string level, string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} [{level}] {message}";

            File.AppendAllText(GetLogFilePath(), logEntry + Environment.NewLine);
        }

        /// <summary>
        /// Сообщение о действии пользователя
        /// </summary>
        public static void UserAction(string userLogin, string action)
        {
            WriteLog("USER", $"Пользователь '{userLogin}' выполнил: {action}");
        }

        /// <summary>
        /// Открыть папку с логами в проводнике
        /// </summary>
        public static void OpenLogFolder()
        {
            System.Diagnostics.Process.Start("explorer.exe", LogDirectory);
        }
    }
}