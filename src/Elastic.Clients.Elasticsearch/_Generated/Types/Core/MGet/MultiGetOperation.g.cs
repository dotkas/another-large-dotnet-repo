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

#nullable restore

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Core.MGet;

public sealed partial class MultiGetOperation
{
	/// <summary>
	/// <para>The unique document ID.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_id")]
	public Elastic.Clients.Elasticsearch.Id Id { get; set; }

	/// <summary>
	/// <para>The index that contains the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_index")]
	public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

	/// <summary>
	/// <para>If `false`, excludes all _source fields.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_source")]
	public Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? Source { get; set; }

	/// <summary>
	/// <para>The key for the primary shard the document resides on. Required if routing is used during indexing.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

	/// <summary>
	/// <para>The stored fields you want to retrieve.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("stored_fields")]
	public Elastic.Clients.Elasticsearch.Fields? StoredFields { get; set; }
	[JsonInclude, JsonPropertyName("version")]
	public long? Version { get; set; }
	[JsonInclude, JsonPropertyName("version_type")]
	public Elastic.Clients.Elasticsearch.VersionType? VersionType { get; set; }
}

public sealed partial class MultiGetOperationDescriptor : SerializableDescriptor<MultiGetOperationDescriptor>
{
	internal MultiGetOperationDescriptor(Action<MultiGetOperationDescriptor> configure) => configure.Invoke(this);

	public MultiGetOperationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? SourceValue { get; set; }
	private Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; set; }
	private Elastic.Clients.Elasticsearch.Fields? StoredFieldsValue { get; set; }
	private long? VersionValue { get; set; }
	private Elastic.Clients.Elasticsearch.VersionType? VersionTypeValue { get; set; }

	/// <summary>
	/// <para>The unique document ID.</para>
	/// </summary>
	public MultiGetOperationDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>The index that contains the document.</para>
	/// </summary>
	public MultiGetOperationDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>If `false`, excludes all _source fields.</para>
	/// </summary>
	public MultiGetOperationDescriptor Source(Elastic.Clients.Elasticsearch.Core.Search.SourceConfig? source)
	{
		SourceValue = source;
		return Self;
	}

	/// <summary>
	/// <para>The key for the primary shard the document resides on. Required if routing is used during indexing.</para>
	/// </summary>
	public MultiGetOperationDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	/// <summary>
	/// <para>The stored fields you want to retrieve.</para>
	/// </summary>
	public MultiGetOperationDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields)
	{
		StoredFieldsValue = storedFields;
		return Self;
	}

	public MultiGetOperationDescriptor Version(long? version)
	{
		VersionValue = version;
		return Self;
	}

	public MultiGetOperationDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType)
	{
		VersionTypeValue = versionType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("_id");
		JsonSerializer.Serialize(writer, IdValue, options);
		if (IndexValue is not null)
		{
			writer.WritePropertyName("_index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (SourceValue is not null)
		{
			writer.WritePropertyName("_source");
			JsonSerializer.Serialize(writer, SourceValue, options);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		if (StoredFieldsValue is not null)
		{
			writer.WritePropertyName("stored_fields");
			JsonSerializer.Serialize(writer, StoredFieldsValue, options);
		}

		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		if (VersionTypeValue is not null)
		{
			writer.WritePropertyName("version_type");
			JsonSerializer.Serialize(writer, VersionTypeValue, options);
		}

		writer.WriteEndObject();
	}
}