﻿namespace MapleWebServer.Constants
{
    public static class Paths
    {
        public static readonly string SOLUTION_DIR = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../.."));
        public static readonly string DATA = Path.Combine(SOLUTION_DIR, "MapleWebServer/Data");
    }
}