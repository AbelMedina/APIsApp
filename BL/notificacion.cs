using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class notificacion
    {
        public static ML.Result RecordatorioDeTiempo(ML.JsonRequest jsonRequest)
        {
            ML.Result result = new ML.Result();
            try
            {
                //using (DL.administracionEntities context = new DL.administracionEntities())
                //{
                //    var query = context.ConsultaDispositivos().ToList();
                //    if (query.Count!=0)
                //    {
                //        foreach (var dispositivo in query)
                //        {
                ML.body json = new ML.body();
                json.to = jsonRequest.to;
                json.notification = new ML.notification();
                json.notification.title = jsonRequest.title;
                json.notification.body = jsonRequest.body;
                json.notification.sound = "default";
                json.notification.icon = "icon_notif";
                json.notification.color = "#24257d";
                json.notification.badge = "2";
                json.content_available = false;
                json.priority = "High";
                json.data = new ML.data();
                json.data.existeNotificacion = true;
                json.data.dataNotificacion = new ML.dataNotificacion();
                json.data.dataNotificacion.periodo = new ML.periodo();
                json.data.dataNotificacion.periodo.quincena = jsonRequest.periodo.quincena;
                json.data.dataNotificacion.periodo.mes = jsonRequest.periodo.mes;
                json.data.dataNotificacion.periodo.anio = jsonRequest.periodo.anio;
                json.data.dataNotificacion.Fecha = "Mar 23, 2023";
                json.data.dataNotificacion.Hora = "1:26PM";
                json.data.dataNotificacion.IdTiempo = 31756;
                json.data.dataNotificacion.Leido = jsonRequest.leido;
                json.data.dataNotificacion.Mensaje = jsonRequest.mensaje;
                json.data.dataNotificacion.Tipo = jsonRequest.tipo;
                json.data.dataNotificacion.Titulo = jsonRequest.titulo;
                string UrlBase = "https://fcm.googleapis.com/fcm/send";
                using (HttpClient cliente = new HttpClient())
                {
                    cliente.BaseAddress = new Uri(UrlBase);
                    string key = "key=AAAAUXOEKTU:APA91bHMIf7xjs03917UQImFirdyfaCGDs4cTphyuqlAiF1nmY8SGJ5wXbOBxlpjiq_C2LCAWeg0AhesoDhD2HjxDvguVsBf8f3zdpubCeAL7eMbSDTqD651PPXwj0IEnfEXDR8P6G2o";
                    cliente.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", key);
                    var postTask = cliente.PostAsJsonAsync<ML.body>(UrlBase, json);
                    postTask.Wait();
                    var resultPost = postTask.Result;
                    if (resultPost.IsSuccessStatusCode)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        throw new ArgumentException(postTask.Result.ReasonPhrase);
                    }
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
                result.Correct = false;
            }
            return result;
        }
    }
}
