// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public abstract partial class PipelineAggregationBase : BucketPathAggregationBase
	{
		protected PipelineAggregationBase(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("gap_policy")]
		public Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicy { get; set; }
	}

	public sealed partial class PipelineAggregationBaseDescriptor : DescriptorBase<PipelineAggregationBaseDescriptor>
	{
		internal PipelineAggregationBaseDescriptor(Action<PipelineAggregationBaseDescriptor> configure) => configure.Invoke(this);
		public PipelineAggregationBaseDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }

		private string? FormatValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private string? NameValue { get; set; }

		public PipelineAggregationBaseDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
		{
			BucketsPathValue = bucketsPath;
			return Self;
		}

		public PipelineAggregationBaseDescriptor Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public PipelineAggregationBaseDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
		{
			GapPolicyValue = gapPolicy;
			return Self;
		}

		public PipelineAggregationBaseDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public PipelineAggregationBaseDescriptor Name(string? name)
		{
			NameValue = name;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (BucketsPathValue is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, BucketsPathValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (GapPolicyValue is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, GapPolicyValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (!string.IsNullOrEmpty(NameValue))
			{
				writer.WritePropertyName("name");
				writer.WriteStringValue(NameValue);
			}

			writer.WriteEndObject();
		}
	}
}