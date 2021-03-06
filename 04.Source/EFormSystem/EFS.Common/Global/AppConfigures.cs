﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFS.Common.Global
{
    public class CryptoParam
    {
        public string key { get; set; }
        public string iv { get; set; }
    }

    public class AppConfigures
    {
        public string ConnectionString { get; set; }

        public int ExpirationMinutes { get; set; }

        public CryptoParam Crypto { get; set; }
    }
}
