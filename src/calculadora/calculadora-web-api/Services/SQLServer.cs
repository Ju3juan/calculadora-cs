using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using static calculadora_web_api.Services.SQLServer.SQLServer;

namespace calculadora_web_api.Services.SQLServer
{
    public enum HistorialType
    {
        Void,
        ADD,
        SUB,
        DIV,
        MUL,
        MOD,
        POW2,
        Raiz,
        Fact // Factorial
    }


    // GET: api/Access/5
    // GET: api/Access/Get/add
    // GET: api/Access/Get/sub
    // GET: api/Access/Get/mul
    // GET: api/Access/Get/div
    // GET: api/Access/Get/mod
    // GET: api/Access/Get/pow2
    // GET: api/Access/Get/raiz
    // GET: api/Access/Get/sqrt
    public class SQLServer
    {
        private SqlCommand SqlConsulta;
        private SqlConnection SqlConexion;
        private SqlDataReader SqlListar;

        private readonly string SqlConnectionString = @"Data Source = .; Initial Catalog = Calc; Integrated Security = True; Encrypt = False;TrustServerCertificate = True";



        /// <summary>
        /// GET: api/Access/5
        /// GET: api/Access/Get/add
        /// GET: api/Access/Get/sub
        /// GET: api/Access/Get/mul
        /// GET: api/Access/Get/div
        /// GET: api/Access/Get/mod
        /// GET: api/Access/Get/pow2
        /// GET: api/Access/Get/raiz
        /// GET: api/Access/Get/sqrt
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>

        public static HistorialType HistorialTypeConverter(string type)
        {
            switch (type)
            {
                case "add": return HistorialType.ADD;
                case "sub": return HistorialType.SUB;
                case "mul": return HistorialType.MUL;
                case "div": return HistorialType.DIV;
                case "mod": return HistorialType.MOD;
                case "pow2": return HistorialType.POW2;
                case "raiz": case "sqrt": return HistorialType.Raiz;
                default: return HistorialType.Void;
            }
        }

        public SQLServer() 
        {
            this.SqlConexion = new SqlConnection(this.SqlConnectionString);
            this.SqlConexion.Open();
        }

        public void Init()
        {
            this.SqlConexion = new SqlConnection(this.SqlConnectionString);
            this.SqlConexion.Open();
        }

        public void Quit()
        {
            this.SqlConexion.Close();
        }

        public void Connect()
        {
            this.SqlConexion = new SqlConnection(this.SqlConnectionString);
        }

        public void Open()
        {
            this.SqlConexion.Open();
        }


        public void Close()
        {
            this.SqlConexion.Close();
        }

        public void Select(string command)
        {
            this.SqlConsulta = new SqlCommand(command, this.SqlConexion);
        }

        public void Execute()
        {
            this.SqlListar = this.SqlConsulta.ExecuteReader();
        }

        public Boolean Read()
        {
            return this.SqlListar.Read();
        }

        public SqlDataReader List()
        {
            return this.SqlListar;
        }



        public void SelectCalcHistorial()
        {
            try
            {
                this.Select("SELECT [id], [Num1], [Op], [Num2], [Result] FROM [Calc].[dbo].[Historial]");
                this.SqlListar = this.SqlConsulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"[Err]: conexión sql. {ex}");
                return;
            }
        }

        public void SelectCalcHistorialSearch(HistorialType type)
        {
            try
            {

                char historial_type;
                switch (type)
                {
                    case HistorialType.ADD:
                        historial_type = '+';
                        break;
                    case HistorialType.SUB:
                        historial_type = '-';
                        break;
                    case HistorialType.DIV:
                        historial_type = '/';
                        break;
                    case HistorialType.MUL:
                        historial_type = '*';
                        break;
                    case HistorialType.MOD:
                        historial_type = '%';
                        break;
                    case HistorialType.Fact:
                        historial_type = '!';
                        break;
                    case HistorialType.POW2:
                        historial_type = '²';
                        break;
                    case HistorialType.Raiz:
                        historial_type = '√';
                        break;
                    default:
                        throw new Exception("Error in Historial search type");
                }
                this.Select($"SELECT [id], [Num1], [Op], [Num2], [Result] FROM [Calc].[dbo].[Historial] WHERE [Op] = '{historial_type}'");
                this.SqlListar = this.SqlConsulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"[Err]: conexión sql. {ex}");
                return;
            }
        }
    }
}