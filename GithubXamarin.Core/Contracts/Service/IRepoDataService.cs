﻿using System.Collections.ObjectModel;
using Octokit;
using System.Threading.Tasks;


namespace GithubXamarin.Core.Contracts.Service
{
    public interface IRepoDataService
    {
        Task<Octokit.Repository> GetRepository(long repositoryId, GitHubClient githubClient);

        Task<ObservableCollection<Octokit.Repository>> GetAllRepositoriesForCurrentUser(GitHubClient authorizedGitHubClient);

        Task<ObservableCollection<Octokit.Repository>> GetAllRepositoriesForUser(string login, GitHubClient gitHubClient);

        Task<ObservableCollection<Octokit.Repository>> SearchRepositories(string searchTerm, GitHubClient githubClient);

        Task<Octokit.Repository> ForkRepository(long repositoryId, GitHubClient authorizedGithubClient);

        Task<bool> StarRepository(string repositoryOwner, string repositoryName, GitHubClient authorizedGithubClient);

        Task<bool> UnStarRepository(string repositoryOwner, string repositoryName, GitHubClient authorizedGithubClient);

        Task<Octokit.Repository> CreateRepository(NewRepository newRepositoryDetails, GitHubClient authorizedGitHubClient);

        Task<Octokit.Repository> UpdateRepository(long repositoryId, RepositoryUpdate updatedRepositoryDetails,
            GitHubClient authorizedGitHubClient);

        Task<bool> DeleteRepository(long repositoryId, GitHubClient authorizedGithubClient);

    }
}
