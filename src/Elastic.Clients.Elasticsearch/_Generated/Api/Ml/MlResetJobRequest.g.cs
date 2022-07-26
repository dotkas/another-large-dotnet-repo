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
	public sealed class MlResetJobRequestParameters : RequestParameters<MlResetJobRequestParameters>
	{
		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	public sealed partial class MlResetJobRequest : PlainRequestBase<MlResetJobRequestParameters>
	{
		public MlResetJobRequest(Elastic.Clients.Elasticsearch.Id job_id) : base(r => r.Required("job_id", job_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningResetJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	public sealed partial class MlResetJobRequestDescriptor : RequestDescriptorBase<MlResetJobRequestDescriptor, MlResetJobRequestParameters>
	{
		internal MlResetJobRequestDescriptor(Action<MlResetJobRequestDescriptor> configure) => configure.Invoke(this);
		public MlResetJobRequestDescriptor(Elastic.Clients.Elasticsearch.Id job_id) : base(r => r.Required("job_id", job_id))
		{
		}

		internal MlResetJobRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningResetJob;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public MlResetJobRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);
		public MlResetJobRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id job_id)
		{
			RouteValues.Required("job_id", job_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}