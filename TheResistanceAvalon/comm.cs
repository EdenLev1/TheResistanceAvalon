using System;
using System.Collections.Generic;
using RestSharp;
using Newtonsoft.Json;

namespace TheResistanceAvalon
{
    public class Variant   // game extensions in use
    {
        [JsonProperty("mordred", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool mordred { get; set; }
        [JsonProperty("oberon", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool oberon { get; set; }
        [JsonProperty("morgana", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool morgana { get; set; }
        [JsonProperty("percival", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool percival { get; set; }
        [JsonProperty("lady", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool lady { get; set; }
        [JsonProperty("excalibur", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool excalibur { get; set; }
    }

    public class Votes     // stats on player reject and approve votes per game
    {
        [JsonProperty("c1m1v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m1v1 { get; set; }
        [JsonProperty("c1m1v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m1v2 { get; set; }
        [JsonProperty("c1m1v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m1v3 { get; set; }
        [JsonProperty("c1m1v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m1v4 { get; set; }
        [JsonProperty("c1m1v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m1v5 { get; set; }
        [JsonProperty("c1m2v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m2v1 { get; set; }
        [JsonProperty("c1m2v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m2v2 { get; set; }
        [JsonProperty("c1m2v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m2v3 { get; set; }
        [JsonProperty("c1m2v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m2v4 { get; set; }
        [JsonProperty("c1m2v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m2v5 { get; set; }
        [JsonProperty("c1m3v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m3v1 { get; set; }
        [JsonProperty("c1m3v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m3v2 { get; set; }
        [JsonProperty("c1m3v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m3v3 { get; set; }
        [JsonProperty("c1m3v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m3v4 { get; set; }
        [JsonProperty("c1m3v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m3v5 { get; set; }
        [JsonProperty("c1m4v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m4v1 { get; set; }
        [JsonProperty("c1m4v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m4v2 { get; set; }
        [JsonProperty("c1m4v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m4v3 { get; set; }
        [JsonProperty("c1m4v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m4v4 { get; set; }
        [JsonProperty("c1m4v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m4v5 { get; set; }
        [JsonProperty("c1m5v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m5v1 { get; set; }
        [JsonProperty("c1m5v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m5v2 { get; set; }
        [JsonProperty("c1m5v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m5v3 { get; set; }
        [JsonProperty("c1m5v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m5v4 { get; set; }
        [JsonProperty("c1m5v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c1m5v5 { get; set; }
		[JsonProperty("c2m1v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m1v1 { get; set; }
        [JsonProperty("c2m1v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m1v2 { get; set; }
        [JsonProperty("c2m1v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m1v3 { get; set; }
        [JsonProperty("c2m1v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m1v4 { get; set; }
        [JsonProperty("c2m1v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m1v5 { get; set; }
        [JsonProperty("c2m2v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m2v1 { get; set; }
        [JsonProperty("c2m2v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m2v2 { get; set; }
        [JsonProperty("c2m2v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m2v3 { get; set; }
        [JsonProperty("c2m2v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m2v4 { get; set; }
        [JsonProperty("c2m2v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m2v5 { get; set; }
        [JsonProperty("c2m3v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m3v1 { get; set; }
        [JsonProperty("c2m3v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m3v2 { get; set; }
        [JsonProperty("c2m3v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m3v3 { get; set; }
        [JsonProperty("c2m3v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m3v4 { get; set; }
        [JsonProperty("c2m3v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m3v5 { get; set; }
        [JsonProperty("c2m4v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m4v1 { get; set; }
        [JsonProperty("c2m4v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m4v2 { get; set; }
        [JsonProperty("c2m4v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m4v3 { get; set; }
        [JsonProperty("c2m4v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m4v4 { get; set; }
        [JsonProperty("c2m4v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m4v5 { get; set; }
        [JsonProperty("c2m5v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m5v1 { get; set; }
        [JsonProperty("c2m5v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m5v2 { get; set; }
        [JsonProperty("c2m5v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m5v3 { get; set; }
        [JsonProperty("c2m5v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m5v4 { get; set; }
        [JsonProperty("c2m5v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c2m5v5 { get; set; }
		[JsonProperty("c3m1v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m1v1 { get; set; }
        [JsonProperty("c3m1v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m1v2 { get; set; }
        [JsonProperty("c3m1v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m1v3 { get; set; }
        [JsonProperty("c3m1v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m1v4 { get; set; }
        [JsonProperty("c3m1v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m1v5 { get; set; }
        [JsonProperty("c3m2v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m2v1 { get; set; }
        [JsonProperty("c3m2v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m2v2 { get; set; }
        [JsonProperty("c3m2v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m2v3 { get; set; }
        [JsonProperty("c3m2v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m2v4 { get; set; }
        [JsonProperty("c3m2v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m2v5 { get; set; }
        [JsonProperty("c3m3v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m3v1 { get; set; }
        [JsonProperty("c3m3v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m3v2 { get; set; }
        [JsonProperty("c3m3v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m3v3 { get; set; }
        [JsonProperty("c3m3v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m3v4 { get; set; }
        [JsonProperty("c3m3v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m3v5 { get; set; }
        [JsonProperty("c3m4v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m4v1 { get; set; }
        [JsonProperty("c3m4v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m4v2 { get; set; }
        [JsonProperty("c3m4v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m4v3 { get; set; }
        [JsonProperty("c3m4v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m4v4 { get; set; }
        [JsonProperty("c3m4v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m4v5 { get; set; }
        [JsonProperty("c3m5v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m5v1 { get; set; }
        [JsonProperty("c3m5v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m5v2 { get; set; }
        [JsonProperty("c3m5v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m5v3 { get; set; }
        [JsonProperty("c3m5v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m5v4 { get; set; }
        [JsonProperty("c3m5v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c3m5v5 { get; set; }
		[JsonProperty("c4m1v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m1v1 { get; set; }
        [JsonProperty("c4m1v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m1v2 { get; set; }
        [JsonProperty("c4m1v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m1v3 { get; set; }
        [JsonProperty("c4m1v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m1v4 { get; set; }
        [JsonProperty("c4m1v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m1v5 { get; set; }
        [JsonProperty("c4m2v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m2v1 { get; set; }
        [JsonProperty("c4m2v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m2v2 { get; set; }
        [JsonProperty("c4m2v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m2v3 { get; set; }
        [JsonProperty("c4m2v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m2v4 { get; set; }
        [JsonProperty("c4m2v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m2v5 { get; set; }
        [JsonProperty("c4m3v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m3v1 { get; set; }
        [JsonProperty("c4m3v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m3v2 { get; set; }
        [JsonProperty("c4m3v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m3v3 { get; set; }
        [JsonProperty("c4m3v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m3v4 { get; set; }
        [JsonProperty("c4m3v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m3v5 { get; set; }
        [JsonProperty("c4m4v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m4v1 { get; set; }
        [JsonProperty("c4m4v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m4v2 { get; set; }
        [JsonProperty("c4m4v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m4v3 { get; set; }
        [JsonProperty("c4m4v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m4v4 { get; set; }
        [JsonProperty("c4m4v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m4v5 { get; set; }
        [JsonProperty("c4m5v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m5v1 { get; set; }
        [JsonProperty("c4m5v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m5v2 { get; set; }
        [JsonProperty("c4m5v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m5v3 { get; set; }
        [JsonProperty("c4m5v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m5v4 { get; set; }
        [JsonProperty("c4m5v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c4m5v5 { get; set; }
		[JsonProperty("c5m1v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m1v1 { get; set; }
        [JsonProperty("c5m1v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m1v2 { get; set; }
        [JsonProperty("c5m1v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m1v3 { get; set; }
        [JsonProperty("c5m1v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m1v4 { get; set; }
        [JsonProperty("c5m1v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m1v5 { get; set; }
        [JsonProperty("c5m2v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m2v1 { get; set; }
        [JsonProperty("c5m2v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m2v2 { get; set; }
        [JsonProperty("c5m2v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m2v3 { get; set; }
        [JsonProperty("c5m2v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m2v4 { get; set; }
        [JsonProperty("c5m2v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m2v5 { get; set; }
        [JsonProperty("c5m3v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m3v1 { get; set; }
        [JsonProperty("c5m3v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m3v2 { get; set; }
        [JsonProperty("c5m3v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m3v3 { get; set; }
        [JsonProperty("c5m3v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m3v4 { get; set; }
        [JsonProperty("c5m3v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m3v5 { get; set; }
        [JsonProperty("c5m4v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m4v1 { get; set; }
        [JsonProperty("c5m4v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m4v2 { get; set; }
        [JsonProperty("c5m4v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m4v3 { get; set; }
        [JsonProperty("c5m4v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m4v4 { get; set; }
        [JsonProperty("c5m4v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m4v5 { get; set; }
        [JsonProperty("c5m5v1", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m5v1 { get; set; }
        [JsonProperty("c5m5v2", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m5v2 { get; set; }
        [JsonProperty("c5m5v3", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m5v3 { get; set; }
        [JsonProperty("c5m5v4", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m5v4 { get; set; }
        [JsonProperty("c5m5v5", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool c5m5v5 { get; set; }
    }

    public class Quests      // stats on player success/fail on missions
    {
        [JsonProperty("m1q", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool m1q { get; set; }
        [JsonProperty("m2q", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool m2q { get; set; }
        [JsonProperty("m3q", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool m3q { get; set; }
        [JsonProperty("m4q", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool m4q { get; set; }
        [JsonProperty("m5q", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool m5q { get; set; }
    }

    public class coll              //defines the variables scheme of all documents in all collections in the DB 
    {
        [JsonProperty("votes", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Votes votes { get; set; }
        [JsonProperty("quests", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Quests quests { get; set; }
        [JsonProperty("variant", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Variant variant { get; set; }
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string name { get; set; }
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string status { get; set; }
        [JsonProperty("_id", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string _id { get; set; }
        [JsonProperty("_etag", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string _etag { get; set; }
        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string member { get; set; }
        [JsonProperty("game_password", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string game_password { get; set; }
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool active { get; set; }
        [JsonProperty("is_merlin", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool is_merlin { get; set; }
        [JsonProperty("is_leader", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool is_leader { get; set; }
        [JsonProperty("online", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool online { get; set; }
        [JsonProperty("_updated", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string _updated { get; set; }
        [JsonProperty("winners", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string winners { get; set; }
        [JsonProperty("assassin", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string assassin { get; set; }
        [JsonProperty("merlin", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string merlin { get; set; }
        [JsonProperty("assassin_kill", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string assassin_kill { get; set; }
        [JsonProperty("password", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string password { get; set; }
        [JsonProperty("_created", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string _created { get; set; }
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string role { get; set; }
        [JsonProperty("client_type", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string client_type { get; set; }
        [JsonProperty("team_approved", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool team_approved { get; set; }
        [JsonProperty("active_game", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string active_game { get; set; }
        [JsonProperty("leader", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string leader { get; set; }
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string location { get; set; }
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string result { get; set; }
        [JsonProperty("mission", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int mission { get; set; }
        [JsonProperty("vote", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int vote { get; set; }
        [JsonProperty("team_count", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int team_count { get; set; }
        [JsonProperty("fail_factor", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int fail_factor { get; set; }
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int success { get; set; }
        [JsonProperty("NumberOfPlayers", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int NumberOfPlayers { get; set; }
        [JsonProperty("failure", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int failure { get; set; }
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int number { get; set; }
        [JsonProperty("team", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> team { get; set; }
        [JsonProperty("previous_leaders", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> previous_leaders { get; set; }
        [JsonProperty("previous_missions", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> previous_missions { get; set; }
        [JsonProperty("excalibur_effected", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string excalibur_effected { get; set; }
        [JsonProperty("excalibur_user", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string excalibur_user { get; set; }
        [JsonProperty("players", NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> players { get; set; }
    }

    class comm
    {

        public comm()
        {
        }

        public coll GET(string collection, string doc)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://korenlev.com:5000");
            var GETrequest = new RestRequest(collection+"/" + doc, Method.GET);
            IRestResponse GETresponse = client.Execute(GETrequest);
            var GETresponseJSON = JsonConvert.DeserializeObject<coll>(GETresponse.Content);
            return GETresponseJSON;
        }

        public string GETF(string collection, string key, string value)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://korenlev.com:5000");
            var GETrequest = new RestRequest(collection + "?where={" + key + ":" + value + "}", Method.GET);
            IRestResponse GETresponse = client.Execute(GETrequest);
            return GETresponse.Content;
        }

        public string POST(string collection, coll data)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://korenlev.com:5000");
            var POSTrequest = new RestRequest(collection + "/", Method.POST);
            POSTrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
            POSTrequest.RequestFormat = DataFormat.Json;
            var json = JsonConvert.SerializeObject(data);
            POSTrequest.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            IRestResponse POSTresponse = client.Execute(POSTrequest);
            return POSTresponse.Content;
        }

        public string DELETE(string collection, string doc)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://korenlev.com:5000");
            var GETrequest = new RestRequest(collection + "/" + doc, Method.GET);
            IRestResponse GETresponse = client.Execute(GETrequest);
            var GETresponseJSON = JsonConvert.DeserializeObject<coll>(GETresponse.Content);
            var doc_id = GETresponseJSON._id;
            var DELrequest = new RestRequest(collection + "/" + doc_id, Method.DELETE);
            IRestResponse DELresponse = client.Execute(DELrequest);
            return DELresponse.Content;
        }

        public string PATCH(string collection, string doc, coll data)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("http://korenlev.com:5000");
            var GETrequest = new RestRequest(collection + "/" + doc, Method.GET);
            IRestResponse GETresponse = client.Execute(GETrequest);
            var GETresponseJSON = JsonConvert.DeserializeObject<coll>(GETresponse.Content);
            var doc_id = GETresponseJSON._id;
            var PATrequest = new RestRequest(collection + "/" + doc_id, Method.PATCH);
            PATrequest.AddHeader("Content-Type", "application/json; charset=utf-8");
            PATrequest.RequestFormat = DataFormat.Json;
            var json = JsonConvert.SerializeObject(data);
            PATrequest.AddJsonBody(json);
            IRestResponse PATresponse = client.Execute(PATrequest);
            return PATresponse.Content;
        }
    }

}
