﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace _Tester
{
    public class Tester
    {
        public void TestConn()
        {

            string connStr = @"Server=.\SQLExpress;Database=LZHBaseFrame3.Normal;User ID=LZHBaseFrame;Password=test;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
        }

    }
}
