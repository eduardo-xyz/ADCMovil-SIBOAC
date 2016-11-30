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
    using System.Web.Mvc;

    public partial class ArticulosPorDepositosDeBienes
    {
        [DisplayName("C�digo de deposito de bienes")]
        [Required(ErrorMessage = "El c�digo es obligatorio")]
        public int CodigoDepositosBienes { get; set; }

        [DisplayName("C�digo de opciones de formulario")]
        [Required(ErrorMessage = "El c�digo es obligatorio")]
        public int CodigoOpcionFormulario { get; set; }

        [DisplayName("C�digo de articulo")]
        [Required(ErrorMessage = "El c�digo es obligatorio")]
        [StringLength(6, ErrorMessage = "El codigo no debe ser mayor a 6 caracteres")]
        public string CodigoArticulo { get; set; }

        [DisplayName("Conducta")]
        [Required(ErrorMessage = "La conducta es obligatoria")]
        [StringLength(2, ErrorMessage = "La conducta no debe ser mayor a 2 caracteres")]
        public string Conducta { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Fecha de inicio")]
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public System.DateTime FechaDeInicio { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Fecha de fin")]
        [Required(ErrorMessage = "La fecha de fin es obligatoria")]
        public System.DateTime FechaDeFin { get; set; }

        [StringLength(1, ErrorMessage = "El estado no debe ser mayor a 1 caracter.")]
        [DisplayName("Estado")]
        [Required(ErrorMessage = "El estado es obligatorio")]
        public string Estado { get; set; }

        public string DescripcionDepositosBienes
        {
            get; set;
        }
        public string DescripcionCodigoFormulario
        {
            get; set;
        }
        public string DescripcionArticulo
        {
            get; set;          
        }


    }
}
