﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webNA
{
    [Serializable]
    public class UserLogin
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string UserName { get; internal set; }
    }
}