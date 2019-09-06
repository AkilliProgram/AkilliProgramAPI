using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FinansModulu
{
    public class kasa
    {
        public long rec_id { get; set; }

        public int rec_status { get; set; }

        public DateTime rec_date_added { get; set; }

        public long rec_user_added { get; set; }

        public DateTime rec_date_updated { get; set; }

        public long rec_user_updated { get; set; }

        public string kas_kod { get; set; }

        public string kas_adi { get; set; }

        public string kas_yetkili_adi { get; set; }

        public string kas_aciklama { get; set; }

        public string kas_ozel_kod_1 { get; set; }

        public string kas_ozel_kod_2 { get; set; }

        public string kas_ozel_kod_3 { get; set; }

        public string kas_ozel_kod_4 { get; set; }

        public string kas_ozel_kod_5 { get; set; }

    }
}
