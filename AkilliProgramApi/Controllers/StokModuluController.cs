using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DataService.StokModulu;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AkilliProgramApi.Controllers
{
    [Route("api/stok")]
    [Produces("application/json")]
    // [ApiController]

    public class StokModuluController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _enviroment;

        public StokModuluController(IConfiguration configuration, IHostingEnvironment enviroment)
        {
            this._configuration = configuration;
            this._enviroment = enviroment;
        }

        private string GetConnection()
        {
            try
            {
                return _configuration["ConnectionStrings:AkilliProgramCnn"];
            }
            catch
            {
                return "error";
            }
        }


        [HttpGet("getstok")]
        public IActionResult GetStokKarti()
        {
            string SQL = @"SELECT * FROM dbo.tbl_stok_karti";

            var conn = new SqlConnection(GetConnection());

            try
            {
                var db_rows = conn.Query<stokkarti>(SQL);



                return Ok(db_rows);
            }
            catch (Exception xp1)
            {
                return BadRequest(xp1.Message);
            }

        }

        [HttpPost("savestokkarti")]
        public IActionResult SaveStokKarti([FromBody]  stokkarti model)
        {
            try
            {
                if (model != null)
                {

                    if (model.stk_birim_ref==null) { model.stk_birim_ref = 0; }

                    var conn = new SqlConnection(GetConnection());

                    // kontrol burda olacak stok kodu mukerrer olmayacak

                     var ok = conn.ExecuteScalar(@"SELECT count(*) as adet FROM tbl_stok_karti WHERE stk_kod="+ model.stk_kod).ToString();
                     if (ok == null) { ok = "0"; }
                     if (ok.Trim() == "") { ok = "0"; }

                    if  (ok!="0")
                    {

                    } else
                    {

                    }
                   // bool xx = String.IsNullOrEmpty(ok.ToString());

                    //                    if (Control == false){

                  #region kayıt methodu INSERT SQL

                    string SQL = @" INSERT INTO tbl_stok_karti
           (rec_status
           ,rec_user_added
           ,rec_user_updated
           ,stk_kod
           ,stk_adi
           ,stk_tip
           ,stk_birim_ref
           ,stk_ozel_kod_1
           ,stk_ozel_kod_2
           ,stk_ozel_kod_3
           ,stk_ozel_kod_4
           ,stk_ozel_kod_5
           ,stk_alis_fiyati_1
           ,stk_alis_fiyati_2
           ,stk_satis_fiyati_1
           ,stk_satis_fiyati_2
           ,stk_satis_fiyati_3
           ,stk_alis_kdv_orani
           ,stk_satis_kdv_orani
           ,stk_otv_kod
           ,stk_otv_orani
           ,stk_en_az_miktar
           ,stk_en_cok_miktar
           ,stk_optimum_miktar)
     VALUES
      
           (@rec_status
           ,@rec_user_added
           ,@rec_user_updated
           ,@stk_kod
           ,@stk_adi
           ,@stk_tip
           ,@stk_birim_ref
           ,@stk_ozel_kod_1
           ,@stk_ozel_kod_2
           ,@stk_ozel_kod_3
           ,@stk_ozel_kod_4
           ,@stk_ozel_kod_5
           ,@stk_alis_fiyati_1
           ,@stk_alis_fiyati_2
           ,@stk_satis_fiyati_1
           ,@stk_satis_fiyati_2
           ,@stk_satis_fiyati_3
           ,@stk_alis_kdv_orani
           ,@stk_satis_kdv_orani
           ,@stk_otv_kod
           ,@stk_otv_orani
           ,@stk_en_az_miktar
           ,@stk_en_cok_miktar
           ,@stk_optimum_miktar)    ";
             #endregion


                    if (model.rec_id > 0)
                        {

                            SQL = @" UPDATE tbl_stok_karti SET 
rec_status = @rec_status, 
rec_user_added = @rec_user_added, 
rec_date_updated = @rec_date_updated, 
rec_user_updated = @rec_user_updated, 
stk_kod = @stk_kod, 
stk_adi = @stk_adi,
stk_tip = @stk_tip,
stk_birim_ref = @stk_birim_ref,
stk_ozel_kod_1 = @stk_ozel_kod_1,
stk_ozel_kod_2 = @stk_ozel_kod_2,
stk_ozel_kod_3 = @stk_ozel_kod_3,
stk_ozel_kod_4 = @stk_ozel_kod_4,
stk_ozel_kod_5 = @stk_ozel_kod_5,
stk_alis_fiyati_1 = @stk_alis_fiyati_1,
stk_alis_fiyati_2 = @stk_alis_fiyati_2,
stk_satis_fiyati_1 = @stk_satis_fiyati_1,
stk_satis_fiyati_2 = @stk_satis_fiyati_2,
stk_satis_fiyati_3 = @stk_satis_fiyati_3,
stk_alis_kdv_orani = @stk_alis_kdv_orani,
stk_satis_kdv_orani = @stk_satis_kdv_orani,
stk_otv_kod = @stk_otv_kod,
stk_otv_orani = @stk_otv_orani,
stk_en_az_miktar = @stk_en_az_miktar,
stk_en_cok_miktar = @stk_en_cok_miktar,
stk_optimum_miktar = @stk_optimum_miktar


WHERE rec_id=@rec_id ";
                        }

                        var prm = new {
                            rec_status = model.rec_status,
                            rec_user_added = model.rec_user_added,
                            rec_user_updated = model.rec_user_updated,
                            stk_kod = model.stk_kod,
                            stk_adi = model.stk_adi,
                            stk_tip = model.stk_tip,
                            stk_birim_ref = model.stk_birim_ref,
                            stk_ozel_kod_1 = model.stk_ozel_kod_1,
                            stk_ozel_kod_2 = model.stk_ozel_kod_2,
                            stk_ozel_kod_3 = model.stk_ozel_kod_3,
                            stk_ozel_kod_4 = model.stk_ozel_kod_4,
                            stk_ozel_kod_5 = model.stk_ozel_kod_5,
                            stk_alis_fiyati_1 = model.stk_alis_fiyati_1,
                            stk_alis_fiyati_2 = model.stk_alis_fiyati_2,
                            stk_satis_fiyati_1 = model.stk_satis_fiyati_1,
                            stk_satis_fiyati_2 = model.stk_satis_fiyati_2,
                            stk_satis_fiyati_3 = model.stk_satis_fiyati_3,
                            stk_alis_kdv_orani = model.stk_alis_kdv_orani,
                            stk_satis_kdv_orani = model.stk_satis_kdv_orani,
                            stk_otv_kod = model.stk_otv_kod,
                            stk_otv_orani = model.stk_otv_orani,
                            stk_en_az_miktar = model.stk_en_az_miktar,
                            stk_en_cok_miktar = model.stk_en_cok_miktar,
                            stk_optimum_miktar = model.stk_optimum_miktar
                        };

                        var affectRows = conn.Execute(SQL, prm);
 //                   }

                    return Ok("ok");
                }
                else
                {
                    return BadRequest("boş");
                }
            }
            catch (Exception xp1)
            {
                return BadRequest(xp1.Message);
            }

        }


        [HttpGet("getstokislemfisi")]
        public IActionResult GetStokIslemFisi()
        {
            string SQL = @"SELECT * FROM dbo.tbl_stok_islem_fisi";

            var conn = new SqlConnection(GetConnection());

            try
            {
                var db_rows = conn.Query<stokislemfisi>(SQL);



                return Ok(db_rows);
            }
            catch (Exception xp1)
            {
                return BadRequest(xp1.Message);
            }

        }
        [HttpGet("getstokislemsatiri")]
        public IActionResult GetStokIslemSatiri()
        {
            string SQL = @"SELECT * FROM dbo.tbl_stok_islem_satiri";

            var conn = new SqlConnection(GetConnection());

            try
            {
                var db_rows = conn.Query<stokislemsatiri>(SQL);



                return Ok(db_rows);
            }
            catch (Exception xp1)
            {
                return BadRequest(xp1.Message);
            }

        }






    }
}