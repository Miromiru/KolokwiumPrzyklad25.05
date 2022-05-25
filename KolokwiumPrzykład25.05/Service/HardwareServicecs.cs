using Dapper;
using KolokwiumPrzykład25._05.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPrzykład25._05.Service
{
    public class HardwareServicecs
    {
        public List<Company> GetCompanies()
        {
            string connectionString = @"Server=LAPTOP-HK5PHBI7\MSSQLSERVER01;Database=kolokwiumSprzetKomp;Trusted_Connection=True;";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Query<Company>("Select * from Company").ToList();
                return result;
            }
        }

        public void Add(Hardware hardware)
        {
            string connectionString = @"Server=LAPTOP-HK5PHBI7\MSSQLSERVER01;Database=kolokwiumSprzetKomp;Trusted_Connection=True;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = @"INSERT INTO Hardware
                                           ([Name]
                                           ,[Year]
                                           ,[Price]
                                           ,[Amount]
                                           ,[Description]
                                           ,[CompanyId])
                                     VALUES (@Name,@Year,@Year,@Amount,@Description,@CompanyId)";

                var dp = new DynamicParameters();
                dp.Add("@Name", hardware.Name);
                dp.Add("@Year", hardware.Year);
                dp.Add("@Price", hardware.Price);
                dp.Add("@Amount", hardware.Amount);
                dp.Add("@Description", hardware.Description);
                dp.Add("@CompanyId", hardware.CompanyId);

                int result = connection.Execute(query, dp);
            }
        }

        public List<Hardware> GetHardware()
        {
            string connectionString = @"Server=LAPTOP-HK5PHBI7\MSSQLSERVER01;Database=kolokwiumSprzetKomp;Trusted_Connection=True;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var result = connection.Query<Hardware>("Select * from Hardware").ToList();
                return result;
            }
        }
    }
}
