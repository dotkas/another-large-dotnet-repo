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
namespace Elastic.Clients.Elasticsearch
{
	public sealed partial class RescoreQuery
	{
		[JsonInclude]
		[JsonPropertyName("query_weight")]
		public double? QueryWeight { get; set; }

		[JsonInclude]
		[JsonPropertyName("rescore_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("rescore_query_weight")]
		public double? RescoreQueryWeight { get; set; }

		[JsonInclude]
		[JsonPropertyName("score_mode")]
		public Elastic.Clients.Elasticsearch.ScoreMode? ScoreMode { get; set; }
	}

	public sealed partial class RescoreQueryDescriptor<TDocument> : SerializableDescriptorBase<RescoreQueryDescriptor<TDocument>>
	{
		internal RescoreQueryDescriptor(Action<RescoreQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public RescoreQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor<TDocument> QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; set; }

		private double? QueryWeightValue { get; set; }

		private double? RescoreQueryWeightValue { get; set; }

		private Elastic.Clients.Elasticsearch.ScoreMode? ScoreModeValue { get; set; }

		public RescoreQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public RescoreQueryDescriptor<TDocument> Query(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public RescoreQueryDescriptor<TDocument> Query(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public RescoreQueryDescriptor<TDocument> QueryWeight(double? queryWeight)
		{
			QueryWeightValue = queryWeight;
			return Self;
		}

		public RescoreQueryDescriptor<TDocument> RescoreQueryWeight(double? rescoreQueryWeight)
		{
			RescoreQueryWeightValue = rescoreQueryWeight;
			return Self;
		}

		public RescoreQueryDescriptor<TDocument> ScoreMode(Elastic.Clients.Elasticsearch.ScoreMode? scoreMode)
		{
			ScoreModeValue = scoreMode;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (QueryWeightValue.HasValue)
			{
				writer.WritePropertyName("query_weight");
				writer.WriteNumberValue(QueryWeightValue.Value);
			}

			if (RescoreQueryWeightValue.HasValue)
			{
				writer.WritePropertyName("rescore_query_weight");
				writer.WriteNumberValue(RescoreQueryWeightValue.Value);
			}

			if (ScoreModeValue is not null)
			{
				writer.WritePropertyName("score_mode");
				JsonSerializer.Serialize(writer, ScoreModeValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class RescoreQueryDescriptor : SerializableDescriptorBase<RescoreQueryDescriptor>
	{
		internal RescoreQueryDescriptor(Action<RescoreQueryDescriptor> configure) => configure.Invoke(this);
		public RescoreQueryDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; set; }

		private QueryDsl.QueryContainerDescriptor QueryDescriptor { get; set; }

		private Action<QueryDsl.QueryContainerDescriptor> QueryDescriptorAction { get; set; }

		private double? QueryWeightValue { get; set; }

		private double? RescoreQueryWeightValue { get; set; }

		private Elastic.Clients.Elasticsearch.ScoreMode? ScoreModeValue { get; set; }

		public RescoreQueryDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			QueryValue = query;
			return Self;
		}

		public RescoreQueryDescriptor Query(QueryDsl.QueryContainerDescriptor descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			QueryDescriptor = descriptor;
			return Self;
		}

		public RescoreQueryDescriptor Query(Action<QueryDsl.QueryContainerDescriptor> configure)
		{
			QueryValue = null;
			QueryDescriptor = null;
			QueryDescriptorAction = configure;
			return Self;
		}

		public RescoreQueryDescriptor QueryWeight(double? queryWeight)
		{
			QueryWeightValue = queryWeight;
			return Self;
		}

		public RescoreQueryDescriptor RescoreQueryWeight(double? rescoreQueryWeight)
		{
			RescoreQueryWeightValue = rescoreQueryWeight;
			return Self;
		}

		public RescoreQueryDescriptor ScoreMode(Elastic.Clients.Elasticsearch.ScoreMode? scoreMode)
		{
			ScoreModeValue = scoreMode;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (QueryWeightValue.HasValue)
			{
				writer.WritePropertyName("query_weight");
				writer.WriteNumberValue(QueryWeightValue.Value);
			}

			if (RescoreQueryWeightValue.HasValue)
			{
				writer.WritePropertyName("rescore_query_weight");
				writer.WriteNumberValue(RescoreQueryWeightValue.Value);
			}

			if (ScoreModeValue is not null)
			{
				writer.WritePropertyName("score_mode");
				JsonSerializer.Serialize(writer, ScoreModeValue, options);
			}

			writer.WriteEndObject();
		}
	}
}