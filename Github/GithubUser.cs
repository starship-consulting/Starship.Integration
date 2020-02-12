using System;

namespace Starship.Integration.Github {
    public class GithubUser {

        public string Login { get; set; }

        public long Id { get; set; }

        public string Url { get; set; }

        public string Type { get; set; }

        public DateTime Date { get; set; }
    }
}