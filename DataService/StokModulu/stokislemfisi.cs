using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.StokModulu
{
    public class stokislemfisi
    {
        public long rec_id { get; set; }

        public int rec_status { get; set; }

        public DateTime rec_date_added { get; set; }

        public long rec_user_added { get; set; }

        public DateTime rec_date_updated { get; set; }

        public long rec_user_updated { get; set; }

        public int sif_grup { get; set; }

        public int sif_tip { get; set; }

        public DateTime sif_tarih { get; set; }

        public long sif_cari_hesap_id { get; set; }

        public string sif_fis_no { get; set; }

        public int sif_fis_durum { get; set; }

        public int sif_fis_rev_no { get; set; }

        public int sif_fis_onemi { get; set; }

        public string sif_belge_no { get; set; }

        public long sif_depo_id { get; set; }

        public long sif_karsi_depo_id { get; set; }

        public long sif_satici_id { get; set; }

        public string sif_aciklama { get; set; }

        public float sif_satir_toplam { get; set; }

        public float sif_indirim_orani { get; set; }

        public float sif_indirim_tutari { get; set; }

        public float sif_kdv_tatari { get; set; }

        public float sif_kdv_1_oran { get; set; }

        public float sif_kdv_1_tutar { get; set; }

        public float sif_kdv_2_oran { get; set; }

        public float sif_kdv_2_tutar { get; set; }

        public float sif_kdv_3_oran { get; set; }

        public float sif_kdv_3_tutar { get; set; }

        public float sif_otv_oran { get; set; }

        public float sif_otv_tutar { get; set; }

        public float sif_tutar { get; set; }

        public string sif_ozel_kod_1 { get; set; }

        public string sif_ozel_kod_2 { get; set; }

        public string sif_ozel_kod_3 { get; set; }

        public string sif_ozel_kod_4 { get; set; }

        public string sif_ozel_kod_5 { get; set; }

    }

}
