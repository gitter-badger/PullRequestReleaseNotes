﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PullRequestReleaseNotes.Models
{
    public class PullRequestDto
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public List<string> Labels { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? MergedAt { get; set; }
        public string Author { get; set; }
        public string AuthorUrl { get; set; }
        public string Url { get; set; }
        public string BaseCommitSha { get; set; }
        public string MergeCommitSha { get; set; }

        public List<string> Categories(string categoryPrefix, Dictionary<string, string> categoryDescriptions)
        {
            return Labels.Where(l => l.StartsWith(categoryPrefix)).ToList()
                .Select(category => categoryDescriptions[category.Replace(categoryPrefix, string.Empty)]).ToList();
        }

        public bool Highlighted(List<string> highlightLabels)
        {
            if (highlightLabels.All(string.IsNullOrWhiteSpace))
                return false;
            return Labels.Intersect(highlightLabels, StringComparer.InvariantCultureIgnoreCase).Count() != highlightLabels.Count;
        }
    }

    public sealed class PullRequestDtoEqualityComparer : IEqualityComparer<PullRequestDto>
    {
        public bool Equals(PullRequestDto x, PullRequestDto y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Number == y.Number;
        }

        public int GetHashCode(PullRequestDto obj)
        {
            return obj.Number;
        }
    }
}
