// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkBatchJobState
    {
        internal static SparkBatchJobState DeserializeSparkBatchJobState(JsonElement element)
        {
            Optional<DateTimeOffset> notStartedAt = default;
            Optional<DateTimeOffset> startingAt = default;
            Optional<DateTimeOffset> runningAt = default;
            Optional<DateTimeOffset> deadAt = default;
            Optional<DateTimeOffset> successAt = default;
            Optional<DateTimeOffset> killedAt = default;
            Optional<DateTimeOffset> recoveringAt = default;
            Optional<string> currentState = default;
            Optional<SparkRequest> jobCreationRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notStartedAt"))
                {
                    notStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startingAt"))
                {
                    startingAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runningAt"))
                {
                    runningAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deadAt"))
                {
                    deadAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("successAt"))
                {
                    successAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("killedAt"))
                {
                    killedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveringAt"))
                {
                    recoveringAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"))
                {
                    currentState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCreationRequest"))
                {
                    jobCreationRequest = SparkRequest.DeserializeSparkRequest(property.Value);
                    continue;
                }
            }
            return new SparkBatchJobState(Optional.ToNullable(notStartedAt), Optional.ToNullable(startingAt), Optional.ToNullable(runningAt), Optional.ToNullable(deadAt), Optional.ToNullable(successAt), Optional.ToNullable(killedAt), Optional.ToNullable(recoveringAt), currentState.Value, jobCreationRequest.Value);
        }
    }
}
