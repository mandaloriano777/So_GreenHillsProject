using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenHillsProject.Models
{
    public class Planta
    {
        public string NomeComum { get; set; }
        public string NomeCientifico { get; set; }
        public float TemperaturaRec { get; set; }
        public float UmidadeRec { get; set; }
        public float LuminosidadeRec { get; set; }
    }
}