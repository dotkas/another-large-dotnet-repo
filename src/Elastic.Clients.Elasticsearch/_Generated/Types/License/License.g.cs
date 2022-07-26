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
namespace Elastic.Clients.Elasticsearch.License
{
	public sealed partial class License
	{
		[JsonInclude]
		[JsonPropertyName("expiry_date_in_millis")]
		public long ExpiryDateInMillis { get; set; }

		[JsonInclude]
		[JsonPropertyName("issue_date_in_millis")]
		public long IssueDateInMillis { get; set; }

		[JsonInclude]
		[JsonPropertyName("issued_to")]
		public string IssuedTo { get; set; }

		[JsonInclude]
		[JsonPropertyName("issuer")]
		public string Issuer { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_nodes")]
		public long? MaxNodes { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_resource_units")]
		public long? MaxResourceUnits { get; set; }

		[JsonInclude]
		[JsonPropertyName("signature")]
		public string Signature { get; set; }

		[JsonInclude]
		[JsonPropertyName("start_date_in_millis")]
		public long? StartDateInMillis { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.License.LicenseType Type { get; set; }

		[JsonInclude]
		[JsonPropertyName("uid")]
		public string Uid { get; set; }
	}

	public sealed partial class LicenseDescriptor : SerializableDescriptorBase<LicenseDescriptor>
	{
		internal LicenseDescriptor(Action<LicenseDescriptor> configure) => configure.Invoke(this);
		public LicenseDescriptor() : base()
		{
		}

		private long ExpiryDateInMillisValue { get; set; }

		private long IssueDateInMillisValue { get; set; }

		private string IssuedToValue { get; set; }

		private string IssuerValue { get; set; }

		private long? MaxNodesValue { get; set; }

		private long? MaxResourceUnitsValue { get; set; }

		private string SignatureValue { get; set; }

		private long? StartDateInMillisValue { get; set; }

		private Elastic.Clients.Elasticsearch.License.LicenseType TypeValue { get; set; }

		private string UidValue { get; set; }

		public LicenseDescriptor ExpiryDateInMillis(long expiryDateInMillis)
		{
			ExpiryDateInMillisValue = expiryDateInMillis;
			return Self;
		}

		public LicenseDescriptor IssueDateInMillis(long issueDateInMillis)
		{
			IssueDateInMillisValue = issueDateInMillis;
			return Self;
		}

		public LicenseDescriptor IssuedTo(string issuedTo)
		{
			IssuedToValue = issuedTo;
			return Self;
		}

		public LicenseDescriptor Issuer(string issuer)
		{
			IssuerValue = issuer;
			return Self;
		}

		public LicenseDescriptor MaxNodes(long? maxNodes)
		{
			MaxNodesValue = maxNodes;
			return Self;
		}

		public LicenseDescriptor MaxResourceUnits(long? maxResourceUnits)
		{
			MaxResourceUnitsValue = maxResourceUnits;
			return Self;
		}

		public LicenseDescriptor Signature(string signature)
		{
			SignatureValue = signature;
			return Self;
		}

		public LicenseDescriptor StartDateInMillis(long? startDateInMillis)
		{
			StartDateInMillisValue = startDateInMillis;
			return Self;
		}

		public LicenseDescriptor Type(Elastic.Clients.Elasticsearch.License.LicenseType type)
		{
			TypeValue = type;
			return Self;
		}

		public LicenseDescriptor Uid(string uid)
		{
			UidValue = uid;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("expiry_date_in_millis");
			JsonSerializer.Serialize(writer, ExpiryDateInMillisValue, options);
			writer.WritePropertyName("issue_date_in_millis");
			JsonSerializer.Serialize(writer, IssueDateInMillisValue, options);
			writer.WritePropertyName("issued_to");
			writer.WriteStringValue(IssuedToValue);
			writer.WritePropertyName("issuer");
			writer.WriteStringValue(IssuerValue);
			if (MaxNodesValue.HasValue)
			{
				writer.WritePropertyName("max_nodes");
				writer.WriteNumberValue(MaxNodesValue.Value);
			}

			if (MaxResourceUnitsValue.HasValue)
			{
				writer.WritePropertyName("max_resource_units");
				writer.WriteNumberValue(MaxResourceUnitsValue.Value);
			}

			writer.WritePropertyName("signature");
			writer.WriteStringValue(SignatureValue);
			if (StartDateInMillisValue is not null)
			{
				writer.WritePropertyName("start_date_in_millis");
				JsonSerializer.Serialize(writer, StartDateInMillisValue, options);
			}

			writer.WritePropertyName("type");
			JsonSerializer.Serialize(writer, TypeValue, options);
			writer.WritePropertyName("uid");
			writer.WriteStringValue(UidValue);
			writer.WriteEndObject();
		}
	}
}