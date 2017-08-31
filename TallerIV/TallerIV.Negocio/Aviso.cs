﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TallerIV.Negocio
{
    public class Aviso
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        //Reclutador?
    }
}