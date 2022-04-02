using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UI.TextilSoft.Tools.RegexPatterns
{
    public static class ProveedorPattern
    {
        private static IConfiguration Configuration;
        private const string MailPattern = "^[\\w!#$%&'+-/=?^_`{|}~]+(.[\\w!#$%&'+-/=?^_`{|}~]+)*" + "@" + @"((([-\w]+.)+[a-zA-Z]{2,4})|(([0-9]{1,3}.){3}[0-9]{1,3}))$";

        public static bool CuitMatch(string DNI)
        {
            var CuitPattern = GetSection("PatternConfig", "CuitPattern").Split("||");
            //var result = Regex.IsMatch(DNI, $@"{CuitPattern[0].Replace(@"\\", @"\")}");
            //var result2 = Regex.IsMatch(DNI, $@"{CuitPattern[1]}");

            if (Regex.IsMatch(DNI, $@"{CuitPattern[0].Replace(@"\\", @"\")}") == false && Regex.IsMatch(DNI, $@"{CuitPattern[1]}") == false)
                throw new Exception("El DNI/Cuil ingresado no es válido");
            else
                return true;

        }

        public static string DateMatch(string fecha)
        {
            //try
            //{
                var DatePattern = GetSection("PatternConfig", "DatePattern", true);
                //string patron = DatePattern[0].Value;
                //patron = Regex.Replace(patron, @"\\", @"\");
                //var result = Regex.IsMatch(fecha, patron);
                //var result2 = Regex.IsMatch(fecha, PatronByGonza);

                if (Regex.IsMatch(fecha, DatePattern[0].Value.Replace(@"\\", @"\")))
                {
                    fecha = Regex.Replace(fecha, DatePattern[1].Value.Replace(@"\\", @"\"), "/");
                    string[] inputsplited = fecha.Split('/');
                    var resultado = String.Join("/", inputsplited);
                    var phrase = inputsplited.Aggregate((partialPhrase, word) => $"{partialPhrase}/{word}");

                    string FechaYhora = inputsplited.ReplaceDate();
                    return FechaYhora;
                }
                else
                    throw new Exception("Formato de fecha incorrecto.");
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public static bool LugarMatch(string LugarEmpresa)
        {
            var LugarPattern = GetSection("PatternConfig", "LugarEmpresaPattern");

            if (Regex.IsMatch(LugarEmpresa, $@"{LugarPattern.Replace(@"\\", @"\")}") == false)
                throw new Exception("La/El localidad/Municipio donde reside la empresa no existe");
            else
                return true;

        }

        public static bool MailMatch(string Mail)
        {
            if (Regex.IsMatch(Mail, MailPattern) == false)
                throw new Exception("El mail ingresado no es válido");
            else
                return true;
        }

        public static bool NombreMatch(string Nombre)
        {
            var NombrePattern = GetSection("PatternConfig", "NombrePattern");

            if (Regex.IsMatch(Nombre, $@"{NombrePattern[0].Replace(@"\\", @"\")}") == false)
                throw new Exception("El Nombre ingresado no es válido");
            else
                return true;
        }

        private static string ReplaceDate(this string[] inputsplited)
        {
            try
            {
                string Dia = inputsplited[0];
                string Mes = inputsplited[1];
                string Año = inputsplited[2];
                bool ddMMyyyy = true;
                string FechaYhora;
                if (inputsplited.Length < 3)
                    ddMMyyyy = false;

                if (Convert.ToInt32(Dia) > 31)
                    throw new Exception("El Dia no puede ser mayor a 31");

                if (Convert.ToInt32(Mes) > 12)
                    throw new Exception("Solo existen 12 meses en el año");

                if (ddMMyyyy == false)
                {
                    string Hora = inputsplited[3];
                    string Minuto = inputsplited[4];
                    string Segundo = inputsplited[5];
                    if (Convert.ToInt32(Hora) > 24)
                        throw new Exception("En un dia solo hay 24 horas");

                    if (Convert.ToInt32(Minuto) > 60)
                        throw new Exception("Los minutos no superan los 60");

                    if (Convert.ToInt32(Segundo) > 60)
                        throw new Exception("Los segundos no superan los 60");

                    return FechaYhora = Dia + "/" + Mes + "/" + Año + " " + Hora + ":" + Minuto + ":" + Segundo;
                }
                else
                    return FechaYhora = Dia + "/" + Mes + "/" + Año;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static dynamic GetSection(string Section, string Section2 = "", bool getchildren = false) // Levanto el json y agarro la connstring
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json");

            Configuration = builder.Build();

            if (Section != null && Section2 != null)
            {
                if (getchildren)
                    return Configuration.GetSection(Section).GetSection(Section2).GetChildren().ToList();
                else
                    return Configuration.GetSection(Section).GetSection(Section2).Value;
            }
            //var connectionString2 = Configuration.GetConnectionString("SqlConnectionServiceLayer");
            //DateTime prueba = DateTime.Now;
            //DateTime fromdateStr = Convert.ToDateTime(string.Format("{0:dd-MM-yyyy HH:mm:ss}", prueba));
            //var settings = Configuration.GetSection("AppConfig").GetSection("DatePattern").GetChildren().ToList();
            //var settings2 = Configuration.GetSection("Testing").GetSection("test1").Value;
            return "";
        }
    }
}
