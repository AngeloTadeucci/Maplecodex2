﻿using Maplecodex2.Data.Models;
using Maplecodex2.Data.Parser;

namespace Maplecodex2.DBSync.Data.Storage
{
    public static class ItemStorage
    {
        private static Dictionary<int, Item> Items { get; set; }

        public static void Init() => Items = ItemParser.Parse();

        public static List<Item> GetAll() => Items.Values.ToList();
    }
}
