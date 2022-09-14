using JJY.NC.Core.Controllers;
using JJYRest;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FixedAssetsService.Controllers
{
    /// <summary>
    /// 【0】 测试  http://127.0.0.1:9999/swagger/index.html
    /// </summary>
    public class Test : BaseController
    {
        [HttpPost(nameof(Add))]
        public object Add(Request<ArgsData> args)
        {
            var data = args.Arg1;

            data.P1 = "Success";

            return data.NewResultJsonStr();
        }

        /// <summary>
        /// http://127.0.0.1:9999/demo/test/add
        /// </summary>
        /// <returns></returns>
        [HttpGet(nameof(Add))]
        public object Add_Get()
        {
            var rs = DateTime.Now.ToFullString();

            return rs;
        }
    }

    public class ArgsData
    {

        public string P1 { get; set; }


        public int P2 { get; set; }

        public DateTime P3 { get; set; }

        public List<ArgsDataItem> Items { get; set; }
    }

    public class ArgsDataItem
    {

        public string PI1 { get; set; }


    }

}
