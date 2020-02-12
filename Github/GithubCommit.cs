using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Starship.Integration.Github {
    public class GithubCommit {
        
        public GithubCommit() {
            Files = new List<GithubFile>();
        }

        public GithubUser Author { get; set; }

        [JsonProperty("commit")]
        public GithubCommitDetails Details { get; set; }

        public List<GithubFile> Files { get; set; }
    }
}