// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the Timeseries
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Timeseries : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Timeseries class.
        /// </summary>
        public Timeseries()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Timeseries class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="endpoint">The endpoint associated with the Timeseries
        /// data point</param>
        /// <param name="startDateTimeUTC">The start DateTime of the Timeseries
        /// in UTC</param>
        /// <param name="endDateTimeUTC">The end DateTime of the Timeseries in
        /// UTC</param>
        /// <param name="aggregationInterval">The aggregation interval of the
        /// Timeseries. Possible values include: 'Hourly', 'Daily'</param>
        /// <param name="timeseriesType">The type of Timeseries. Possible
        /// values include: 'MeasurementCounts', 'LatencyP50', 'LatencyP75',
        /// 'LatencyP95'</param>
        /// <param name="country">The country associated with the Timeseries.
        /// Values are country ISO codes as specified here-
        /// https://www.iso.org/iso-3166-country-codes.html</param>
        /// <param name="timeseriesData">The set of data points for the
        /// timeseries</param>
        public Timeseries(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string endpoint = default(string), string startDateTimeUTC = default(string), string endDateTimeUTC = default(string), string aggregationInterval = default(string), string timeseriesType = default(string), string country = default(string), IList<TimeseriesDataPoint> timeseriesData = default(IList<TimeseriesDataPoint>))
            : base(id, name, type, location, tags)
        {
            Endpoint = endpoint;
            StartDateTimeUTC = startDateTimeUTC;
            EndDateTimeUTC = endDateTimeUTC;
            AggregationInterval = aggregationInterval;
            TimeseriesType = timeseriesType;
            Country = country;
            TimeseriesData = timeseriesData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint associated with the Timeseries data point
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoint")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the start DateTime of the Timeseries in UTC
        /// </summary>
        [JsonProperty(PropertyName = "properties.startDateTimeUTC")]
        public string StartDateTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets the end DateTime of the Timeseries in UTC
        /// </summary>
        [JsonProperty(PropertyName = "properties.endDateTimeUTC")]
        public string EndDateTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets the aggregation interval of the Timeseries. Possible
        /// values include: 'Hourly', 'Daily'
        /// </summary>
        [JsonProperty(PropertyName = "properties.aggregationInterval")]
        public string AggregationInterval { get; set; }

        /// <summary>
        /// Gets or sets the type of Timeseries. Possible values include:
        /// 'MeasurementCounts', 'LatencyP50', 'LatencyP75', 'LatencyP95'
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeseriesType")]
        public string TimeseriesType { get; set; }

        /// <summary>
        /// Gets or sets the country associated with the Timeseries. Values are
        /// country ISO codes as specified here-
        /// https://www.iso.org/iso-3166-country-codes.html
        /// </summary>
        [JsonProperty(PropertyName = "properties.country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the set of data points for the timeseries
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeseriesData")]
        public IList<TimeseriesDataPoint> TimeseriesData { get; set; }

    }
}