using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.StokModulu
{
    public class stokkarti
    {
        public long rec_id { get; set; }

        public int rec_status { get; set; }

        public DateTime rec_date_added { get; set; }

        public long rec_user_added { get; set; }

        public DateTime rec_date_updated { get; set; }

        public long rec_user_updated { get; set; }

        public string stk_kod { get; set; }

        public string stk_adi { get; set; }

        public string stk_tip { get; set; }

        public long stk_birim_ref { get; set; }

        public string stk_ozel_kod_1 { get; set; }

        public string stk_ozel_kod_2 { get; set; }

        public string stk_ozel_kod_3 { get; set; }

        public string stk_ozel_kod_4 { get; set; }

        public string stk_ozel_kod_5 { get; set; }

        public float? stk_alis_fiyati_1 { get; set; }

        public float? stk_alis_fiyati_2 { get; set; }

        public float? stk_satis_fiyati_1 { get; set; }

        public float? stk_satis_fiyati_2 { get; set; }

        public float? stk_satis_fiyati_3 { get; set; }

        public float? stk_alis_kdv_orani { get; set; }

        public float? stk_satis_kdv_orani { get; set; }

        public string stk_otv_kod { get; set; }

        public float? stk_otv_orani { get; set; }

        public float? stk_en_az_miktar { get; set; }

        public float? stk_en_cok_miktar { get; set; }

        public float? stk_optimum_miktar { get; set; }

    }

}
