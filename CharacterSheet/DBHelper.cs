﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source = localhost; Initial Catalog = CharacterDB; " +
                "Integrated Security = True; Pooling = False");
        }
    }
}