using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.StokModulu
{
    public class stokislemsatiri
    {
        public long rec_id { get; set; }

        public int rec_status { get; set; }

        public DateTime rec_date_added { get; set; }

        public long rec_user_added { get; set; }

        public DateTime rec_date_updated { get; set; }

        public long rec_user_updated { get; set; }

        public int? sis_ent_tip { get; set; }

        public long? sis_ent_id { get; set; }

        public long sis_stok_islem_fisi_id { get; set; }

        public int sis_sira { get; set; }

        public long sis_stok_karti_id { get; set; }

        public string sis_stok_adi { get; set; }

        public float sis_miktar { get; set; }

        public long sis_birim { get; set; }

        public float sis_fiyat { get; set; }

        public float sis_toplam { get; set; }

        public float sis_indirim_1_oran { get; set; }

        public float sis_indirim_1_tutar { get; set; }

        public float sis_indirim_2_oran { get; set; }

        public float sis_indirim_2_tutar { get; set; }

        public float sis_kdv_matrah { get; set; }

        public float sis_kdv_oran { get; set; }

        public float sis_kdv_tutar { get; set; }

        public float sis_tutar { get; set; }

        public string sis_explanation { get; set; }

        public string sis_ozel_kod_1 { get; set; }

        public string sis_ozel_kod_2 { get; set; }

    }

}
