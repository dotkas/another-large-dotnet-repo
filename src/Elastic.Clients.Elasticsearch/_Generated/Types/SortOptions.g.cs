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
namespace Elastic.Clients.Elasticsearch
{
	public interface ISortOptionsVariant
	{
	}

	[JsonConverter(typeof(SortOptionsConverter))]
	public sealed partial class SortOptions
	{
		public SortOptions(string variantName, ISortOptionsVariant variant)
		{
			if (variantName is null)
				throw new ArgumentNullException(nameof(variantName));
			if (variant is null)
				throw new ArgumentNullException(nameof(variant));
			if (string.IsNullOrWhiteSpace(variantName))
				throw new ArgumentException("Variant name must not be empty or whitespace.");
			VariantName = variantName;
			Variant = variant;
		}

		public SortOptions(Elastic.Clients.Elasticsearch.Field field, ISortOptionsVariant variant)
		{
			if (field is null)
				throw new ArgumentNullException(nameof(field));
			if (variant is null)
				throw new ArgumentNullException(nameof(variant));
			AdditionalPropertyName = field;
			Variant = variant;
		}

		internal ISortOptionsVariant Variant { get; }

		internal string VariantName { get; }

		internal Elastic.Clients.Elasticsearch.Field? AdditionalPropertyName { get; }

		public static SortOptions Doc(Elastic.Clients.Elasticsearch.ScoreSort scoreSort) => new SortOptions("_doc", scoreSort);
		public static SortOptions GeoDistance(Elastic.Clients.Elasticsearch.GeoDistanceSort geoDistanceSort) => new SortOptions("_geo_distance", geoDistanceSort);
		public static SortOptions Score(Elastic.Clients.Elasticsearch.ScoreSort scoreSort) => new SortOptions("_score", scoreSort);
		public static SortOptions Script(Elastic.Clients.Elasticsearch.ScriptSort scriptSort) => new SortOptions("_script", scriptSort);
		public static SortOptions Field(Elastic.Clients.Elasticsearch.Field field, Elastic.Clients.Elasticsearch.FieldSort fieldSort) => new SortOptions(field, fieldSort);
	}

	internal sealed class SortOptionsConverter : JsonConverter<SortOptions>
	{
		public override SortOptions Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new JsonException("Expected start token.");
			}

			reader.Read();
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected property name token.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "_doc")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScoreSort?>(ref reader, options);
				reader.Read();
				return new SortOptions(propertyName, variant);
			}

			if (propertyName == "_geo_distance")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.GeoDistanceSort?>(ref reader, options);
				reader.Read();
				return new SortOptions(propertyName, variant);
			}

			if (propertyName == "_score")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScoreSort?>(ref reader, options);
				reader.Read();
				return new SortOptions(propertyName, variant);
			}

			if (propertyName == "_script")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScriptSort?>(ref reader, options);
				reader.Read();
				return new SortOptions(propertyName, variant);
			}

			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.FieldSort>(ref reader, options);
				reader.Read();
				return new SortOptions(propertyName, variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, SortOptions value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.AdditionalPropertyName is IUrlParameter urlParameter)
			{
				var extraData = options.GetConverter(typeof(ExtraSerializationData)) as ExtraSerializationData;
				var propertyName = urlParameter.GetString(extraData.Settings);
				writer.WritePropertyName(propertyName);
			}
			else
			{
				writer.WritePropertyName(value.VariantName);
			}

			switch (value.VariantName)
			{
				case "_doc":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.ScoreSort>(writer, (Elastic.Clients.Elasticsearch.ScoreSort)value.Variant, options);
					break;
				case "_geo_distance":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.GeoDistanceSort>(writer, (Elastic.Clients.Elasticsearch.GeoDistanceSort)value.Variant, options);
					break;
				case "_score":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.ScoreSort>(writer, (Elastic.Clients.Elasticsearch.ScoreSort)value.Variant, options);
					break;
				case "_script":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.ScriptSort>(writer, (Elastic.Clients.Elasticsearch.ScriptSort)value.Variant, options);
					break;
				default:
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.FieldSort>(writer, (Elastic.Clients.Elasticsearch.FieldSort)value.Variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SortOptionsDescriptor<TDocument> : SerializableDescriptorBase<SortOptionsDescriptor<TDocument>>
	{
		internal SortOptionsDescriptor(Action<SortOptionsDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SortOptionsDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal SortOptions Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(ISortOptionsVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new SortOptions(variantName, variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void Doc(ScoreSort variant) => Set(variant, "_doc");
		public void Doc(Action<ScoreSortDescriptor> configure) => Set(configure, "_doc");
		public void GeoDistance(GeoDistanceSort variant) => Set(variant, "_geo_distance");
		public void GeoDistance(Action<GeoDistanceSortDescriptor<TDocument>> configure) => Set(configure, "_geo_distance");
		public void Score(ScoreSort variant) => Set(variant, "_score");
		public void Score(Action<ScoreSortDescriptor> configure) => Set(configure, "_score");
		public void Script(ScriptSort variant) => Set(variant, "_script");
		public void Script(Action<ScriptSortDescriptor<TDocument>> configure) => Set(configure, "_script");
	}

	public sealed partial class SortOptionsDescriptor : SerializableDescriptorBase<SortOptionsDescriptor>
	{
		internal SortOptionsDescriptor(Action<SortOptionsDescriptor> configure) => configure.Invoke(this);
		public SortOptionsDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal SortOptions Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(ISortOptionsVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new SortOptions(variantName, variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void Doc(ScoreSort variant) => Set(variant, "_doc");
		public void Doc(Action<ScoreSortDescriptor> configure) => Set(configure, "_doc");
		public void GeoDistance(GeoDistanceSort variant) => Set(variant, "_geo_distance");
		public void GeoDistance(Action<GeoDistanceSortDescriptor> configure) => Set(configure, "_geo_distance");
		public void GeoDistance<TDocument>(Action<GeoDistanceSortDescriptor<TDocument>> configure) => Set(configure, "_geo_distance");
		public void Score(ScoreSort variant) => Set(variant, "_score");
		public void Score(Action<ScoreSortDescriptor> configure) => Set(configure, "_score");
		public void Script(ScriptSort variant) => Set(variant, "_script");
		public void Script(Action<ScriptSortDescriptor> configure) => Set(configure, "_script");
		public void Script<TDocument>(Action<ScriptSortDescriptor<TDocument>> configure) => Set(configure, "_script");
	}
}