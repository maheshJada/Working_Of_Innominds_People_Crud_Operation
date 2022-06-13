
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Working_Of_Innominds_People_Crud_Operation.Models;

namespace Working_Of_Innominds_People_Crud_Operation.ServiceLayer
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeamService : ITeam
    {
        private SqlConnection _connection;
        private SqlCommand _command;
        private readonly ApplicationContext _applicationContext;
        private IConfiguration _configuration;
        public TeamService(IConfiguration configuration, ApplicationContext applicationContext)
        {
            _configuration = configuration;
            _connection = new SqlConnection(configuration.GetConnectionString("defaultconnection"));
            _applicationContext = applicationContext;

        }
        [HttpPost]
        public string TeamMessage(Team Data)
        {
            var data = _applicationContext.EmployeeTable.Find(Data.EmpId);
            if (data != null)
            {

                using (_command = new SqlCommand("insert into Team values(" + Data.EmpId + ",'" + Data.SenderName + "','" + Data.Message + "')", _connection))
                {
                    if (_connection.State == System.Data.ConnectionState.Closed)
                        _connection.Open();

                    _command.ExecuteNonQuery();
                }
                return Data.Message;
            }
            return null;
        }

    }
}
