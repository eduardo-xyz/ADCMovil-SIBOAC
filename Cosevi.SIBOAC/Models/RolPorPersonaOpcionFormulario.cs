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

    public partial class RolPorPersonaOpcionFormulario
    {

        [DisplayName("Codigo del rol de la persona")]
        [Required(ErrorMessage = "El codigo es obligatorio")]
        public int CodigoRolPersona { get; set; }

        [DisplayName("Codigo del formilario")]
        [Required(ErrorMessage = "El codigo es obligatorio")]
        public int CodigoOpcionFormulario { get; set; }

        [DisplayName("Estado")]
        [StringLength(1, ErrorMessage = "El estado no debe ser mayor a 1 caracter.")]
        [Required(ErrorMessage = "El estado es obligatorio")]
        public string Estado { get; set; }

        [DisplayName("Fecha de inicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
        public System.DateTime FechaDeInicio { get; set; }

        [DisplayName("Fecha de fin")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "La fecha de fin es obligatoria")]
        public System.DateTime FechaDeFin { get; set; }

        public string DescripcionCodigoOpcionFormulario
        {
            get
            {
                string Descripcion = "";
                PC_HH_AndroidEntities db = new PC_HH_AndroidEntities();
                {
                    OpcionDeFormulario opcionDeFormulario = db.OPCIONFORMULARIO.Find(CodigoOpcionFormulario);
                    if (opcionDeFormulario.Id == CodigoOpcionFormulario)
                    {
                        return Descripcion = opcionDeFormulario.Descripcion;
                    }
                }
                return Descripcion;
            }
        }


        public string DescripcionCodigoRolPersona
        {
            get
            {
                string Descripcion = "";
                PC_HH_AndroidEntities db = new PC_HH_AndroidEntities();
                {
                    RolPorPersona rolPorPersona = db.ROLPERSONA.Find(CodigoRolPersona.ToString());
                    if (rolPorPersona.Id.Trim() == CodigoRolPersona.ToString().Trim())
                    {
                        return Descripcion = rolPorPersona.Descripcion;
                    }
                }
                return Descripcion;
            }
        }

    }




}
