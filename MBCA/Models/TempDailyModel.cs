﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataTables;

namespace chevron.Models
{
    public class TempDailyModel
    {
        public class temp_daily
        {
            [EditorHttpName("id_temp")]
            public Int32 id { get; set; }

            [EditorHttpName("dur")]
            public decimal duration { get; set; }

            [EditorHttpName("id_un")]
            public string id_unit { get; set; }
            

        }
        public class unit_table
        {
            [EditorHttpName("unit")]
            public string name { get; set; }

        }

    }
}