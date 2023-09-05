using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace BL
{
    public class Email
    {
        public static ML.Result emailSender(ML.Email email)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    UseDefaultCredentials = false,
                    Port = 25, //465; //587
                    Credentials = new NetworkCredential("prueba.emailservicio@gmail.com", "qiaqdnhvqlgrurez"),
                    EnableSsl = true,
                })
                {
                    var mailMessage = new MailMessage
                    {
                        //From = new MailAddress("prueba.emailservicio@gmail.com"),
                        //Subject = "subject",
                        //Body = "<h1>Hola</h1>",
                        //IsBodyHtml = true,
                        From = new MailAddress("prueba.emailservicio@gmail.com"),
                        Subject = email.Titulo,
                        Body = email.Cuerpo,
                        IsBodyHtml = true,
                    };
                    //mailMessage.To.Add("abel.medina.r011@gmail.com");
                    mailMessage.To.Add(email.Para);
                    if (!email.Copia.Equals(""))
                    {
                        mailMessage.CC.Add(email.Copia);
                    }
                    if (!email.Oculta.Equals(""))
                    {
                        mailMessage.Bcc.Add(email.Oculta);
                    }
                    smtpClient.Send(mailMessage);
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.ErrorMessage = ex.Message;
                result.Correct = false;
            }
            return result;
        }
    }
}
