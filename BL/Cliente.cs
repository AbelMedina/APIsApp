using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Cliente
    {
        public static ML.Result GerenteByEstatus()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.GerenteByEstatus().ToList();
                    result.Objects = new List<object>();
                    if (query.Count != 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.Cliente cliente = new ML.Cliente();
                            cliente.ID = obj.ID;
                            cliente.Nombre = obj.Nombre;
                            cliente.Abierto = obj.Abierto.Value;
                            result.Objects.Add(cliente);
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

        public static ML.Result clientesPorGerente(int idCliente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.clientesPorGerente(idCliente).ToList();
                    result.Objects = new List<object>();
                    if (query.Count !=0)
                    {
                        foreach (var obj in query)
                        {
                            ML.ClienteGerente cliente = new ML.ClienteGerente();
                            cliente.ID = obj.ID;
                            cliente.Cliente = obj.Cliente;
                            cliente.Abierto = obj.Abierto.Value;
                            result.Objects.Add(cliente);
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

        public static ML.Result proyectosPorClienteGerente(int idGerente,int idCliente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.administracionEntities context = new DL.administracionEntities())
                {
                    var query = context.proyectosPorClienteGerente(idGerente, idCliente).ToList();
                    result.Objects = new List<object>();
                    if (query.Count != 0)
                    {
                        foreach (var obj in query)
                        {
                            ML.ClienteGerenteProyecto cliente = new ML.ClienteGerenteProyecto();
                            cliente.ID = obj.ID;
                            cliente.Nombre = obj.Nombre;
                            result.Objects.Add(cliente);
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
    }
}
