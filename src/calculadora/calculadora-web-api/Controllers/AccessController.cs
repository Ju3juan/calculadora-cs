using calculadora_web_api.Models.WS.Historial;
using calculadora_web_api.Models.WS.Reply;
using calculadora_web_api.Services.SQLServer;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace calculadora_web_api.Controllers
{
    public class AccessController : ApiController
    {

        private SQLServer sql_server = new SQLServer();

        // GET: api/Access/Get/
        [HttpGet]
        public Reply<List<Historial>> Get()
        {
            Trace.WriteLine($"Default get");
            List<Historial> list_historial = new List<Historial>();

            sql_server.SelectCalcHistorial();

            while (sql_server.Read())
            {
                try
                {
                    var historial = new Historial
                    {
                        Id = Convert.ToInt64(sql_server.List()["id"]),
                        Num1 = Convert.ToDouble(sql_server.List()["Num1"]),
                        Op = Convert.ToChar(sql_server.List()["Op"]),
                        Num2 = Convert.ToDouble(sql_server.List()["Num2"]),
                        Result = Convert.ToDouble(sql_server.List()["Result"])
                    };

                    list_historial.Add(historial);
                }
                catch (Exception ex)
                {
                    //throw new Exception($"[Get json error]: {ex}");
                    //MessageBox.Show($"[Err]: Parsing error. {ex}");
                    return new Reply<List<Historial>>
                    {
                        Result = 0,
                        Message = "[Err]: Historial Error",
                        Data = list_historial
                    };
                }
            }

            sql_server.Close();

            return new Reply<List<Historial>>
            {
                Result = 1,
                Message = "[OK]: Historial Load",
                Data = list_historial
            };
        }


        // https://localhost:44372/api/Access/Get/mod
        // GET: api/Access/5
        // GET: api/Access/Get/add
        // GET: api/Access/Get/sub
        // GET: api/Access/Get/mul
        // GET: api/Access/Get/div
        // GET: api/Access/Get/mod
        // GET: api/Access/Get/pow2
        // GET: api/Access/Get/raiz
        // GET: api/Access/Get/sqrt
        [HttpGet]
        public Reply<List<Historial>> Get(string id)
        {
            string val = id;
            Trace.WriteLine($"{val}");
            Trace.WriteLine($"{val}");
            List<Historial> list_historial = new List<Historial>();

            switch (SQLServer.HistorialTypeConverter(val))
            {
                case HistorialType.ADD:
                    sql_server.SelectCalcHistorialSearch(HistorialType.ADD);
                    break;

                case HistorialType.SUB:
                    sql_server.SelectCalcHistorialSearch(HistorialType.SUB);
                    break;

                case HistorialType.MUL:
                    sql_server.SelectCalcHistorialSearch(HistorialType.MUL);
                    break;

                case HistorialType.DIV:
                    sql_server.SelectCalcHistorialSearch(HistorialType.DIV);
                    break;

                case HistorialType.MOD:
                    sql_server.SelectCalcHistorialSearch(HistorialType.MOD);
                    break;

                case HistorialType.POW2:
                    sql_server.SelectCalcHistorialSearch(HistorialType.POW2);
                    break;

                case HistorialType.Raiz:
                    sql_server.SelectCalcHistorialSearch(HistorialType.Raiz);
                    break;

                default:
                    return new Reply<List<Historial>> {
                        Result = 0,
                        Message = $"[Err]: Historial Unknown Parameter {val}",
                    };
            }

            while (sql_server.Read())
            {
                try
                {
                    var historial = new Historial
                    {
                        Id = Convert.ToInt64(sql_server.List()["id"]),
                        Num1 = Convert.ToDouble(sql_server.List()["Num1"]),
                        Op = Convert.ToChar(sql_server.List()["Op"]),
                        Num2 = Convert.ToDouble(sql_server.List()["Num2"]),
                        Result = Convert.ToDouble(sql_server.List()["Result"])
                    };

                    list_historial.Add(historial);
                }
                catch (Exception ex)
                {
                    //throw new Exception($"[Get json error]: {ex}");
                    //MessageBox.Show($"[Err]: Parsing error. {ex}");
                    return new Reply<List<Historial>>
                    {
                        Result = 0,
                        Message = "[Err]: Historial Error",
                        Data = list_historial
                    };
                }
            }

            sql_server.Close();

            return new Reply<List<Historial>>
            {
                Result = 1,
                Message = "[OK]: Historial Load",
                Data = list_historial
            };
        }

        // POST: api/Access/Post/
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Access/Put/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Access/Delete/5
        public void Delete(int id)
        {
        }
    }
}
