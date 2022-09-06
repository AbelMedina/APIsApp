﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Login
    {
        public int num_empleado { get; set; }
        public string pwd { get; set; }
    }

    public class LoginData
    {
        public int id_empleado { get; set; }
        public int num_empleado { get; set; }
        public string nom_empleado { get; set; }
        public string apellido { get; set; }
        public string nom_departamento { get; set; }
        public string email { get; set; }
    }

}
