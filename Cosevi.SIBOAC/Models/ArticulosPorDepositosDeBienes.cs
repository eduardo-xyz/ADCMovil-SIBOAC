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
    using System.Web.Mvc;

    public partial class ArticulosPorDepositosDeBienes
    {
        public int CodigoDepositosBienes { get; set; }
        public int CodigoOpcionFormulario { get; set; }
        public string CodigoArticulo { get; set; }
        public string Conducta { get; set; }
        public System.DateTime FechaDeInicio { get; set; }
        public System.DateTime FechaDeFin { get; set; }
        public string Estado { get; set; }

        public string DescripcionDepositosBienes
        {
            get
            {
                string Descripcion = "";
                PC_HH_AndroidEntities db = new PC_HH_AndroidEntities();
              
                DepositosBienes depositoBienes = db.DEPOSITOBIENES.Find(CodigoDepositosBienes);
                if (depositoBienes.Id== CodigoDepositosBienes)
                {
                   return Descripcion = depositoBienes.Descripcion;
                }
                return Descripcion;
            }
        }
        public string DescripcionCodigoFormulario
        {
            get
            {
                string Descripcion = "";
                PC_HH_AndroidEntities db = new PC_HH_AndroidEntities();

                OpcionDeFormulario opcionFormulario = db.OPCIONFORMULARIO.Find(CodigoOpcionFormulario);
                if (opcionFormulario.Id == CodigoOpcionFormulario)
                {
                    return Descripcion = opcionFormulario.Descripcion;
                }
                return Descripcion;
            }
        }
        public string DescripcionArticulo
        {
            get
            {
                string Descripcion = "";
                PC_HH_AndroidEntities db = new PC_HH_AndroidEntities();

                CatalogoDeArticulos articulo = db.CATARTICULO.Find(CodigoArticulo.Trim(),Conducta,FechaDeInicio,FechaDeFin);
                if (articulo.Id.Trim() == CodigoArticulo.Trim())
                {
                    return Descripcion = articulo.Descripcion;
                }
                return Descripcion;
            }
        }


    }
}
