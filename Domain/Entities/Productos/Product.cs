using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Entities.Productos
{
    //TODO creacion de una nueva clase para no modificar la clase producto por si la ocupamos mas adelante
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
    }
}
