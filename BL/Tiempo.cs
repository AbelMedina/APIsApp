using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Tiempo
    {
        public static ML.Result ReporteByIdTiempo(int idTiempo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.ReporteByIdTiempo(idTiempo).ToList();
                    result.Objects = new List<object>();
                    if (query.Count != 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Tiempo tiempo = new ML.Tiempo();
                            tiempo.IDHoraAsignable = obj.ID_Hora_Asignable.Value;
                            tiempo.IDProyecto = obj.ID_Proyecto.Value;
                            tiempo.Clave = obj.Clave;
                            tiempo.uno = obj.uno.Value;
                            tiempo.dos = obj.dos.Value;
                            tiempo.tres = obj.tres.Value;
                            tiempo.cuatro = obj.cuatro.Value;
                            tiempo.cinco = obj.cinco.Value;
                            tiempo.seis = obj.seis.Value;
                            tiempo.siete = obj.siete.Value;
                            tiempo.ocho = obj.ocho.Value;
                            tiempo.nueve = obj.nueve.Value;
                            tiempo.diez = obj.diez.Value;
                            tiempo.once = obj.once.Value;
                            tiempo.doce = obj.doce.Value;
                            tiempo.trece = obj.trece.Value;
                            tiempo.catorce = obj.catorce.Value;
                            tiempo.quince = obj.quince.Value;
                            tiempo.diezyseis = obj.diez_y_seis.Value;
                            tiempo.Total = obj.Total.Value;
                            tiempo.Cliente = obj.Cliente;
                            tiempo.Gerente = obj.Gerente;
                            tiempo.cuota = obj.cuota.Value;
                            tiempo.costo = obj.costo.Value;
                            tiempo.totalCuota = obj.total_cuota.Value;
                            tiempo.totalCosto = obj.total_costo.Value;
                            tiempo.idCliente = obj.id_cliente.Value;
                            tiempo.idGerente = obj.id_gerente.Value;
                            result.Objects.Add(tiempo);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result horasNoAsignables(int IdTiempo)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.horasNoAsignables(IdTiempo).ToList();
                    result.Objects = new List<object>();
                    if (query.Count != 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.TiempoNoAsignable tiempo = new ML.TiempoNoAsignable();
                            tiempo.IDHoraNoAsignable = obj.id_hora_no_asignable;
                            tiempo.IDActividad = obj.id_actividad;
                            tiempo.NomActividad = obj.nom_actividad;
                            tiempo.uno = obj.uno.Value;
                            tiempo.dos = obj.dos.Value;
                            tiempo.tres = obj.tres.Value;
                            tiempo.cuatro = obj.cuatro.Value;
                            tiempo.cinco = obj.cinco.Value;
                            tiempo.seis = obj.seis.Value;
                            tiempo.siete = obj.siete.Value;
                            tiempo.ocho = obj.ocho.Value;
                            tiempo.nueve = obj.nueve.Value;
                            tiempo.diez = obj.diez.Value;
                            tiempo.once = obj.once.Value;
                            tiempo.doce = obj.doce.Value;
                            tiempo.trece = obj.trece.Value;
                            tiempo.catorce = obj.catorce.Value;
                            tiempo.quince = obj.quince.Value;
                            tiempo.diezyseis = obj.diez_y_seis.Value;
                            tiempo.Total = obj.total.Value;
                            tiempo.cuota = obj.cuota.Value;
                            tiempo.costo = obj.costo.Value;
                            tiempo.totalCuota = obj.total_cuota.Value;
                            tiempo.totalCosto = obj.total_costo.Value;
                            tiempo.descripcion = obj.descripcion;
                            result.Objects.Add(tiempo);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result reportePorEmpleado(int IdTiempo)
        {
            ML.Result result = new ML.Result();
            ML.Union union = new ML.Union();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.ReporteByIdTiempo(IdTiempo).ToList();
                    result.Objects = new List<object>();
                    union.HorasAsignables = new List<ML.Tiempo>();
                    if (query.Count != 0)
                    {
                        foreach (var obj in query)
                        {
                            if (obj.ID_Hora_Asignable.HasValue)
                            {
                                ML.Tiempo tiempo = new ML.Tiempo();
                                tiempo.IDHoraAsignable = obj.ID_Hora_Asignable.Value;
                                tiempo.IDProyecto = obj.ID_Proyecto.Value;
                                tiempo.Clave = obj.Clave;
                                tiempo.uno = obj.uno.Value;
                                tiempo.dos = obj.dos.Value;
                                tiempo.tres = obj.tres.Value;
                                tiempo.cuatro = obj.cuatro.Value;
                                tiempo.cinco = obj.cinco.Value;
                                tiempo.seis = obj.seis.Value;
                                tiempo.siete = obj.siete.Value;
                                tiempo.ocho = obj.ocho.Value;
                                tiempo.nueve = obj.nueve.Value;
                                tiempo.diez = obj.diez.Value;
                                tiempo.once = obj.once.Value;
                                tiempo.doce = obj.doce.Value;
                                tiempo.trece = obj.trece.Value;
                                tiempo.catorce = obj.catorce.Value;
                                tiempo.quince = obj.quince.Value;
                                tiempo.diezyseis = obj.diez_y_seis.Value;
                                tiempo.Total = obj.Total.Value;
                                tiempo.Cliente = obj.Cliente;
                                tiempo.Gerente = obj.Gerente;
                                tiempo.cuota = obj.cuota.Value;
                                tiempo.costo = obj.costo.Value;
                                tiempo.totalCuota = obj.total_cuota.Value;
                                tiempo.totalCosto = obj.total_costo.Value;
                                tiempo.idCliente = obj.id_cliente.Value;
                                tiempo.idGerente = obj.id_gerente.Value;
                                union.HorasAsignables.Add(tiempo);
                            }
                        }
                    }
                    var query2 = context.horasNoAsignables(IdTiempo).ToList();
                    union.HorasNoAsignables = new List<ML.TiempoNoAsignable>();
                    if (query2.Count != 0)
                    {
                        foreach (var obj in query2)
                        {
                            if (obj.id_hora_no_asignable != 0)
                            {
                                ML.TiempoNoAsignable tiempo = new ML.TiempoNoAsignable();
                                tiempo.IDHoraNoAsignable = obj.id_hora_no_asignable;
                                tiempo.IDActividad = obj.id_actividad;
                                tiempo.NomActividad = obj.nom_actividad;
                                tiempo.uno = obj.uno.Value;
                                tiempo.dos = obj.dos.Value;
                                tiempo.tres = obj.tres.Value;
                                tiempo.cuatro = obj.cuatro.Value;
                                tiempo.cinco = obj.cinco.Value;
                                tiempo.seis = obj.seis.Value;
                                tiempo.siete = obj.siete.Value;
                                tiempo.ocho = obj.ocho.Value;
                                tiempo.nueve = obj.nueve.Value;
                                tiempo.diez = obj.diez.Value;
                                tiempo.once = obj.once.Value;
                                tiempo.doce = obj.doce.Value;
                                tiempo.trece = obj.trece.Value;
                                tiempo.catorce = obj.catorce.Value;
                                tiempo.quince = obj.quince.Value;
                                tiempo.diezyseis = obj.diez_y_seis.Value;
                                tiempo.Total = obj.total.Value;
                                tiempo.cuota = obj.cuota.Value;
                                tiempo.costo = obj.costo.Value;
                                tiempo.totalCuota = obj.total_cuota.Value;
                                tiempo.totalCosto = obj.total_costo.Value;
                                tiempo.descripcion = obj.descripcion;
                                union.HorasNoAsignables.Add(tiempo);
                            }
                        }
                    }
                    result.Objects.Add(union);
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result RegistrarNuevoReporte(ML.RegistrarNuevoReporte registrarNuevoReporte)
        {
            ML.Result result = new ML.Result();
            decimal idTiempo;
            bool flag = false;
            bool flag2 = true;
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.Registranuevoreporte(registrarNuevoReporte.quincena, registrarNuevoReporte.mes, registrarNuevoReporte.anio, registrarNuevoReporte.totalhorasasignables, registrarNuevoReporte.totalhorasnoasignables, registrarNuevoReporte.total, registrarNuevoReporte.idempleado, registrarNuevoReporte.estatus, registrarNuevoReporte.envio, registrarNuevoReporte.fechareporte.Replace("/", "").Replace("-", "")).FirstOrDefault();
                    if (query.HasValue)
                    {
                        idTiempo = query.Value;
                        foreach (var item in registrarNuevoReporte.detalleHorasAsignables)
                        {
                            if (item.IDProyecto != 0 /*|| item.IDProyecto != null*/)
                            {
                                var query2 = context.Registrarhorasasignables(item.IDProyecto, Convert.ToInt32(idTiempo), item.uno, item.dos, item.tres, item.cuatro, item.cinco, item.seis, item.siete, item.ocho, item.nueve, item.diez, item.once, item.doce, item.trece, item.catorce, item.quince, item.diezyseis, item.Total, item.cuota, item.costo, item.totalCuota, item.totalCosto);
                                if (query2 >= 1)
                                {
                                    flag = true;
                                    continue;
                                }
                                else
                                {
                                    flag = false;
                                    result.Correct = false;
                                    break;
                                }
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            foreach (var item in registrarNuevoReporte.detalleHorasNoAsignables)
                            {
                                if (item.IDActividad != 0 /*|| item.IDActividad != null*/)
                                {
                                    var query3 = context.Registrarhorasnoasignables(item.IDActividad, Convert.ToInt32(idTiempo), item.uno, item.dos, item.tres, item.cuatro, item.cinco, item.seis, item.siete, item.ocho, item.nueve, item.diez, item.once, item.doce, item.trece, item.catorce, item.quince, item.diezyseis, item.Total, item.cuota, item.costo, item.totalCuota, item.totalCosto);
                                    if (query3 >= 1)
                                    {
                                        flag2 = true;
                                        continue;
                                    }
                                    else
                                    {
                                        flag2 = false;
                                        result.Correct = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    flag2 = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Error al registrar";
                    }
                    if (flag && flag2)
                    {
                        result.Correct = true;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result EliminarReporte(ML.EliminarReporte eliminarReporte)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.EliminarReporteTiempo(eliminarReporte.idTiempo);
                    if (query >= 1)
                    {
                        //var query2 = context.EliminarHoraNoAsignable(eliminarReporte.idTiempo);
                        //if (query2 >= 1)
                        //{
                        //var query3 = context.EliminarTiempo(eliminarReporte.idTiempo);
                        // if (query3 >=1)
                        //{
                        result.Correct = true;
                        //}
                        //else
                        //{
                        // result.Correct = false;
                        //result.ErrorMessage = "Ha ocurrido un error en la eliminacion en cascada";
                        //}
                        //}
                        //else
                        //{
                        //    result.Correct = false;
                        //    result.ErrorMessage = "Ha ocurrido un error en la eliminacion en cascada";
                        //}
                    }
                    else
                    {
                        result.Correct = true;
                        result.ErrorMessage = "No hay registros a eliminar.";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }

        public static ML.Result ActualizarReporte(ML.ActualizarReporte actualizarReporte)
        {
            ML.Result result = new ML.Result();
            bool flag = false;
            bool flag2 = false;
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.ActualizaTiempo(actualizarReporte.horas_asignables, actualizarReporte.horas_no_asignables, actualizarReporte.total, actualizarReporte.estatus, actualizarReporte.envio, actualizarReporte.id_tiempo);
                    if (query >= 1)
                    {
                        foreach (var item in actualizarReporte.detalleHorasAsignables)
                        {
                            if (item.IDProyecto != 0)
                            {
                                var query2 = context.ActualizaHoraAsignable(item.IDHoraAsignable, actualizarReporte.id_tiempo, item.IDProyecto, item.uno, item.dos, item.tres, item.cuatro, item.cinco, item.seis, item.siete, item.ocho, item.nueve, item.diez, item.once, item.doce, item.trece, item.catorce, item.quince, item.diezyseis, item.Total, item.cuota, item.costo, item.totalCuota, item.totalCosto);
                                if (query2 >= 1)
                                {
                                    flag = true;
                                    continue;
                                }
                                else
                                {
                                    flag = false;
                                    result.Correct = false;
                                    break;
                                }
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            foreach (var item in actualizarReporte.detalleHorasNoAsignables)
                            {
                                if (item.IDActividad != 0)
                                {
                                    var query3 = context.ActualizaHoraNoAsignable(item.IDHoraNoAsignable, actualizarReporte.id_tiempo, item.IDActividad, item.uno, item.dos, item.tres, item.cuatro, item.cinco, item.seis, item.siete, item.ocho, item.nueve, item.diez, item.once, item.doce, item.trece, item.catorce, item.quince, item.diezyseis, item.Total, item.cuota, item.costo, item.totalCuota, item.totalCosto);
                                    if (query3 >= 1)
                                    {
                                        flag2 = true;
                                        continue;
                                    }
                                    else
                                    {
                                        flag2 = false;
                                        result.Correct = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    flag2 = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        result.Correct = true;
                        result.ErrorMessage = "Error al actualizar";
                    }
                    if (flag && flag2)
                    {
                        result.Correct = true;
                    }
                }
            }
            catch (Exception Ex)
            {
                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex = Ex;
            }
            return result;
        }
    }
}

