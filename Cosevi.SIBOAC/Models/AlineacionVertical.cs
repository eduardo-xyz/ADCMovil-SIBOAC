//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cosevi.SIBOAC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class AlineacionVertical
    {
        [DisplayName("C�digo")]
        [Required(ErrorMessage = "El c�digo es obligatorio")]
        public int Id { get; set; }

        [DisplayName("Descripci�n")]
        [Required(ErrorMessage = "La descripci�n es obligatoria")]
        [StringLength(30, ErrorMessage = "La descripci�n no debe ser mayor a 30 caracteres")]
        public string Descripcion { get; set; }

        [DisplayName("Estado")]
        [StringLength(1, ErrorMessage = "El estado no debe ser mayor a 1 caracter")]
        public string Estado { get; set; }

        [DisplayName("Fecha de Inicio")]
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaDeInicio { get; set; }

        [DisplayName("Fecha de Fin")]
        [Required(ErrorMessage = "La fecha de fin es obligatoria")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> FechaDeFin { get; set; }
    }
}
