﻿using Newtonsoft.Json;

namespace PROBot
{
    public class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string HardwareHash { get; set; }
        public string Server { get; set; }
        public Socks Socks { get; set; }

        [JsonIgnore]
        public string FileName { get; set; }

        public Account(string name)
        {
            Name = name;
            Socks = new Socks();
        }
    }
}