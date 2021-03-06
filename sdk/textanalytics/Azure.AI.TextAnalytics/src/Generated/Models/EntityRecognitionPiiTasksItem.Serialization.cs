// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    internal partial class EntityRecognitionPiiTasksItem
    {
        internal static EntityRecognitionPiiTasksItem DeserializeEntityRecognitionPiiTasksItem(JsonElement element)
        {
            PiiEntitiesResult results = default;
            DateTimeOffset lastUpdateDateTime = default;
            Optional<string> name = default;
            TextAnalyticsOperationStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = PiiEntitiesResult.DeserializePiiEntitiesResult(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new EntityRecognitionPiiTasksItem(lastUpdateDateTime, name.Value, status, results);
        }
    }
}
