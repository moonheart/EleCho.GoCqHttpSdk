﻿using System.Text.Json.Serialization;

namespace EleCho.GoCqHttpSdk.Action.Model.Data
{
    internal class CqGetImageActionResultDataModel : CqActionResultDataModel
    {
        [JsonConstructor]
        public CqGetImageActionResultDataModel(int size, string filename, string url)
        {
            this.size = size;
            this.filename = filename;
            this.url = url;
        }

        public int size { get; set; }
        public string filename { get; set; }
        public string url { get; set; }
    }
}