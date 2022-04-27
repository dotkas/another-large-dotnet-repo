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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlUpdateDataFrameAnalyticsRequestParameters : RequestParameters<MlUpdateDataFrameAnalyticsRequestParameters>
	{
	}

	public partial class MlUpdateDataFrameAnalyticsRequest : PlainRequestBase<MlUpdateDataFrameAnalyticsRequestParameters>
	{
		public MlUpdateDataFrameAnalyticsRequest(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_memory_limit")]
		public string? ModelMemoryLimit { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_num_threads")]
		public int? MaxNumThreads { get; set; }

		[JsonInclude]
		[JsonPropertyName("allow_lazy_start")]
		public bool? AllowLazyStart { get; set; }
	}

	public sealed partial class MlUpdateDataFrameAnalyticsRequestDescriptor<TDocument> : RequestDescriptorBase<MlUpdateDataFrameAnalyticsRequestDescriptor<TDocument>, MlUpdateDataFrameAnalyticsRequestParameters>
	{
		internal MlUpdateDataFrameAnalyticsRequestDescriptor(Action<MlUpdateDataFrameAnalyticsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MlUpdateDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal MlUpdateDataFrameAnalyticsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlUpdateDataFrameAnalyticsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		private bool? AllowLazyStartValue { get; set; }

		private string? DescriptionValue { get; set; }

		private int? MaxNumThreadsValue { get; set; }

		private string? ModelMemoryLimitValue { get; set; }

		public MlUpdateDataFrameAnalyticsRequestDescriptor<TDocument> AllowLazyStart(bool? allowLazyStart = true)
		{
			AllowLazyStartValue = allowLazyStart;
			return Self;
		}

		public MlUpdateDataFrameAnalyticsRequestDescriptor<TDocument> Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlUpdateDataFrameAnalyticsRequestDescriptor<TDocument> MaxNumThreads(int? maxNumThreads)
		{
			MaxNumThreadsValue = maxNumThreads;
			return Self;
		}

		public MlUpdateDataFrameAnalyticsRequestDescriptor<TDocument> ModelMemoryLimit(string? modelMemoryLimit)
		{
			ModelMemoryLimitValue = modelMemoryLimit;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AllowLazyStartValue.HasValue)
			{
				writer.WritePropertyName("allow_lazy_start");
				writer.WriteBooleanValue(AllowLazyStartValue.Value);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (MaxNumThreadsValue.HasValue)
			{
				writer.WritePropertyName("max_num_threads");
				writer.WriteNumberValue(MaxNumThreadsValue.Value);
			}

			if (!string.IsNullOrEmpty(ModelMemoryLimitValue))
			{
				writer.WritePropertyName("model_memory_limit");
				writer.WriteStringValue(ModelMemoryLimitValue);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class MlUpdateDataFrameAnalyticsRequestDescriptor : RequestDescriptorBase<MlUpdateDataFrameAnalyticsRequestDescriptor, MlUpdateDataFrameAnalyticsRequestParameters>
	{
		internal MlUpdateDataFrameAnalyticsRequestDescriptor(Action<MlUpdateDataFrameAnalyticsRequestDescriptor> configure) => configure.Invoke(this);
		public MlUpdateDataFrameAnalyticsRequestDescriptor(Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("id", id))
		{
		}

		internal MlUpdateDataFrameAnalyticsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningUpdateDataFrameAnalytics;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlUpdateDataFrameAnalyticsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		private bool? AllowLazyStartValue { get; set; }

		private string? DescriptionValue { get; set; }

		private int? MaxNumThreadsValue { get; set; }

		private string? ModelMemoryLimitValue { get; set; }

		public MlUpdateDataFrameAnalyticsRequestDescriptor AllowLazyStart(bool? allowLazyStart = true)
		{
			AllowLazyStartValue = allowLazyStart;
			return Self;
		}

		public MlUpdateDataFrameAnalyticsRequestDescriptor Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlUpdateDataFrameAnalyticsRequestDescriptor MaxNumThreads(int? maxNumThreads)
		{
			MaxNumThreadsValue = maxNumThreads;
			return Self;
		}

		public MlUpdateDataFrameAnalyticsRequestDescriptor ModelMemoryLimit(string? modelMemoryLimit)
		{
			ModelMemoryLimitValue = modelMemoryLimit;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AllowLazyStartValue.HasValue)
			{
				writer.WritePropertyName("allow_lazy_start");
				writer.WriteBooleanValue(AllowLazyStartValue.Value);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (MaxNumThreadsValue.HasValue)
			{
				writer.WritePropertyName("max_num_threads");
				writer.WriteNumberValue(MaxNumThreadsValue.Value);
			}

			if (!string.IsNullOrEmpty(ModelMemoryLimitValue))
			{
				writer.WritePropertyName("model_memory_limit");
				writer.WriteStringValue(ModelMemoryLimitValue);
			}

			writer.WriteEndObject();
		}
	}
}