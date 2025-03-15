using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIGADIC_COURSE
{
    public class Sql
    {
        SqlConnection connection;
        string connectionString = "Server=.;Database=TESTBIGADIC_COURSE;Trusted_Connection=True;";
        //string connectionString = "Server=.;Database=TESTBIGADIC_COURSE;Trusted_Connection=True;"; // development
        string configPath = Application.StartupPath + "\\sql.cnfg";

        private void GetSqlConfig()
        {
            try
            {
                if (!File.Exists(configPath)) // config dosyası yoksa oluşturur.
                    File.Create(configPath).Close();

                connectionString = File.ReadAllText(configPath);
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetSqlConfig Error ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
            }
        }

        private async Task<bool> Connect()
        {
            try
            {
                await Task.Run(() =>
                {
                    GetSqlConfig();
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                });
                return true;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"Connect Error ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                return false;
            }
        }

        public async Task<DataTable> GetFromDb(string query, List<SqlParameter> parameters = null)
        {
            try
            {
                if (!await Connect())
                    return null;
                DataTable resultTable = new DataTable();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters.ToArray());
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        adapter.Fill(resultTable);
                }
                return resultTable;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"GetFromDb Error ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public async Task<int> EditData(string query, List<SqlParameter> parameters = null)
        {
            try
            {
                if (!await Connect())
                    return 0;

                int returnCode = 1;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters.ToArray());
                    var result = command.ExecuteScalar();

                    if (result != null && result.ToString() == "MEVCUT KAYIT BULUNMAKTADIR")
                        returnCode = 2;
                }
                return returnCode;
            }
            catch (Exception ex)
            {
                Log.logger.Error($"EditData Error ex.message: {ex.Message} ex.stacktrace: {ex.StackTrace}");
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
