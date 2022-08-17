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
                    var query2 = context.horasNoAsignables(IdTiempo).ToList();
                    union.HorasNoAsignables = new List<ML.TiempoNoAsignable>();
                    if (query2.Count != 0)
                    {
                        foreach (var obj in query2)
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
    }
}

