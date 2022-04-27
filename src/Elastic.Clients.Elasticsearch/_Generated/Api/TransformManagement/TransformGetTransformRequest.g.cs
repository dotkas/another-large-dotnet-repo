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
namespace Elastic.Clients.Elasticsearch.TransformManagement
{
	public sealed class TransformGetTransformRequestParameters : RequestParameters<TransformGetTransformRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public bool? ExcludeGenerated { get => Q<bool?>("exclude_generated"); set => Q("exclude_generated", value); }
	}

	public partial class TransformGetTransformRequest : PlainRequestBase<TransformGetTransformRequestParameters>
	{
		public TransformGetTransformRequest()
		{
		}

		public TransformGetTransformRequest(Elastic.Clients.Elasticsearch.Names? transform_id) : base(r => r.Optional("transform_id", transform_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformManagementGetTransform;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }

		[JsonIgnore]
		public bool? ExcludeGenerated { get => Q<bool?>("exclude_generated"); set => Q("exclude_generated", value); }
	}

	public sealed partial class TransformGetTransformRequestDescriptor : RequestDescriptorBase<TransformGetTransformRequestDescriptor, TransformGetTransformRequestParameters>
	{
		internal TransformGetTransformRequestDescriptor(Action<TransformGetTransformRequestDescriptor> configure) => configure.Invoke(this);
		public TransformGetTransformRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformManagementGetTransform;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public TransformGetTransformRequestDescriptor AllowNoMatch(bool? allowNoMatch = true) => Qs("allow_no_match", allowNoMatch);
		public TransformGetTransformRequestDescriptor ExcludeGenerated(bool? excludeGenerated = true) => Qs("exclude_generated", excludeGenerated);
		public TransformGetTransformRequestDescriptor From(int? from) => Qs("from", from);
		public TransformGetTransformRequestDescriptor Size(int? size) => Qs("size", size);
		public TransformGetTransformRequestDescriptor TransformId(Elastic.Clients.Elasticsearch.Names? transform_id)
		{
			RouteValues.Optional("transform_id", transform_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}