using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;
using Working_Of_Innominds_People_Crud_Operation.ServiceLayer.Interfaces;

namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer
{
    [Authorize(Roles = "Cafetaria,Employee")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CafetariaRepository:ICafetaria
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private IConfiguration _configuration;
        public CafetariaRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = new SqlConnection(configuration.GetConnectionString("defaultconnection"));

        }
        
        [HttpGet]
        public Cafetaria GetTheLastAddedData()
        {
            List<Cafetaria> cafdetails = GetAllCafetariaDetails().ToList();

            return cafdetails[cafdetails.Count-1];
        }

        [HttpDelete]
        public bool DeleteTheItemsByDate(DateTime dateTime)
        {
            try
            {

                using (_command = new SqlCommand("proc_DeletCafetariaData", _connection))
                    if (_connection.State == System.Data.ConnectionState.Closed)
                    {

                        _connection.Open();
                        _command.CommandType = System.Data.CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Date", dateTime);
                        _command.ExecuteNonQuery();
                        return true;
                    }
                return false;
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        [HttpGet]
        public IEnumerable<Cafetaria> GetAllCafetariaDetails()
        {
            List<Cafetaria> _innominds = new List<Cafetaria>();

            try
            {

                using (_command = new SqlCommand("proc_GetCafetariaData", _connection))
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();
                _command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read())
                {
                    Cafetaria e = new Cafetaria() { Sno = reader.GetInt32(0), Tea = reader.GetInt32(1), Cofee = reader.GetInt32(2),GreenTea=reader.GetInt32(3),Date=reader.GetDateTime(4) };
                    _innominds.Add(e);

                }
            }
            catch (Exception)
            {
                throw new Exception();

            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();

            }
            return _innominds;
        }
        [HttpGet]
        public List<CafeteriaOperation> GetItemsByDate(DateTime dateTime)
        {
           
                List<Cafetaria> ie1 = GetAllCafetariaDetails().ToList();

                List<CafeteriaOperation> _innominds = new List<CafeteriaOperation>();

                if (ie1.Any(t => t.Date == dateTime))
                {
                    //using (_command = new SqlCommand("select * from CafetariaTable where Date='" + dateTime + "'", _connection))
                      using (_command = new SqlCommand(" SELECT sno,Tea,Cofee,GreenTea, Date,(Tea+Cofee+GreenTea)/3 As CafetariaAvg  From CafetariaTable where  Date='" + dateTime + "' GROUP BY  sno,Tea,Cofee,GreenTea,Date", _connection))
                        if (_connection.State == System.Data.ConnectionState.Closed)
                            _connection.Open();
                    SqlDataReader reader = _command.ExecuteReader();
                    while (reader.Read())
                    {
                    CafeteriaOperation e = new CafeteriaOperation() { Sno = reader.GetInt32(0), Tea = reader.GetInt32(1), Cofee = reader.GetInt32(2), GreenTea = reader.GetInt32(3), Date = reader.GetDateTime(4), Avarage = reader.GetInt32(5)  };
                        _innominds.Add(e);
                    }
                }
                return _innominds;
        }
        [HttpPost]
        public bool InsertData(Cafetaria cafetaria)
        {
            try
            {
                using (_command = new SqlCommand("proc_CreateCafetariaTable", _connection))
                    if (_connection.State == System.Data.ConnectionState.Closed)
                    {
                        _connection.Open();
                        _command.CommandType = System.Data.CommandType.StoredProcedure;
                        _command.Parameters.AddWithValue("@Tea", cafetaria.Tea);
                        _command.Parameters.AddWithValue("@Cofee", cafetaria.Cofee);
                        _command.Parameters.AddWithValue("@GreenTea", cafetaria.GreenTea);
                        _command.Parameters.AddWithValue("@DateTime", cafetaria.Date);
                        _command.ExecuteNonQuery();
                        return true;
                    }
                return false;
            }
            catch (Exception)
            {
                throw new Exception();

            }
            finally
            {
                if (_connection.State == System.Data.ConnectionState.Open)
                    _connection.Close();
            }
        }

        [HttpPut]
        public bool UpdateTheItems(Cafetaria cafetaria)
        {
            using (_command = new SqlCommand("proc_UpdateTheCafetariaData", _connection))
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                    _command.CommandType = System.Data.CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Sno", cafetaria.Sno);
                    _command.Parameters.AddWithValue("@Tea", cafetaria.Tea);
                    _command.Parameters.AddWithValue("@Cofee", cafetaria.Cofee);
                    _command.Parameters.AddWithValue("@GreenTea", cafetaria.GreenTea);
                    _command.Parameters.AddWithValue("@Date", cafetaria.Date);
                    _command.ExecuteNonQuery();
                    return true;
                }
            return false;
        }
    }
}
