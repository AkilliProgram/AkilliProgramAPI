using System;
using System.Collections.Generic;
using System.Text;

namespace DataService.CariModulu
{


    public class carihesap
    {
        public long rec_id { get; set; }

        public int rec_status { get; set; }

        public DateTime rec_date_added { get; set; }

        public long rec_user_added { get; set; }

        public DateTime rec_date_updated { get; set; }

        public long rec_user_updated { get; set; }

        public string car_kod { get; set; }

        public string car_adi { get; set; }

        public int car_tip { get; set; }

        public string car_sahip_adi { get; set; }

        public string car_sahip_soyadi { get; set; }

        public string car_yetkili_adi { get; set; }

        public int car_musteri_mi { get; set; }

        public int car_satici_mi { get; set; }

        public int car_bayi_mi { get; set; }

        public string car_fatura_adresi { get; set; }

        public string car_fatura_ilce { get; set; }

        public string car_fatura_sehir { get; set; }

        public string car_fatura_ulke { get; set; }

        public string car_teslim_adres { get; set; }

        public string car_teslim_ilce { get; set; }

        public string car_teslim_sehir { get; set; }

        public string car_teslim_ulke { get; set; }

        public string car_vergi_dairesi { get; set; }

        public string car_vergi_numarasi { get; set; }

        public string car_telefon_numarasi_1 { get; set; }

        public string car_telefon_numarasi_2 { get; set; }

        public string car_faks_numarasi { get; set; }

        public string car_cep_numarasi_1 { get; set; }

        public string car_cep_numarasi_2 { get; set; }

        public string car_eposta_1 { get; set; }

        public string car_eposta_2 { get; set; }

        public string car_web_sitesi { get; set; }

        public string car_ozel_kod_1 { get; set; }

        public string car_ozel_kod_2 { get; set; }

        public string car_ozel_kod_3 { get; set; }

        public string car_ozel_kod_4 { get; set; }

        public string car_ozel_kod_5 { get; set; }

        public string car_aciklama { get; set; }

        public int? car_odeme_opsiyonu { get; set; }

        public DateTime? car_kilit_tarihi { get; set; }

        public string car_banka_1_adi { get; set; }

        public string car_banka_1_sube_kodu { get; set; }

        public string car_banka_1_sube_adi { get; set; }

        public string car_banka_1_hesap_numarasi { get; set; }

        public string car_banka_1_iban { get; set; }

        public string car_banka_1_swift { get; set; }

        public string car_banka_2_adi { get; set; }

        public string car_banka_2_sube_kodu { get; set; }

        public string car_banka_2_sube_adi { get; set; }

        public string car_banka_2_hesap_numarasi { get; set; }

        public string car_banka_2_iban { get; set; }

        public string car_banka_2_swift { get; set; }

        public string car_bolge { get; set; }

        public string car_grup { get; set; }

        public float? car_borc_limiti { get; set; }

        public float? car_teminat_tutari { get; set; }

        public int? car_ef_durum { get; set; }

        public string car_ef_urn { get; set; }

        public string car_efa_eposta { get; set; }

        public string car_mersis_no { get; set; }

        public string car_ticaret_sicil_no { get; set; }

    }



}
