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
namespace Elastic.Clients.Elasticsearch.Slm
{
	public partial class Configuration
	{
		[JsonInclude]
		[JsonPropertyName("feature_states")]
		public IEnumerable<string>? FeatureStates { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_unavailable")]
		public bool? IgnoreUnavailable { get; set; }

		[JsonInclude]
		[JsonPropertyName("include_global_state")]
		public bool? IncludeGlobalState { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices Indices { get; set; }

		[JsonInclude]
		[JsonPropertyName("metadata")]
		public Dictionary<string, object>? Metadata { get; set; }

		[JsonInclude]
		[JsonPropertyName("partial")]
		public bool? Partial { get; set; }
	}

	public sealed partial class ConfigurationDescriptor : DescriptorBase<ConfigurationDescriptor>
	{
		internal ConfigurationDescriptor(Action<ConfigurationDescriptor> configure) => configure.Invoke(this);
		public ConfigurationDescriptor() : base()
		{
		}

		private IEnumerable<string>? FeatureStatesValue { get; set; }

		private bool? IgnoreUnavailableValue { get; set; }

		private bool? IncludeGlobalStateValue { get; set; }

		private Elastic.Clients.Elasticsearch.Indices IndicesValue { get; set; }

		private Dictionary<string, object>? MetadataValue { get; set; }

		private bool? PartialValue { get; set; }

		public ConfigurationDescriptor FeatureStates(IEnumerable<string>? featureStates)
		{
			FeatureStatesValue = featureStates;
			return Self;
		}

		public ConfigurationDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true)
		{
			IgnoreUnavailableValue = ignoreUnavailable;
			return Self;
		}

		public ConfigurationDescriptor IncludeGlobalState(bool? includeGlobalState = true)
		{
			IncludeGlobalStateValue = includeGlobalState;
			return Self;
		}

		public ConfigurationDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
		{
			IndicesValue = indices;
			return Self;
		}

		public ConfigurationDescriptor Metadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public ConfigurationDescriptor Partial(bool? partial = true)
		{
			PartialValue = partial;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FeatureStatesValue is not null)
			{
				writer.WritePropertyName("feature_states");
				JsonSerializer.Serialize(writer, FeatureStatesValue, options);
			}

			if (IgnoreUnavailableValue.HasValue)
			{
				writer.WritePropertyName("ignore_unavailable");
				writer.WriteBooleanValue(IgnoreUnavailableValue.Value);
			}

			if (IncludeGlobalStateValue.HasValue)
			{
				writer.WritePropertyName("include_global_state");
				writer.WriteBooleanValue(IncludeGlobalStateValue.Value);
			}

			writer.WritePropertyName("indices");
			JsonSerializer.Serialize(writer, IndicesValue, options);
			if (MetadataValue is not null)
			{
				writer.WritePropertyName("metadata");
				JsonSerializer.Serialize(writer, MetadataValue, options);
			}

			if (PartialValue.HasValue)
			{
				writer.WritePropertyName("partial");
				writer.WriteBooleanValue(PartialValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}