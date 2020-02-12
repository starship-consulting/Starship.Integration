using System;
using System.Linq;
using Newtonsoft.Json;

namespace Starship.Integration.Github {
    public class GithubFile {

        public string GetFilename() {
            return Path.Split('/').Last();
        }
        
        [JsonProperty("Filename")]
        public string Path { get; set; }

        public int Additions { get; set; }

        public int Deletions { get; set; }

        public int Changes { get; set; }

        public string Status { get; set; }

        public string Patch { get; set; }

        public string Sha { get; set; }
    }
}