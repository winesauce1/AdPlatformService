﻿namespace WebApplication1.Models
{
    public class AdPlatform
    {
        public string Name { get; set; }
        public List<string> Locations { get; set; } = new();
    }
}
