﻿using System.IO;

namespace PipiPonaPoster.Source.Model.MainMenu
{
    public class ExcelDatabaseState
    {
        public string Path { get; private set; }
        public string Name { get => new FileInfo(Path).Name; }
        public bool IsRead { get; private set; }

        public ExcelDatabaseState(string path, bool isRead = false)
        {
            Path = path;
            IsRead = isRead;
        }
    }
}
