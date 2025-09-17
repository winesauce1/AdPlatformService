using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AdPlatformService
    {
        private List<AdPlatform> _platforms = new();

        public void LoadFromFile(string[] lines)
        {
            var newPlatforms = new List<AdPlatform>();

            foreach (var line in lines)
            {
                var parts = line.Split(':');
                if (parts.Length != 2) continue;

                var name = parts[0].Trim();
                var locations = parts[1].Split(',').Select(l => l.Trim()).ToList();

                newPlatforms.Add(new AdPlatform { Name = name, Locations = locations });
            }

            _platforms = newPlatforms;
        }

        public List<string> FindPlatforms(string location)
        {
            return _platforms
                .Where(p => p.Locations.Any(loc => location.StartsWith(loc)))
                .Select(p => p.Name)
                .Distinct()
                .ToList();
        }
    }
}
