// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ReplicationLinkListResult
    {
        internal static ReplicationLinkListResult DeserializeReplicationLinkListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ReplicationLink>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ReplicationLink> array = new List<ReplicationLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReplicationLink.DeserializeReplicationLink(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ReplicationLinkListResult(Optional.ToList(value));
        }
    }
}
