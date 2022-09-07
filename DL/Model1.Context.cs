﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class administracionEntities : DbContext
    {
        public administracionEntities()
            : base("name=administracionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<actividad> actividads { get; set; }
        public virtual DbSet<archivo_documento_digital> archivo_documento_digital { get; set; }
        public virtual DbSet<archivo_factura> archivo_factura { get; set; }
        public virtual DbSet<asignacion_de_gastos> asignacion_de_gastos { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<cobranza> cobranzas { get; set; }
        public virtual DbSet<cobranza_traspaso> cobranza_traspaso { get; set; }
        public virtual DbSet<conceptos_factura> conceptos_factura { get; set; }
        public virtual DbSet<conceptos_sat> conceptos_sat { get; set; }
        public virtual DbSet<contacto> contactoes { get; set; }
        public virtual DbSet<contrasena> contrasenas { get; set; }
        public virtual DbSet<contrasenia> contrasenias { get; set; }
        public virtual DbSet<correo_factura> correo_factura { get; set; }
        public virtual DbSet<correo_time> correo_time { get; set; }
        public virtual DbSet<cuota> cuotas { get; set; }
        public virtual DbSet<datos_factura> datos_factura { get; set; }
        public virtual DbSet<departamento> departamentoes { get; set; }
        public virtual DbSet<departamento_gerente> departamento_gerente { get; set; }
        public virtual DbSet<empleado> empleadoes { get; set; }
        public virtual DbSet<empleado_actividad> empleado_actividad { get; set; }
        public virtual DbSet<empleado_contrasenia> empleado_contrasenia { get; set; }
        public virtual DbSet<envio_correo> envio_correo { get; set; }
        public virtual DbSet<estatu> estatus { get; set; }
        public virtual DbSet<factura> facturas { get; set; }
        public virtual DbSet<factura_detalles> factura_detalles { get; set; }
        public virtual DbSet<forma_de_pago> forma_de_pago { get; set; }
        public virtual DbSet<gasto> gastos { get; set; }
        public virtual DbSet<gerente> gerentes { get; set; }
        public virtual DbSet<grupo_clientes> grupo_clientes { get; set; }
        public virtual DbSet<historial_empleado> historial_empleado { get; set; }
        public virtual DbSet<hora_asignable> hora_asignable { get; set; }
        public virtual DbSet<hora_no_asignable> hora_no_asignable { get; set; }
        public virtual DbSet<iva> ivas { get; set; }
        public virtual DbSet<metodo_de_pago> metodo_de_pago { get; set; }
        public virtual DbSet<moneda> monedas { get; set; }
        public virtual DbSet<nivel> nivels { get; set; }
        public virtual DbSet<nota_de_credito> nota_de_credito { get; set; }
        public virtual DbSet<partida> partidas { get; set; }
        public virtual DbSet<partida_nota> partida_nota { get; set; }
        public virtual DbSet<partida_solicitud> partida_solicitud { get; set; }
        public virtual DbSet<periodo_ano> periodo_ano { get; set; }
        public virtual DbSet<periodo_mes> periodo_mes { get; set; }
        public virtual DbSet<presupuesto> presupuestoes { get; set; }
        public virtual DbSet<presupuesto_gasto> presupuesto_gasto { get; set; }
        public virtual DbSet<presupuesto_nivel> presupuesto_nivel { get; set; }
        public virtual DbSet<proyecto> proyectoes { get; set; }
        public virtual DbSet<proyecto_factura> proyecto_factura { get; set; }
        public virtual DbSet<rechazada> rechazadas { get; set; }
        public virtual DbSet<servidor_correo> servidor_correo { get; set; }
        public virtual DbSet<socio> socios { get; set; }
        public virtual DbSet<solicitud_factura> solicitud_factura { get; set; }
        public virtual DbSet<tiempo> tiempoes { get; set; }
        public virtual DbSet<tipo_cambio> tipo_cambio { get; set; }
        public virtual DbSet<tipo_servicio> tipo_servicio { get; set; }
        public virtual DbSet<tiposervicio_conceptosat> tiposervicio_conceptosat { get; set; }
        public virtual DbSet<uso_de_cfdi> uso_de_cfdi { get; set; }
        public virtual DbSet<zona> zonas { get; set; }
    
        public virtual int AutoCompleteClientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AutoCompleteClientes");
        }
    
        public virtual ObjectResult<AutoCompleteProyectos_Result> AutoCompleteProyectos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AutoCompleteProyectos_Result>("AutoCompleteProyectos");
        }
    
        public virtual ObjectResult<buscar_factura_Result> buscar_factura(string buscar_facturapar, Nullable<int> id_fact)
        {
            var buscar_facturaparParameter = buscar_facturapar != null ?
                new ObjectParameter("buscar_facturapar", buscar_facturapar) :
                new ObjectParameter("buscar_facturapar", typeof(string));
    
            var id_factParameter = id_fact.HasValue ?
                new ObjectParameter("id_fact", id_fact) :
                new ObjectParameter("id_fact", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<buscar_factura_Result>("buscar_factura", buscar_facturaparParameter, id_factParameter);
        }
    
        public virtual int CboClientes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CboClientes");
        }
    
        public virtual ObjectResult<CboClientes_Parametro_Result> CboClientes_Parametro(string cboCliente_parametro)
        {
            var cboCliente_parametroParameter = cboCliente_parametro != null ?
                new ObjectParameter("CboCliente_parametro", cboCliente_parametro) :
                new ObjectParameter("CboCliente_parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CboClientes_Parametro_Result>("CboClientes_Parametro", cboCliente_parametroParameter);
        }
    
        public virtual ObjectResult<CboCtesTime_Par_Result> CboCtesTime_Par(string cboCteTime)
        {
            var cboCteTimeParameter = cboCteTime != null ?
                new ObjectParameter("CboCteTime", cboCteTime) :
                new ObjectParameter("CboCteTime", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CboCtesTime_Par_Result>("CboCtesTime_Par", cboCteTimeParameter);
        }
    
        public virtual ObjectResult<CboEmp_Parametro_Result> CboEmp_Parametro(string cboEmp)
        {
            var cboEmpParameter = cboEmp != null ?
                new ObjectParameter("CboEmp", cboEmp) :
                new ObjectParameter("CboEmp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CboEmp_Parametro_Result>("CboEmp_Parametro", cboEmpParameter);
        }
    
        public virtual ObjectResult<CboGtesTime_Result> CboGtesTime()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CboGtesTime_Result>("CboGtesTime");
        }
    
        public virtual ObjectResult<CboPtosTime_Par_Result> CboPtosTime_Par(string id_gte, string id_cte)
        {
            var id_gteParameter = id_gte != null ?
                new ObjectParameter("id_gte", id_gte) :
                new ObjectParameter("id_gte", typeof(string));
    
            var id_cteParameter = id_cte != null ?
                new ObjectParameter("id_cte", id_cte) :
                new ObjectParameter("id_cte", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CboPtosTime_Par_Result>("CboPtosTime_Par", id_gteParameter, id_cteParameter);
        }
    
        public virtual int Clientes_buscar(string cliente_buscar)
        {
            var cliente_buscarParameter = cliente_buscar != null ?
                new ObjectParameter("Cliente_buscar", cliente_buscar) :
                new ObjectParameter("Cliente_buscar", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Clientes_buscar", cliente_buscarParameter);
        }
    
        public virtual int Clientes_load()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Clientes_load");
        }
    
        public virtual ObjectResult<emp_rep_tiempo_Result> emp_rep_tiempo(Nullable<int> quincena_tmp, string mes_tmp, Nullable<int> anio_tmp)
        {
            var quincena_tmpParameter = quincena_tmp.HasValue ?
                new ObjectParameter("quincena_tmp", quincena_tmp) :
                new ObjectParameter("quincena_tmp", typeof(int));
    
            var mes_tmpParameter = mes_tmp != null ?
                new ObjectParameter("mes_tmp", mes_tmp) :
                new ObjectParameter("mes_tmp", typeof(string));
    
            var anio_tmpParameter = anio_tmp.HasValue ?
                new ObjectParameter("anio_tmp", anio_tmp) :
                new ObjectParameter("anio_tmp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<emp_rep_tiempo_Result>("emp_rep_tiempo", quincena_tmpParameter, mes_tmpParameter, anio_tmpParameter);
        }
    
        public virtual ObjectResult<emp_rep_tiempo_buscar_Result> emp_rep_tiempo_buscar(Nullable<int> quincena_tmp, string mes_tmp, Nullable<int> anio_tmp, string empleado_buscar)
        {
            var quincena_tmpParameter = quincena_tmp.HasValue ?
                new ObjectParameter("quincena_tmp", quincena_tmp) :
                new ObjectParameter("quincena_tmp", typeof(int));
    
            var mes_tmpParameter = mes_tmp != null ?
                new ObjectParameter("mes_tmp", mes_tmp) :
                new ObjectParameter("mes_tmp", typeof(string));
    
            var anio_tmpParameter = anio_tmp.HasValue ?
                new ObjectParameter("anio_tmp", anio_tmp) :
                new ObjectParameter("anio_tmp", typeof(int));
    
            var empleado_buscarParameter = empleado_buscar != null ?
                new ObjectParameter("Empleado_buscar", empleado_buscar) :
                new ObjectParameter("Empleado_buscar", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<emp_rep_tiempo_buscar_Result>("emp_rep_tiempo_buscar", quincena_tmpParameter, mes_tmpParameter, anio_tmpParameter, empleado_buscarParameter);
        }
    
        public virtual ObjectResult<Empleados_buscar_Result> Empleados_buscar(string empleado_buscar)
        {
            var empleado_buscarParameter = empleado_buscar != null ?
                new ObjectParameter("Empleado_buscar", empleado_buscar) :
                new ObjectParameter("Empleado_buscar", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Empleados_buscar_Result>("Empleados_buscar", empleado_buscarParameter);
        }
    
        public virtual ObjectResult<Empleados_load_Result> Empleados_load()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Empleados_load_Result>("Empleados_load");
        }
    
        public virtual ObjectResult<factura_proc_Result> factura_proc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<factura_proc_Result>("factura_proc");
        }
    
        public virtual ObjectResult<Facturas_refrescar_Result> Facturas_refrescar(string num_factura, string num_serie)
        {
            var num_facturaParameter = num_factura != null ?
                new ObjectParameter("num_factura", num_factura) :
                new ObjectParameter("num_factura", typeof(string));
    
            var num_serieParameter = num_serie != null ?
                new ObjectParameter("num_serie", num_serie) :
                new ObjectParameter("num_serie", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Facturas_refrescar_Result>("Facturas_refrescar", num_facturaParameter, num_serieParameter);
        }
    
        public virtual int InsertaReporte()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertaReporte");
        }
    
        public virtual ObjectResult<NoAsignables_Result> NoAsignables(string repid_tiempo)
        {
            var repid_tiempoParameter = repid_tiempo != null ?
                new ObjectParameter("repid_tiempo", repid_tiempo) :
                new ObjectParameter("repid_tiempo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NoAsignables_Result>("NoAsignables", repid_tiempoParameter);
        }
    
        public virtual ObjectResult<presupuesto_buscar_Result> presupuesto_buscar(string presupuesto_buscar_par)
        {
            var presupuesto_buscar_parParameter = presupuesto_buscar_par != null ?
                new ObjectParameter("presupuesto_buscar_par", presupuesto_buscar_par) :
                new ObjectParameter("presupuesto_buscar_par", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<presupuesto_buscar_Result>("presupuesto_buscar", presupuesto_buscar_parParameter);
        }
    
        public virtual ObjectResult<Presupuesto_load_Result> Presupuesto_load()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Presupuesto_load_Result>("Presupuesto_load");
        }
    
        public virtual ObjectResult<proyectos_buscar_Result> proyectos_buscar(string proyecto_buscar)
        {
            var proyecto_buscarParameter = proyecto_buscar != null ?
                new ObjectParameter("Proyecto_buscar", proyecto_buscar) :
                new ObjectParameter("Proyecto_buscar", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proyectos_buscar_Result>("proyectos_buscar", proyecto_buscarParameter);
        }
    
        public virtual ObjectResult<Proyectos_estatus_Result> Proyectos_estatus(string estatus_proyecto)
        {
            var estatus_proyectoParameter = estatus_proyecto != null ?
                new ObjectParameter("Estatus_proyecto", estatus_proyecto) :
                new ObjectParameter("Estatus_proyecto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proyectos_estatus_Result>("Proyectos_estatus", estatus_proyectoParameter);
        }
    
        public virtual ObjectResult<Proyectos_load_Result> Proyectos_load()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proyectos_load_Result>("Proyectos_load");
        }
    
        public virtual ObjectResult<Reportes_Result> Reportes(Nullable<int> empleado)
        {
            var empleadoParameter = empleado.HasValue ?
                new ObjectParameter("Empleado", empleado) :
                new ObjectParameter("Empleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Reportes_Result>("Reportes", empleadoParameter);
        }
    
        public virtual ObjectResult<ReportesByIdEmpleado_Result> ReportesByIdEmpleado(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("idEmpleado", idEmpleado) :
                new ObjectParameter("idEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReportesByIdEmpleado_Result>("ReportesByIdEmpleado", idEmpleadoParameter);
        }
    
        public virtual ObjectResult<ReporteTime_Result> ReporteTime(string repid_tiempo)
        {
            var repid_tiempoParameter = repid_tiempo != null ?
                new ObjectParameter("repid_tiempo", repid_tiempo) :
                new ObjectParameter("repid_tiempo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReporteTime_Result>("ReporteTime", repid_tiempoParameter);
        }
    
        public virtual ObjectResult<ReporteByIdTiempo_Result> ReporteByIdTiempo(Nullable<int> id_Tiempo)
        {
            var id_TiempoParameter = id_Tiempo.HasValue ?
                new ObjectParameter("Id_Tiempo", id_Tiempo) :
                new ObjectParameter("Id_Tiempo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ReporteByIdTiempo_Result>("ReporteByIdTiempo", id_TiempoParameter);
        }
    
        public virtual ObjectResult<GerenteByEstatus_Result> GerenteByEstatus()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GerenteByEstatus_Result>("GerenteByEstatus");
        }
    
        public virtual ObjectResult<clientesPorGerente_Result> clientesPorGerente(Nullable<int> idCliente)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("idCliente", idCliente) :
                new ObjectParameter("idCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<clientesPorGerente_Result>("clientesPorGerente", idClienteParameter);
        }
    
        public virtual ObjectResult<proyectosPorClienteGerente_Result> proyectosPorClienteGerente(Nullable<int> idGerente, Nullable<int> idCliente)
        {
            var idGerenteParameter = idGerente.HasValue ?
                new ObjectParameter("IdGerente", idGerente) :
                new ObjectParameter("IdGerente", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proyectosPorClienteGerente_Result>("proyectosPorClienteGerente", idGerenteParameter, idClienteParameter);
        }
    
        public virtual ObjectResult<horasNoAsignables_Result> horasNoAsignables(Nullable<int> idTiempo)
        {
            var idTiempoParameter = idTiempo.HasValue ?
                new ObjectParameter("IdTiempo", idTiempo) :
                new ObjectParameter("IdTiempo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<horasNoAsignables_Result>("horasNoAsignables", idTiempoParameter);
        }
    
        public virtual ObjectResult<actividadesPorEmpleado_Result> actividadesPorEmpleado(Nullable<int> idEmpleado)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("idEmpleado", idEmpleado) :
                new ObjectParameter("idEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<actividadesPorEmpleado_Result>("actividadesPorEmpleado", idEmpleadoParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Anios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Anios");
        }
    
        public virtual ObjectResult<Meses_Result> Meses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Meses_Result>("Meses");
        }
    
        public virtual ObjectResult<Loginuser_Result5> Loginuser(Nullable<int> num_empleado, string pwd)
        {
            var num_empleadoParameter = num_empleado.HasValue ?
                new ObjectParameter("num_empleado", num_empleado) :
                new ObjectParameter("num_empleado", typeof(int));
    
            var pwdParameter = pwd != null ?
                new ObjectParameter("pwd", pwd) :
                new ObjectParameter("pwd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Loginuser_Result5>("Loginuser", num_empleadoParameter, pwdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> existePeriodo(string quincena, string mes, Nullable<int> anio, Nullable<int> empleado)
        {
            var quincenaParameter = quincena != null ?
                new ObjectParameter("quincena", quincena) :
                new ObjectParameter("quincena", typeof(string));
    
            var mesParameter = mes != null ?
                new ObjectParameter("mes", mes) :
                new ObjectParameter("mes", typeof(string));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("anio", anio) :
                new ObjectParameter("anio", typeof(int));
    
            var empleadoParameter = empleado.HasValue ?
                new ObjectParameter("empleado", empleado) :
                new ObjectParameter("empleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("existePeriodo", quincenaParameter, mesParameter, anioParameter, empleadoParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> Registranuevoreporte(Nullable<int> quincena, string mes, Nullable<int> anio, Nullable<int> totalhorasasignables, Nullable<int> totalhorasnoasignables, Nullable<int> total, Nullable<int> idempleado, Nullable<bool> estatus, Nullable<bool> envio, string fechareporte)
        {
            var quincenaParameter = quincena.HasValue ?
                new ObjectParameter("quincena", quincena) :
                new ObjectParameter("quincena", typeof(int));
    
            var mesParameter = mes != null ?
                new ObjectParameter("mes", mes) :
                new ObjectParameter("mes", typeof(string));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("anio", anio) :
                new ObjectParameter("anio", typeof(int));
    
            var totalhorasasignablesParameter = totalhorasasignables.HasValue ?
                new ObjectParameter("totalhorasasignables", totalhorasasignables) :
                new ObjectParameter("totalhorasasignables", typeof(int));
    
            var totalhorasnoasignablesParameter = totalhorasnoasignables.HasValue ?
                new ObjectParameter("totalhorasnoasignables", totalhorasnoasignables) :
                new ObjectParameter("totalhorasnoasignables", typeof(int));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(int));
    
            var idempleadoParameter = idempleado.HasValue ?
                new ObjectParameter("idempleado", idempleado) :
                new ObjectParameter("idempleado", typeof(int));
    
            var estatusParameter = estatus.HasValue ?
                new ObjectParameter("estatus", estatus) :
                new ObjectParameter("estatus", typeof(bool));
    
            var envioParameter = envio.HasValue ?
                new ObjectParameter("envio", envio) :
                new ObjectParameter("envio", typeof(bool));
    
            var fechareporteParameter = fechareporte != null ?
                new ObjectParameter("fechareporte", fechareporte) :
                new ObjectParameter("fechareporte", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("Registranuevoreporte", quincenaParameter, mesParameter, anioParameter, totalhorasasignablesParameter, totalhorasnoasignablesParameter, totalParameter, idempleadoParameter, estatusParameter, envioParameter, fechareporteParameter);
        }
    
        public virtual int Registrarhorasasignables(Nullable<int> idproyecto, Nullable<int> idtiempo, Nullable<int> uno, Nullable<int> dos, Nullable<int> tres, Nullable<int> cuatro, Nullable<int> cinco, Nullable<int> seis, Nullable<int> siete, Nullable<int> ocho, Nullable<int> nueve, Nullable<int> diez, Nullable<int> once, Nullable<int> doce, Nullable<int> trece, Nullable<int> catorce, Nullable<int> quince, Nullable<int> diezyseis, Nullable<int> total, Nullable<decimal> cuota, Nullable<decimal> costo, Nullable<decimal> totalcuota, Nullable<decimal> totalcosto)
        {
            var idproyectoParameter = idproyecto.HasValue ?
                new ObjectParameter("idproyecto", idproyecto) :
                new ObjectParameter("idproyecto", typeof(int));
    
            var idtiempoParameter = idtiempo.HasValue ?
                new ObjectParameter("idtiempo", idtiempo) :
                new ObjectParameter("idtiempo", typeof(int));
    
            var unoParameter = uno.HasValue ?
                new ObjectParameter("uno", uno) :
                new ObjectParameter("uno", typeof(int));
    
            var dosParameter = dos.HasValue ?
                new ObjectParameter("dos", dos) :
                new ObjectParameter("dos", typeof(int));
    
            var tresParameter = tres.HasValue ?
                new ObjectParameter("tres", tres) :
                new ObjectParameter("tres", typeof(int));
    
            var cuatroParameter = cuatro.HasValue ?
                new ObjectParameter("cuatro", cuatro) :
                new ObjectParameter("cuatro", typeof(int));
    
            var cincoParameter = cinco.HasValue ?
                new ObjectParameter("cinco", cinco) :
                new ObjectParameter("cinco", typeof(int));
    
            var seisParameter = seis.HasValue ?
                new ObjectParameter("seis", seis) :
                new ObjectParameter("seis", typeof(int));
    
            var sieteParameter = siete.HasValue ?
                new ObjectParameter("siete", siete) :
                new ObjectParameter("siete", typeof(int));
    
            var ochoParameter = ocho.HasValue ?
                new ObjectParameter("ocho", ocho) :
                new ObjectParameter("ocho", typeof(int));
    
            var nueveParameter = nueve.HasValue ?
                new ObjectParameter("nueve", nueve) :
                new ObjectParameter("nueve", typeof(int));
    
            var diezParameter = diez.HasValue ?
                new ObjectParameter("diez", diez) :
                new ObjectParameter("diez", typeof(int));
    
            var onceParameter = once.HasValue ?
                new ObjectParameter("once", once) :
                new ObjectParameter("once", typeof(int));
    
            var doceParameter = doce.HasValue ?
                new ObjectParameter("doce", doce) :
                new ObjectParameter("doce", typeof(int));
    
            var treceParameter = trece.HasValue ?
                new ObjectParameter("trece", trece) :
                new ObjectParameter("trece", typeof(int));
    
            var catorceParameter = catorce.HasValue ?
                new ObjectParameter("catorce", catorce) :
                new ObjectParameter("catorce", typeof(int));
    
            var quinceParameter = quince.HasValue ?
                new ObjectParameter("quince", quince) :
                new ObjectParameter("quince", typeof(int));
    
            var diezyseisParameter = diezyseis.HasValue ?
                new ObjectParameter("diezyseis", diezyseis) :
                new ObjectParameter("diezyseis", typeof(int));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(int));
    
            var cuotaParameter = cuota.HasValue ?
                new ObjectParameter("cuota", cuota) :
                new ObjectParameter("cuota", typeof(decimal));
    
            var costoParameter = costo.HasValue ?
                new ObjectParameter("costo", costo) :
                new ObjectParameter("costo", typeof(decimal));
    
            var totalcuotaParameter = totalcuota.HasValue ?
                new ObjectParameter("totalcuota", totalcuota) :
                new ObjectParameter("totalcuota", typeof(decimal));
    
            var totalcostoParameter = totalcosto.HasValue ?
                new ObjectParameter("totalcosto", totalcosto) :
                new ObjectParameter("totalcosto", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrarhorasasignables", idproyectoParameter, idtiempoParameter, unoParameter, dosParameter, tresParameter, cuatroParameter, cincoParameter, seisParameter, sieteParameter, ochoParameter, nueveParameter, diezParameter, onceParameter, doceParameter, treceParameter, catorceParameter, quinceParameter, diezyseisParameter, totalParameter, cuotaParameter, costoParameter, totalcuotaParameter, totalcostoParameter);
        }
    
        public virtual int Registrarhorasnoasignables(Nullable<int> id_actividad, Nullable<int> idtiempo, Nullable<int> uno, Nullable<int> dos, Nullable<int> tres, Nullable<int> cuatro, Nullable<int> cinco, Nullable<int> seis, Nullable<int> siete, Nullable<int> ocho, Nullable<int> nueve, Nullable<int> diez, Nullable<int> once, Nullable<int> doce, Nullable<int> trece, Nullable<int> catorce, Nullable<int> quince, Nullable<int> diezyseis, Nullable<int> total, Nullable<decimal> cuota, Nullable<decimal> costo, Nullable<decimal> totalcuota, Nullable<decimal> totalcosto)
        {
            var id_actividadParameter = id_actividad.HasValue ?
                new ObjectParameter("id_actividad", id_actividad) :
                new ObjectParameter("id_actividad", typeof(int));
    
            var idtiempoParameter = idtiempo.HasValue ?
                new ObjectParameter("idtiempo", idtiempo) :
                new ObjectParameter("idtiempo", typeof(int));
    
            var unoParameter = uno.HasValue ?
                new ObjectParameter("uno", uno) :
                new ObjectParameter("uno", typeof(int));
    
            var dosParameter = dos.HasValue ?
                new ObjectParameter("dos", dos) :
                new ObjectParameter("dos", typeof(int));
    
            var tresParameter = tres.HasValue ?
                new ObjectParameter("tres", tres) :
                new ObjectParameter("tres", typeof(int));
    
            var cuatroParameter = cuatro.HasValue ?
                new ObjectParameter("cuatro", cuatro) :
                new ObjectParameter("cuatro", typeof(int));
    
            var cincoParameter = cinco.HasValue ?
                new ObjectParameter("cinco", cinco) :
                new ObjectParameter("cinco", typeof(int));
    
            var seisParameter = seis.HasValue ?
                new ObjectParameter("seis", seis) :
                new ObjectParameter("seis", typeof(int));
    
            var sieteParameter = siete.HasValue ?
                new ObjectParameter("siete", siete) :
                new ObjectParameter("siete", typeof(int));
    
            var ochoParameter = ocho.HasValue ?
                new ObjectParameter("ocho", ocho) :
                new ObjectParameter("ocho", typeof(int));
    
            var nueveParameter = nueve.HasValue ?
                new ObjectParameter("nueve", nueve) :
                new ObjectParameter("nueve", typeof(int));
    
            var diezParameter = diez.HasValue ?
                new ObjectParameter("diez", diez) :
                new ObjectParameter("diez", typeof(int));
    
            var onceParameter = once.HasValue ?
                new ObjectParameter("once", once) :
                new ObjectParameter("once", typeof(int));
    
            var doceParameter = doce.HasValue ?
                new ObjectParameter("doce", doce) :
                new ObjectParameter("doce", typeof(int));
    
            var treceParameter = trece.HasValue ?
                new ObjectParameter("trece", trece) :
                new ObjectParameter("trece", typeof(int));
    
            var catorceParameter = catorce.HasValue ?
                new ObjectParameter("catorce", catorce) :
                new ObjectParameter("catorce", typeof(int));
    
            var quinceParameter = quince.HasValue ?
                new ObjectParameter("quince", quince) :
                new ObjectParameter("quince", typeof(int));
    
            var diezyseisParameter = diezyseis.HasValue ?
                new ObjectParameter("diezyseis", diezyseis) :
                new ObjectParameter("diezyseis", typeof(int));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(int));
    
            var cuotaParameter = cuota.HasValue ?
                new ObjectParameter("cuota", cuota) :
                new ObjectParameter("cuota", typeof(decimal));
    
            var costoParameter = costo.HasValue ?
                new ObjectParameter("costo", costo) :
                new ObjectParameter("costo", typeof(decimal));
    
            var totalcuotaParameter = totalcuota.HasValue ?
                new ObjectParameter("totalcuota", totalcuota) :
                new ObjectParameter("totalcuota", typeof(decimal));
    
            var totalcostoParameter = totalcosto.HasValue ?
                new ObjectParameter("totalcosto", totalcosto) :
                new ObjectParameter("totalcosto", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrarhorasnoasignables", id_actividadParameter, idtiempoParameter, unoParameter, dosParameter, tresParameter, cuatroParameter, cincoParameter, seisParameter, sieteParameter, ochoParameter, nueveParameter, diezParameter, onceParameter, doceParameter, treceParameter, catorceParameter, quinceParameter, diezyseisParameter, totalParameter, cuotaParameter, costoParameter, totalcuotaParameter, totalcostoParameter);
        }
    
        public virtual int EliminarHoraAsignable(Nullable<int> id_Tiempo)
        {
            var id_TiempoParameter = id_Tiempo.HasValue ?
                new ObjectParameter("Id_Tiempo", id_Tiempo) :
                new ObjectParameter("Id_Tiempo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarHoraAsignable", id_TiempoParameter);
        }
    
        public virtual int EliminarHoraNoAsignable(Nullable<int> id_Tiempo)
        {
            var id_TiempoParameter = id_Tiempo.HasValue ?
                new ObjectParameter("Id_Tiempo", id_Tiempo) :
                new ObjectParameter("Id_Tiempo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarHoraNoAsignable", id_TiempoParameter);
        }
    
        public virtual int EliminarTiempo(Nullable<int> idTiempo)
        {
            var idTiempoParameter = idTiempo.HasValue ?
                new ObjectParameter("IdTiempo", idTiempo) :
                new ObjectParameter("IdTiempo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarTiempo", idTiempoParameter);
        }
    
        public virtual int EliminarReporteTiempo(Nullable<int> idTiempo)
        {
            var idTiempoParameter = idTiempo.HasValue ?
                new ObjectParameter("IdTiempo", idTiempo) :
                new ObjectParameter("IdTiempo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarReporteTiempo", idTiempoParameter);
        }
    }
}
