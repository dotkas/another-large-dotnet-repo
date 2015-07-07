﻿using System;
using FluentAssertions;
using Nest;
using Tests.Framework;
using Tests.Framework.Integration;
using Tests.Framework.MockData;
using Tests.SearchAPIs;

namespace Tests.Search.Request
{
	public class PostFilter
	{
		public class Usage : SearchUsageBase
		{
			public Usage(ReadOnlyIntegration i) : base(i) {} 

			protected override object ExpectJson =>
				new { post_filter = new { match_all = new { } } };

			public override int ExpectStatusCode => 200;

			public override bool ExpectIsValid => true;


			protected override SearchRequest<Project> Initializer =>
				new SearchRequest<Project>()
				{
					PostFilter = new QueryContainer(new MatchAllQuery())
				};

			protected override Func<SearchDescriptor<Project>, ISearchRequest> Fluent => s => s
				.PostFilter(f => f.MatchAll());

			[I]
			public async void ShouldHaveHits() => await AssertOnAllResponses((r) =>
			{
				r.Hits.Should().NotBeNull();
			});

		}
	}
}
