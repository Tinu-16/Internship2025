using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Day8_ADO_Oct23
{
    public class EmployeeDbOperations
    {
        string cs = @"Data Source=localhost;Initial Catalog=Sample;User ID=sa;Password=sql_server@1234;Trust Server Certificate=True";

        public void InsertData(string name, double salary)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand insertCmd = new SqlCommand("INSERT INTO Employee VALUES (@name,@salary)", conn);
                insertCmd.Parameters.AddWithValue("@name", name);
                insertCmd.Parameters.AddWithValue("@salary", salary);

                int rowsAffected = insertCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Employee inserted successfully");
                }
                else
                {
                    Console.WriteLine("Employee not inserted");
                }
            }
        }

        public void DisplayEmployee()
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand insertCmd = new SqlCommand("select * from Employee", conn);

                using (SqlDataReader reader = insertCmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Employee id: {reader.GetInt32(reader.GetOrdinal("Id"))}, name : {reader.GetString(reader.GetOrdinal("Name"))}, salary : {reader.GetDecimal(reader.GetOrdinal("Salary"))}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Employee table is empty");
                    }
                }
            }
        }

        public void UpdateEmployee(int id,double salary)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand updateCmd = new SqlCommand("update Employee set Salary=@salary where Id=@id", conn);
                updateCmd.Parameters.AddWithValue("@salary", salary);
                updateCmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = updateCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Employee salary updated successfully.");
                }
                else
                {
                    Console.WriteLine("Employee details not updated");
                }

            }
        }

        public void DeleteEmployee(int id)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();
                SqlCommand deleteCmd = new SqlCommand("delete from Employee where Id=@id", conn);
                deleteCmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = deleteCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Employee deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Deletion failed");
                }

            }
        }

        public void TotalEmployees()
        {
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Employee";

                SqlCommand command = new SqlCommand(query, connection);

                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    result = Convert.ToInt32(result);
                }

                Console.WriteLine($"Total employees: {result}");
            }
        }

        public void DisplayEmployeeDataDisconnected()
        {
            string selectAllQuery = "SELECT * FROM Employee";
            DataSet employeeDataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(selectAllQuery, connection);
                    adapter.Fill(employeeDataSet, "Employees");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving all data: {ex.Message}");
                    return;
                }
            }
            DataTable allEmployeesTable = employeeDataSet.Tables["Employees"];
            if (allEmployeesTable != null)
            { 
                foreach (DataRow row in allEmployeesTable.Rows)
                {
                    int id = (int)row["Id"];
                    string name = (string)row["Name"];
                    decimal salary = (decimal)row["Salary"];

                    Console.WriteLine($"Employee id: {id}, name: {name}, salary: {salary}");
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

            string selectSpecificQuery = "SELECT Name, Salary FROM Employee";
            DataSet specificDataSet = new DataSet();

            using (SqlConnection connection = new SqlConnection(cs))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(selectSpecificQuery, connection);
                    adapter.Fill(specificDataSet, "SpecificEmployees");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving specific data: {ex.Message}");
                    return;
                }
            }
            DataTable specificEmployeesTable = specificDataSet.Tables["SpecificEmployees"];
            if (specificEmployeesTable != null)
            {
                foreach (DataRow row in specificEmployeesTable.Rows)
                {
                    string name = row["Name"].ToString();
                    decimal salary = Convert.ToDecimal(row["Salary"]);

                    Console.WriteLine($"Employee name: {name}, salary: {salary}");
                }
            }
            else
            {
                Console.WriteLine("No data found for Name and Salary.");
            }
        }

        public void RetrieveModifyUpdate()
        {
            string query = "SELECT * FROM Employee";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");  

                Console.WriteLine("Employee Data Before Modification");
                foreach (DataRow row in ds.Tables["Employee"].Rows)
                {
                    Console.WriteLine($"ID: {row["Id"]}, Name: {row["Name"]}, Salary: {row["Salary"]}");
                }

                if (ds.Tables["Employee"].Rows.Count > 0)
                {
                    ds.Tables["Employee"].Rows[0]["Salary"] = Convert.ToDecimal(ds.Tables["Employee"].Rows[0]["Salary"]) + 5000;
                }

                int rowsUpdated = da.Update(ds, "Employee");

                ds.Clear();
                da.Fill(ds, "Employee");

                Console.WriteLine("Employee Data After Updation");
                foreach (DataRow row in ds.Tables["Employee"].Rows)
                {
                    Console.WriteLine($"ID: {row["Id"]}, Name: {row["Name"]}, Salary: {row["Salary"]}");
                }
            }
        }
    }
}
