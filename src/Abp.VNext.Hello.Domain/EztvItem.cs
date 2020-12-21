﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Abp.VNext.Hello
{

    /// <summary>
    /// https://eztv.io/api/get-torrents?limit=10&page=2000
    /// </summary>
    public class EztvItem : Entity<int>
    {
        public int? xid { get; set; }
        public int date_released_unix { get; set; }// 1544284301
        public string episode { get; set; }// "9"
        public string episode_url { get; set; }// "https://eztv.io/ep/1294453/wrench-wars-s01e09-720p-web-h264-crimson/"
        public string filename { get; set; }// "Wrench.Wars.S01E09.720p.WEB.H264-CRiMSON[eztv].mkv"
        public string hash { get; set; }//"5f77fb220ccda33e9bdeaa86d4a691e7cd6f1df6"
        public int? imdb_id { get; set; }// "6258162"
        public string large_screenshot { get; set; }// "//ezimg.ch/thumbs/wrench-wars-s01e09-720p-web-h264-crimson-large.jpg"
        public string magnet_url { get; set; }// "magnet:?xt=urn:btih:5f77fb220ccda33e9bdeaa86d4a691e7cd6f1df6&dn=Wrench.Wars.S01E09.720p.WEB.H264-CRiMSON%5Beztv%5D&tr=udp://tracker.coppersurfer.tk:80&tr=udp://glotorrents.pw:6969/announce&tr=udp://tracker.leechers-paradise.org:6969&tr=udp://tracker.opentrackr.org:1337/announce&tr=udp://exodus.desync.com:6969"
        public string peers { get; set; }// 0
        public string season { get; set; }// "1"
        public int seeds { get; set; }// 0
        public long size_bytes { get; set; }// "504169575"
        public string small_screenshot { get; set; }// "//ezimg.ch/thumbs/wrench-wars-s01e09-720p-web-h264-crimson-small.jpg"
        public string title { get; set; }// "Wrench Wars S01E09 720p WEB H264-CRiMSON EZTV"
        public string torrent_url { get; set; }// "https://zoink.ch/torrent/Wrench.Wars.S01E09.720p.WEB.H264-CRiMSON[eztv].mkv.torrent"

        public DateTime create_time { get; set; } = DateTime.Now;

    }
}
