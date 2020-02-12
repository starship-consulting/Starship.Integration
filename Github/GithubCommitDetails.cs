using System;
using System.Linq;

namespace Starship.Integration.Github {
    public class GithubCommitDetails {

        public string GetReferenceId() {
            return Url.Split("/").Last();
        }

        public GitCommitPerson Author { get; set; }

        public GitCommitPerson Committer { get; set; }

        public string Message { get; set; }

        public string Url { get; set; }
    }
}