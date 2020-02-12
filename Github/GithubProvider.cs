using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit;

namespace Starship.Integration.Github {
    public class GithubProvider {

        public GithubProvider(string username, string email, string password) {
            Client = new GitHubClient(new ProductHeaderValue(username));
            Client.Credentials = new Credentials(email, password);
        }

        public async Task<IReadOnlyList<GitHubCommit>> GetCommitsAsync(long repositoryId) {
            return await Client.Repository.Commit.GetAll(repositoryId);
        }

        public async Task<GitHubCommit> GetCommit(long repositoryId, string reference) {
            return await Client.Repository.Commit.Get(repositoryId, reference);
        }

        public async Task<Blob> GetFile(long repositoryId, string shaReference) {
            return await Client.Git.Blob.Get(repositoryId, shaReference);
        }

        /*public async Task<IReadOnlyList<GitHubCommit>> GetCommitsByAuthorAsync(long repositoryId) {
            var commits = await GetCommitsAsync(repositoryId);
            return commits.Where(each => each.Committer)
        }*/

        private GitHubClient Client { get; set; }
    }
}