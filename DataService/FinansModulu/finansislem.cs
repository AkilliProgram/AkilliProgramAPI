using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.FinansModulu
{
    public class finansislem
    {
        public long rec_id { get; set; }

        public int rec_status { get; set; }

        public DateTime rec_date_added { get; set; }

        public long rec_user_added { get; set; }

        public DateTime rec_date_updated { get; set; }

        public long rec_user_updated { get; set; }

        public int? fin_ent_tip { get; set; }

        public long? fin_ent_id { get; set; }

        public int fin_hareket_tip { get; set; }

        public int fin_tip { get; set; }

        public int? fin_fis_durum { get; set; }

        public string fin_fis_no { get; set; }

        public DateTime fin_tarih { get; set; }

        public DateTime? fin_vade_tarihi { get; set; }

        public string fin_belge_no { get; set; }

        public string fin_ozel_kod_1 { get; set; }

        public string fin_ozel_kod_2 { get; set; }

        public float? fin_tutar { get; set; }

        public string fin_aciklama { get; set; }

        public float? fin_borc { get; set; }

        public float? fin_alacak { get; set; }

        public int? fin_cari_hesap_id { get; set; }

        public int? fin_kasa_id { get; set; }

        public int? fin_banka_hesap_id { get; set; }

        public int? fin_karsi_cari_hesap_id { get; set; }

        public int? fin_karsi_kasa_id { get; set; }

        public int? fin_karsi_banka_hesap_id { get; set; }

        public int? fin_gider1_stok_ref { get; set; }

        public float? fin_gider1_tutar { get; set; }

        public float? fin_gider1_tutar_dv { get; set; }

        public int? fin_gider2_stok_ref { get; set; }

        public float? fin_gider2_tutar { get; set; }

        public float? fin_gider2_tutar_dv { get; set; }

    }

}
