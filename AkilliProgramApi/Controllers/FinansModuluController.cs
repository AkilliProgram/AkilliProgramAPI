using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DataService.FinansModulu;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AkilliProgramApi.Controllers
{
    [Route("api/finans")]
    [Produces("application/json")]

    //[ApiController]
    public class FinansModuluController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _enviroment;

        public FinansModuluController(IConfiguration configuration, IHostingEnvironment environment)
        {
            this._configuration = configuration;
            this._enviroment = environment;
        }
        private string GetConnection()
        {
            try
            {
                return _configuration["ConnectionStrings:AkilliProgramCnn"];
            }
            catch (Exception xp1)
            {
                return xp1.Message;
            }

        }
        [HttpGet("getfinansislem")]
        public IActionResult GetFinansIslem()
        {
            string SQL = @"SELECT * from dbo.tbl_finans_islem";

            var conn = new SqlConnection(GetConnection());

            try
            {
                var db_rows = conn.Query<finansislem>(SQL);



                return Ok(db_rows);
            }
            catch (Exception xp1)
            {
                return BadRequest(xp1.Message);
            }
        }

        [HttpGet("getkasa")]
        public IActionResult GetKasa()
        {
            string SQL = @"SELECT * from dbo.tbl_kasa";

            var conn = new SqlConnection(GetConnection());

            try
            {
                var db_rows = conn.Query<kasa>(SQL);



                return Ok(db_rows);
            }
            catch (Exception xp1)
            {
                return BadRequest(xp1.Message);
            }
        }


    }
}