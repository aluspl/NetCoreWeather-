﻿using System;

namespace Backend.Services.Weather
{
    public class RootData
    {
        public Query query { get; set; }
    }

    public class Query
    {
        public int count { get; set; }
        public DateTime created { get; set; }
        public string lang { get; set; }
        public Results results { get; set; }
    }

    public class Results
    {
        public Channel channel { get; set; }
    }

    public class Channel
    {
        public Units units { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public string language { get; set; }
        public string lastBuildDate { get; set; }
        public string ttl { get; set; }
        public Location location { get; set; }
        public Wind wind { get; set; }
        public Atmosphere atmosphere { get; set; }
        public Astronomy astronomy { get; set; }
        public Image image { get; set; }
        public Item item { get; set; }
    }

    public class Units
    {
        public string distance { get; set; }
        public string pressure { get; set; }
        public string speed { get; set; }
        public string temperature { get; set; }
    }

    public class Location
    {
        public string city { get; set; }
        public string country { get; set; }
        public string region { get; set; }
    }
    public class Temperature
    {
        public double value { get; set; }
        public string format { get; set; }
    }
    public class Wind
    {
        public string chill { get; set; }
        public string direction { get; set; }
        public string speed { get; set; }
    }

    public class Atmosphere
    {
        public int humidity { get; set; }
        public string pressure { get; set; }
        public string rising { get; set; }
        public string visibility { get; set; }
    }

    public class Astronomy
    {
        public string sunrise { get; set; }
        public string sunset { get; set; }
    }

    public class Image
    {
        public string title { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string link { get; set; }
        public string url { get; set; }
    }

    public class Item
    {
        public string title { get; set; }
        public double lat { get; set; }
        public double _long { get; set; }
        public string link { get; set; }
        public string pubDate { get; set; }
        public Condition condition { get; set; }
        public Forecast[] forecast { get; set; }
        public string description { get; set; }
        public Guid guid { get; set; }
    }

    public class Condition
    {
        public int code { get; set; }
        public string date { get; set; }
        public int temp { get; set; }
        public string text { get; set; }
    }

    public class Guid
    {
        public string isPermaLink { get; set; }
    }

    public class Forecast
    {
        public string code { get; set; }
        public string date { get; set; }
        public string day { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public string text { get; set; }
    }
}