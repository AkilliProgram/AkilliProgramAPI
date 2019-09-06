using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DataService.CariModulu;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AkilliProgramApi.Controllers
{
    [Route("api/carihesap")]
    [Produces("application/json")]
   // [ApiController]
    public class CariModuluController : Controller
    {

        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _enviroment;

        public CariModuluController(IConfiguration configuration, IHostingEnvironment enviroment)
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


        [HttpGet("getcarihesap")]
        public IActionResult GetCariHesap()
        {
            string SQL = @"SELECT * FROM dbo.tbl_cari_hesap";

            var conn = new SqlConnection(GetConnection());

            try
            {
                var db_rows = conn.Query<carihesap>(SQL);



                return Ok(db_rows);
            }
            catch(Exception xp1)
            {
                return BadRequest(xp1.Message);
            }
            
        }

        [HttpPost("savecarihesapkarti")]
        public IActionResult SaveCariHesapKarti([FromBody]  carihesap model)
        {
            try
            {
                if (model != null)
                {
                    var conn = new SqlConnection(GetConnection());
                    string SQL = @" INSERT INTO tbl_cari_hesap (rec_status  ,rec_date_added, rec_user_added ) 

                                            VALUES(@durum, @eklenme_tarihi, @ekleyen_kullanici )";
                    if (model.rec_status > 0)
                    {
                        SQL = @" UPDATE tbl_tanim SET rec_status=@durum, rec_date_added=@eklenme_tarihi, rec_user_added=@ekleyen_kullanici WHERE rec_id=@kayit_id";
                    }

                    var prm = new { durum = model.rec_status, eklenme_tarihi = model.rec_date_added, ekleyen_kullanici = model.rec_user_added, kayit_id = model.rec_id };

                    var affectRows = conn.Execute(SQL, prm);

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


        [HttpPost("savetbltanim")]
        public IActionResult SaveTblTanim([FromBody]  tbl_tanim model)
        {
            try
            {
                if (model != null)
                {
                    var conn = new SqlConnection(GetConnection());
                    string SQL = @" INSERT INTO tbl_tanim (aciklama  ,tutar ) VALUES(@ACIKLAMA, @TUTAR )";
                    if (model.kod_id > 0)
                    {
                        SQL = @" UPDATE tbl_tanim SET aciklama=@ACIKLAMA, tutar=@TUTAR WHERE kod_id=@KOD_ID";
                    }

                    var prm = new { ACIKLAMA = model.aciklama, TUTAR = model.tutar, KOD_ID = model.kod_id };

                    var affectRows = conn.Execute(SQL, prm);

                    return Ok("ok");
                }
                else
                {
                    return BadRequest("boş");
                }
            }
            catch(Exception xp1)
            {
                return BadRequest(xp1.Message);
            }

        }



    }
}