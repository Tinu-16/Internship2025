using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Day8_ADO_Oct23
{
    public class StudentDBOperations
    {
        string cs = @"Data Source=localhost;Initial Catalog=Sample;User ID=sa;Password=sql_server@1234;Trust Server Certificate=True";

        public void InsertData(string studentName, string studentClass)
        {
            int rowsAffected = 0;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(cs);
                conn.Open();

                string query = "INSERT INTO Student (Name, Class) VALUES (@Name, @Class)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Name", studentName);
                command.Parameters.AddWithValue("@Class", studentClass);

                rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Rows inserted: {rowsAffected}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn unexpected error occurred:");
                Console.WriteLine($"   Error: {ex.Message}");
                return;
            }
            finally
            {
                conn.Close();
            }
        }

        public void GetStudentByIdAndPrint(int studentId)
        {

            Console.WriteLine($"\n--- Fetching Student with ID = {studentId} ---");
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string procedureName = "GetStudentById";

                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"Student id: {reader.GetInt32(reader.GetOrdinal("Id"))}, name : {reader.GetString(reader.GetOrdinal("Name"))}, class : {reader.GetString(reader.GetOrdinal("Class"))}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Student with id {studentId} does not exists");
                        }
                    }
                }
            }
        }

        public void InsertStudent(string studentName, string studentClass)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                string procedureName = "InsertStudent";

                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    connection.Open();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Name", studentName);
                    command.Parameters.AddWithValue("@Class", studentClass);

                    SqlParameter outputParam = new SqlParameter();
                    outputParam.ParameterName = "@LastInsertedId";
                    outputParam.SqlDbType = SqlDbType.Int;
                    outputParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(outputParam);

                    try
                    {
                        int rowsCount = command.ExecuteNonQuery();
                        if (rowsCount > 0)
                        {
                            int lastInsertedId = (int)outputParam.Value;
                            Console.WriteLine($"Last inserted student ID: {lastInsertedId}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        public void DeleteStudent(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DeleteStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentId", studentId);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine($"Student with id {studentId} is deleted successfully");
                }
                else
                {
                    Console.WriteLine($"Student with id {studentId} not found");
                }

            }
        }

        public void UpdateStudent(int studentId, string studentName, string studentClass)
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UpdateStudent", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentId", studentId);
                command.Parameters.AddWithValue("@StudnetName", studentName);
                command.Parameters.AddWithValue("@Class", studentClass);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine($"Student with id {studentId} updated successfully");
                }
                else
                {
                    Console.WriteLine($"Student with id {studentId} not found");
                }
            }
        }

    }
}
