﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class Session
    {
        public static long LoggedInUserID { get; set; }
        public static string Username { get; set; }
    }
}
