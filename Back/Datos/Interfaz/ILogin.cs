﻿using Back.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Interfaz
{
    public interface ILogin
    {
        bool Logeado(Cliente c);
    }
}
