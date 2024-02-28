using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        public static bool GetCountryInfoByID(int ID, ref string CountryName)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SP_GetCountryInfoByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CountryID", ID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            isFound = true;

                            CountryName = (string)reader["CountryName"];

                        }
                        else
                        {
                            isFound = false;
                        }

                    }

                }
            }

            return isFound;
 
        }

        public static bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetCountryInfoByName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            isFound = true;

                            ID = (int)reader["CountryID"];

                        }
                        else
                        {
                            isFound = false;
                        }

                    }

                }
            }

            return isFound;
          
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SP_GetAllCountries", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dt.Load(reader);
                        }

                    }

                }

            }

            return dt;

        }
    }
}
