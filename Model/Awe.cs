﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aweAPI.Model
{
    public class Video
    {
        public string id { get; set; }
        public string title { get; set; }
        public int duration { get; set; }
        public List<string> tags { get; set; }
        public string profileImage { get; set; }
        public string thumbImage { get; set; }
        public List<string> previewImages { get; set; }
        public string targetUrl { get; set; }
        public string detailsUrl { get; set; }
        public string quality { get; set; }
        public bool isHd { get; set; }
        public string uploader { get; set; }
        public string uploaderLink { get; set; }
    }
    
    public class Pagination
    {
        public int total { get; set; }
        public int count { get; set; }
        public int perPage { get; set; }
        public int currentPage { get; set; }
        public int totalPages { get; set; }
    }

    public class Data
    {
        public List<Video> videos { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Awe
    {
        public bool success { get; set; }
        public string status { get; set; }
        public Data data { get; set; }
    }
    
}
