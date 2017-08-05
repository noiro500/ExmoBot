﻿using System;
using ExmoAPI.Authenticated_API.Interfeces;
using Newtonsoft.Json;

namespace ExmoAPI.Authenticated_API.Classes
{
    public class CUserCancelledOrders : IUserCancelledOrders
    {
        [JsonProperty("date")]
        public decimal Date {get;private set;}
        [JsonProperty("order_id")]
        public decimal OrderId {get;private set;}
        [JsonProperty("order_type")]
        public string OrderType {get;private set;}
        [JsonProperty("pair")]
        public string Pair {get;private set;}
        [JsonProperty("price")]
        public decimal Price {get;private set;}
        [JsonProperty("quantity")]
        public decimal Quantity {get;private set;}
        [JsonProperty("amount")]
        public decimal Amount {get;private set;}
    }
}