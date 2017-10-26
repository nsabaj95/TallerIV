﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerIV.Dominio.Coincidencias.CalculadoresDePorcentaje
{
    public class CalculadorDePorcentajeEmpleado : CalcularPorcentaje
    {
        public CalculadorDePorcentajeEmpleado() { }
        public CalculadorDePorcentajeEmpleado(UsuarioEmpleado empleado)
        {
            this.Empleado = empleado;
        }
        public Coincidencia GenerarCoincidencia(Aviso aviso)
        {
            int PuntajeMaximo = CalcularPuntajeMaximo(aviso);
            int PuntajeEmpleado = 0;
            foreach (Tag tag in aviso.TagsBuscados)
            {
                int i = 0;
                while (tag.Titulo != Empleado.Tags[i].Titulo || i < Empleado.Tags.Count)
                {
                    i++;
                }
                if (tag.Titulo == Empleado.Tags[i].Titulo)
                {
                    //PuntajeEmpleado += tag.Prioridad;
                }
            }
            Coincidencia coincidencia = new Coincidencia(PuntajeMaximo / PuntajeEmpleado, Empleado, aviso);

            return coincidencia;
        }
        public UsuarioEmpleado Empleado { get; set; }
    }
}
