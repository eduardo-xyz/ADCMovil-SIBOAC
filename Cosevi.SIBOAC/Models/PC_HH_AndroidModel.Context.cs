﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PC_HH_AndroidEntities : DbContext
    {
        public PC_HH_AndroidEntities()
            : base("name=PC_HH_AndroidEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Iluminacion> Iluminacion { get; set; }
        public virtual DbSet<Maniobra> Maniobra { get; set; }
        public virtual DbSet<MotivoPorNoFirmar> MotivoPorNoFirmars { get; set; }
        public virtual DbSet<Obstaculo> Obstaculo { get; set; }
        public virtual DbSet<OficinaParaImpugnar> OficinaParaImpugnars { get; set; }
        public virtual DbSet<RolDePersonaPorVehiculo> RolDePersonaPorVehiculoes { get; set; }
        public virtual DbSet<Dispositivo> Dispositivoes1 { get; set; }
        public virtual DbSet<Hospital> HOSPITAL { get; set; }
        public virtual DbSet<Inconsistencia> INCONSISTENCIA { get; set; }
        public virtual DbSet<MarcaDeAutomovil> MARCA { get; set; }
        public virtual DbSet<OtroTipoTransporte> OTROTIPOTRANSPORTE { get; set; }
        public virtual DbSet<EstadoDeLaCalzada> ESTCALZADA { get; set; }
        public virtual DbSet<TipoDeEstructura> ESTRUCTURA { get; set; }
        public virtual DbSet<OpcionDeFormulario> OPCIONFORMULARIO { get; set; }
        public virtual DbSet<OpcionesDelPlano> OPCIONPLANO { get; set; }
        public virtual DbSet<Plantillas> PLANTILLAS { get; set; }
        public virtual DbSet<Provincia> PROVINCIA { get; set; }
        public virtual DbSet<Sentido> SENTIDO { get; set; }
        public virtual DbSet<Senalamiento> SEÑALAMIENTO { get; set; }
        public virtual DbSet<Sexo> SEXO { get; set; }
        public virtual DbSet<TipoDeIdentificacion> TIPO_IDENTIFICACION { get; set; }
        public virtual DbSet<TipoDeLicencia> TIPO_LICENCIA { get; set; }
        public virtual DbSet<TipoDeVehiculo> TIPOVEH { get; set; }
        public virtual DbSet<Peaton> Peaton { get; set; }
        public virtual DbSet<Revision> Revision { get; set; }
        public virtual DbSet<RolPorPersona> ROLPERSONA { get; set; }
        public virtual DbSet<Ruta> Ruta { get; set; }
        public virtual DbSet<Tiempo> Tiempo { get; set; }
        public virtual DbSet<TipoDeAccidente> TIPOACCIDENTE { get; set; }
        public virtual DbSet<TipoDeCalzada> TIPOCALZADA { get; set; }
        public virtual DbSet<TipoDeDocumento> TIPODOCUMENTO { get; set; }
        public virtual DbSet<TipoIdDeVehiculo> TIPOIDEVEHICULO { get; set; }
        public virtual DbSet<TipoDeSenalExistente> TIPOSEÑALEXISTE { get; set; }
        public virtual DbSet<ClaseDePlaca> CLASE { get; set; }
        public virtual DbSet<CodigoDeLaPlaca> CODIGO { get; set; }
        public virtual DbSet<CondicionDeLaCalzada> CONDCALZADA { get; set; }
        public virtual DbSet<CondicionDeLaPersona> CONDPERSONA { get; set; }
        public virtual DbSet<Dano> DAÑO { get; set; }
        public virtual DbSet<Delegacion> DELEGACION { get; set; }
        public virtual DbSet<Delito> DELITO { get; set; }
        public virtual DbSet<DepositoDePlaca> DEPOSITOPLACA { get; set; }
        public virtual DbSet<DepositoDeVehiculo> DEPOSITOVEHICULO { get; set; }
        public virtual DbSet<AlineacionHorizontal> ALINHORI { get; set; }
        public virtual DbSet<AlineacionVertical> ALINVERT { get; set; }
        public virtual DbSet<Canton> CANTON { get; set; }
        public virtual DbSet<CaracteristicasDeUbicacion> CARACUBI { get; set; }
        public virtual DbSet<Carril> CARRIL { get; set; }
        public virtual DbSet<Carroceria> CARROCERIA { get; set; }
        public virtual DbSet<Circulacion> CIRCULACION { get; set; }
        public virtual DbSet<Direccion> DIRECCION { get; set; }
        public virtual DbSet<Distrito> DISTRITO { get; set; }
        public virtual DbSet<Examen> EXAMEN { get; set; }
        public virtual DbSet<Inspector> INSPECTOR { get; set; }
        public virtual DbSet<Interseccion> INTERSECCION { get; set; }
        public virtual DbSet<NombreDeMenu> Nombre_Menu { get; set; }
        public virtual DbSet<UnidadesDeAlcohol> UNIDADES_ALCOHOL { get; set; }
        public virtual DbSet<VariablesParaBloqueo> VARIABLESBLOQUEO { get; set; }
        public virtual DbSet<DispositivosMoviles> DispositivosMoviles { get; set; }
        public virtual DbSet<HorasLaborales> HORASLABORALES { get; set; }
        public virtual DbSet<RolDePersonaPorTipoDeIdentificacionDeVehiculo> ROLPERSONAXTIPOIDEVEHICULO { get; set; }
        public virtual DbSet<TiposDeVehiculos> TIPOSVEHICULOS { get; set; }
        public virtual DbSet<Nacionalidad> NACIONALIDAD { get; set; }
        public virtual DbSet<Edad> EDAD { get; set; }
        public virtual DbSet<ArticulosPorDepositosDeBienes> ARTICULOSXDEPOSITOSBIENES { get; set; }
        public virtual DbSet<Autoridad> AUTORIDAD { get; set; }
        public virtual DbSet<CatalogoDeArticulos> CATARTICULO { get; set; }
        public virtual DbSet<DanioPorHospital> DAÑOXHOSPITAL { get; set; }
        public virtual DbSet<DetallePorTipoDanio> DETALLETIPODAÑO { get; set; }
        public virtual DbSet<DetallePorTipoSenial> DETALLETIPOSEÑAL { get; set; }
        public virtual DbSet<DispositivoPorRolPersona> DISPXROLPERSONA { get; set; }
        public virtual DbSet<Division> DIVISION { get; set; }
        public virtual DbSet<OpcionFormularioPorArticulo> OPCFORMULARIOXARTICULO { get; set; }
        public virtual DbSet<RutasPorDistritos> RUTASXDISTRITO { get; set; }
        public virtual DbSet<TipoDeIdentificacionPorTipoVehiculo> TIPOIDEVEHICULOXTIPOVEH { get; set; }
        public virtual DbSet<TiposPorDocumento> TIPOSXDOCUMENTO { get; set; }
        public virtual DbSet<ValidarCarroceria> VALIDARCARROCERIA { get; set; }
    }
}
