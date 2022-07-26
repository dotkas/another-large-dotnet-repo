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
	public sealed class ExistsRequestParameters : RequestParameters<ExistsRequestParameters>
	{
		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.SourceConfigParam?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public long? Version { get => Q<long?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }
	}

	public sealed partial class ExistsRequest : PlainRequestBase<ExistsRequestParameters>
	{
		public ExistsRequest(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExists;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public string? Preference { get => Q<string?>("preference"); set => Q("preference", value); }

		[JsonIgnore]
		public bool? Realtime { get => Q<bool?>("realtime"); set => Q("realtime", value); }

		[JsonIgnore]
		public bool? Refresh { get => Q<bool?>("refresh"); set => Q("refresh", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Routing?>("routing"); set => Q("routing", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.SourceConfigParam? Source { get => Q<Elastic.Clients.Elasticsearch.SourceConfigParam?>("_source"); set => Q("_source", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceExcludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_excludes"); set => Q("_source_excludes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? SourceIncludes { get => Q<Elastic.Clients.Elasticsearch.Fields?>("_source_includes"); set => Q("_source_includes", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? StoredFields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("stored_fields"); set => Q("stored_fields", value); }

		[JsonIgnore]
		public long? Version { get => Q<long?>("version"); set => Q("version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get => Q<Elastic.Clients.Elasticsearch.VersionType?>("version_type"); set => Q("version_type", value); }
	}

	public sealed partial class ExistsRequestDescriptor<TDocument> : RequestDescriptorBase<ExistsRequestDescriptor<TDocument>, ExistsRequestParameters>
	{
		internal ExistsRequestDescriptor(Action<ExistsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public ExistsRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		public ExistsRequestDescriptor(TDocument document) : this(typeof(TDocument), Elasticsearch.Id.From(document))
		{
		}

		public ExistsRequestDescriptor(TDocument document, IndexName index, Id id) : this(index, id)
		{
		}

		public ExistsRequestDescriptor(TDocument document, IndexName index) : this(index, Elasticsearch.Id.From(document))
		{
		}

		public ExistsRequestDescriptor(TDocument document, Id id) : this(typeof(TDocument), id)
		{
		}

		public ExistsRequestDescriptor(Id id) : this(typeof(TDocument), id)
		{
		}

		internal ExistsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExists;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		public ExistsRequestDescriptor<TDocument> Source(Elastic.Clients.Elasticsearch.SourceConfigParam? source) => Qs("_source", source);
		public ExistsRequestDescriptor<TDocument> SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
		public ExistsRequestDescriptor<TDocument> SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
		public ExistsRequestDescriptor<TDocument> Preference(string? preference) => Qs("preference", preference);
		public ExistsRequestDescriptor<TDocument> Realtime(bool? realtime = true) => Qs("realtime", realtime);
		public ExistsRequestDescriptor<TDocument> Refresh(bool? refresh = true) => Qs("refresh", refresh);
		public ExistsRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
		public ExistsRequestDescriptor<TDocument> StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Qs("stored_fields", storedFields);
		public ExistsRequestDescriptor<TDocument> Version(long? version) => Qs("version", version);
		public ExistsRequestDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
		public ExistsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		public ExistsRequestDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class ExistsRequestDescriptor : RequestDescriptorBase<ExistsRequestDescriptor, ExistsRequestParameters>
	{
		internal ExistsRequestDescriptor(Action<ExistsRequestDescriptor> configure) => configure.Invoke(this);
		public ExistsRequestDescriptor(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id) : base(r => r.Required("index", index).Required("id", id))
		{
		}

		internal ExistsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceExists;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
		public ExistsRequestDescriptor Source(Elastic.Clients.Elasticsearch.SourceConfigParam? source) => Qs("_source", source);
		public ExistsRequestDescriptor SourceExcludes(Elastic.Clients.Elasticsearch.Fields? sourceExcludes) => Qs("_source_excludes", sourceExcludes);
		public ExistsRequestDescriptor SourceIncludes(Elastic.Clients.Elasticsearch.Fields? sourceIncludes) => Qs("_source_includes", sourceIncludes);
		public ExistsRequestDescriptor Preference(string? preference) => Qs("preference", preference);
		public ExistsRequestDescriptor Realtime(bool? realtime = true) => Qs("realtime", realtime);
		public ExistsRequestDescriptor Refresh(bool? refresh = true) => Qs("refresh", refresh);
		public ExistsRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Qs("routing", routing);
		public ExistsRequestDescriptor StoredFields(Elastic.Clients.Elasticsearch.Fields? storedFields) => Qs("stored_fields", storedFields);
		public ExistsRequestDescriptor Version(long? version) => Qs("version", version);
		public ExistsRequestDescriptor VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Qs("version_type", versionType);
		public ExistsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
		{
			RouteValues.Required("id", id);
			return Self;
		}

		public ExistsRequestDescriptor Index(Elastic.Clients.Elasticsearch.IndexName index)
		{
			RouteValues.Required("index", index);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}