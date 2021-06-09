﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace picacomic_api.Http.Response
{
    public class Chat
    {
        [JsonProperty("chatList")]
        public List<ChatList> ChatList { get; set; }
    }
    public class ChatList
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }
    }
}
