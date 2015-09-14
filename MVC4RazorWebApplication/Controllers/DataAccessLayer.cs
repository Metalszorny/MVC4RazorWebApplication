using System.Data.SqlClient;

namespace MVC4RazorWebApplication.Controllers
{
    /// <summary>
    /// Interaction logic for DataAccessLayer.
    /// </summary>
    public class DataAccessLayer
    {
        #region Fields

        // The connectionString for the database.
        private string url = "Server=.; Database=RazorViewExampleDatabase; Integrated Security=true";

        #endregion Fields

        #region Methods

        #region List

        /// <summary>
        /// Lists the Workplaces.
        /// </summary>
        /// <returns>The list of Workplaces or null.</returns>
        public Models.Workplaces ListWorkplaces()
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // List the items from the Workplaces table with the stored procedure.
                Models.Workplaces workplaces = new Models.Workplaces();
                SqlCommand sqlCommand = new SqlCommand("spListWorkplaces", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in a Workplace list.
                while (sqlDataReader.Read())
                {
                    workplaces.Items.Add(new Models.Workplace(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetBoolean(2)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return workplaces;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Lists the Employees.
        /// </summary>
        /// <returns>The list of Employees or null.</returns>
        public Models.Employees ListEmployees()
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // List the items from the Employees table with the stored procedure.
                Models.Employees employees = new Models.Employees();
                SqlCommand sqlCommand = new SqlCommand("spListEmployees", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in an Employee list.
                while (sqlDataReader.Read())
                {
                    employees.Items.Add(new Models.Employee(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetBoolean(3)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return employees;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Lists the Relations.
        /// </summary>
        /// <returns>The list of Relations or null.</returns>
        public Models.Relations ListRelations()
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // List the items from the Relations table with the stored procedure.
                Models.Relations relations = new Models.Relations();
                SqlCommand sqlCommand = new SqlCommand("spListRelations", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in a Relation list.
                while (sqlDataReader.Read())
                {
                    relations.Items.Add(new Models.Relation(sqlDataReader.GetInt32(0), sqlDataReader.GetInt32(1), sqlDataReader.GetInt32(2)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return relations;
            }
            catch
            {
                return null;
            }
        }

        #endregion List

        #region Delete

        /// <summary>
        /// Deletes a Workplace.
        /// </summary>
        /// <param name="input">The Workplace to delete.</param>
        /// <returns>The outcome of the method.</returns>
        public bool DeleteWorkplace(Models.Workplace input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Delete logically the item from the Workplaces table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spDeleteWorkplace", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", input.WorkplaceId);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes an Employee.
        /// </summary>
        /// <param name="input">The Employee to delete.</param>
        /// <returns>The outcome of the method.</returns>
        public bool DeleteEmployee(Models.Employee input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Delete logically the item from the Employees table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spDeleteEmployee", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", input.EmployeeId);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes a Relation.
        /// </summary>
        /// <param name="input">The Relation to delete.</param>
        /// <returns>The outcome of the method.</returns>
        public bool DeleteRelation(Models.Relation input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Delete logically the item from the Relations table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spDeleteRelation", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", input.RelationId);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion Delete

        #region Add

        /// <summary>
        /// Adds a Workplace.
        /// </summary>
        /// <param name="input">The Workplace to add.</param>
        /// <returns>The outcome of the method.</returns>
        public bool AddWorkplace(Models.Workplace input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Add the item to the Workplaces table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spAddWorkplace", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", input.WorkplaceId);
                sqlCommand.Parameters.AddWithValue("@name", input.WorkplaceName);
                sqlCommand.Parameters.AddWithValue("@isdeleted", input.WorkplaceIsDeleted);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Adds an Employee.
        /// </summary>
        /// <param name="input">The Employee to add.</param>
        /// <returns>The outcome of the method.</returns>
        public bool AddEmployee(Models.Employee input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Add the item to the Employees table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spAddEmployee", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", input.EmployeeId);
                sqlCommand.Parameters.AddWithValue("@name", input.EmployeeName);
                sqlCommand.Parameters.AddWithValue("@email", input.EmployeeEmail);
                sqlCommand.Parameters.AddWithValue("@isdeleted", input.EmployeeIsDeleted);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Adds a Relation.
        /// </summary>
        /// <param name="input">The Relation to add.</param>
        /// <returns>The outcome of the method.</returns>
        public bool AddRelation(Models.Relation input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Add the item to the Relations table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spAddRelation", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", input.RelationId);
                sqlCommand.Parameters.AddWithValue("@employee", input.RelationEmployee);
                sqlCommand.Parameters.AddWithValue("@workplace", input.RelationWorkplace);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion Add

        #region Modify

        /// <summary>
        /// Edits a Workplace.
        /// </summary>
        /// <param name="input">The Workplace to edit.</param>
        /// <returns>The outcome of the method.</returns>
        public bool ModifyWorkplace(Models.Workplace input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Edit the item in the Workplaces table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spEditWorkplace", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", input.WorkplaceId);
                sqlCommand.Parameters.AddWithValue("@name", input.WorkplaceName);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Edits an Employee.
        /// </summary>
        /// <param name="input">The Employee to edit.</param>
        /// <returns>The outcome of the method.</returns>
        public bool ModifyEmployee(Models.Employee input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Edit the item in the Employees table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spEditEmployee", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", input.EmployeeId);
                sqlCommand.Parameters.AddWithValue("@name", input.EmployeeName);
                sqlCommand.Parameters.AddWithValue("@email", input.EmployeeEmail);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Edits a Relation.
        /// </summary>
        /// <param name="input">The Relation to edit.</param>
        /// <returns>The outcome of the method.</returns>
        public bool ModifyRelation(Models.Relation input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Edit the item in the Relations table with the stored procedure.
                SqlCommand sqlCommand = new SqlCommand("spEditRelation", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@employee", input.RelationEmployee);
                sqlCommand.Parameters.AddWithValue("@workplace", input.RelationWorkplace);
                sqlCommand.Parameters.AddWithValue("@id", input.RelationId);
                sqlCommand.ExecuteNonQuery();

                // Close the connection.
                sqlConnection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion Modify

        #region Find

        /// <summary>
        /// Finds a Workplace by name.
        /// </summary>
        /// <param name="input">The Workplace name to find.</param>
        /// <returns>The Workplace list or null.</returns>
        public Models.Workplaces FindWorkplaceByName(string input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Find the items in the Workplaces table with the stored procedure.
                Models.Workplaces workplaces = new Models.Workplaces();
                SqlCommand sqlCommand = new SqlCommand("spFindWorkplaceByName", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", input);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in a Workplace list.
                while (sqlDataReader.Read())
                {
                    workplaces.Items.Add(new Models.Workplace(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetBoolean(2)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return workplaces;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Finds an Employee by name.
        /// </summary>
        /// <param name="input">The Employee name to find.</param>
        /// <returns>The Employee list or null.</returns>
        public Models.Employees FindEmployeeByName(string input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Find the items in the Employees table with the stored procedure.
                Models.Employees employees = new Models.Employees();
                SqlCommand sqlCommand = new SqlCommand("spFindEmployeeByName", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", input);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in an Employee list.
                while (sqlDataReader.Read())
                {
                    employees.Items.Add(new Models.Employee(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetBoolean(3)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return employees;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Finds an Employee by email.
        /// </summary>
        /// <param name="input">The Employee email to find.</param>
        /// <returns>The Employee list or null.</returns>
        public Models.Employees FindEmployeeByEmail(string input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Find the items in the Employees table with the stored procedure.
                Models.Employees employees = new Models.Employees();
                SqlCommand sqlCommand = new SqlCommand("spFindEmployeeByEmail", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@email", input);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in an Employee list.
                while (sqlDataReader.Read())
                {
                    employees.Items.Add(new Models.Employee(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetBoolean(3)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return employees;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Finds an Employee by name and email.
        /// </summary>
        /// <param name="name">The Employee name to find.</param>
        /// <param name="email">The Employee email to find.</param>
        /// <returns>The Employee list or null.</returns>
        public Models.Employees FindEmployeeByNameAndEmail(string name, string email)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Find the items in the Employees table with the stored procedure.
                Models.Employees employees = new Models.Employees();
                SqlCommand sqlCommand = new SqlCommand("spFindEmployeeByNameAndEmail", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@email", email);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in an Employee list.
                while (sqlDataReader.Read())
                {
                    employees.Items.Add(new Models.Employee(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1), sqlDataReader.GetString(2), sqlDataReader.GetBoolean(3)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return employees;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Finds an Relation by Employee.
        /// </summary>
        /// <param name="input">The Relation Employee to find.</param>
        /// <returns>The Relation list or null.</returns>
        public Models.Relations FindRelationByEmployee(string input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Find the items in the Employees table with the stored procedure.
                Models.Employees employees = new Models.Employees();
                SqlCommand sqlCommand1 = new SqlCommand("spFindEmployeeByName", sqlConnection);
                sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand1.Parameters.AddWithValue("@name", input);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();

                // Store the items in an Employee list.
                while (sqlDataReader1.Read())
                {
                    employees.Items.Add(new Models.Employee(sqlDataReader1.GetInt32(0), sqlDataReader1.GetString(1), sqlDataReader1.GetString(2), sqlDataReader1.GetBoolean(3)));
                }

                // Close the dataReader.
                sqlDataReader1.Close();

                // There is at least one item that was found.
                int input2 = 0;
                if (employees.Items.Count > 0)
                {
                    // Because the previous search was on an Id, there should only be one item found.
                    input2 = employees.Items[0].EmployeeId;
                }

                // Find the items in the Relations table with the stored procedure.
                Models.Relations relations = new Models.Relations();
                SqlCommand sqlCommand = new SqlCommand("spFindRelationByEmployee", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@employee", input2);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in an Relation list.
                while (sqlDataReader.Read())
                {
                    relations.Items.Add(new Models.Relation(sqlDataReader.GetInt32(0), sqlDataReader.GetInt32(1), sqlDataReader.GetInt32(2)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return relations;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Finds an Relation by Workplace.
        /// </summary>
        /// <param name="input">The Relation Workplace to find.</param>
        /// <returns>The Relation list or null.</returns>
        public Models.Relations FindRelationByWorkplace(string input)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Find the items in the Workplaces table with the stored procedure.
                Models.Workplaces workplaces = new Models.Workplaces();
                SqlCommand sqlCommand1 = new SqlCommand("spFindWorkplaceByName", sqlConnection);
                sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand1.Parameters.AddWithValue("@name", input);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();

                // Store the items in an Workplace list.
                while (sqlDataReader1.Read())
                {
                    workplaces.Items.Add(new Models.Workplace(sqlDataReader1.GetInt32(0), sqlDataReader1.GetString(1), sqlDataReader1.GetBoolean(2)));
                }

                // Close the dataReader.
                sqlDataReader1.Close();

                // There is at least one item that was found.
                int input2 = 0;
                if (workplaces.Items.Count > 0)
                {
                    // Because the previous search was on an Id, there should only be one item found.
                    input2 = workplaces.Items[0].WorkplaceId;
                }

                // Find the items in the Relations table with the stored procedure.
                Models.Relations relations = new Models.Relations();
                SqlCommand sqlCommand = new SqlCommand("spFindRelationByWorkplace", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@workplace", input2);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in an Relation list.
                while (sqlDataReader.Read())
                {
                    relations.Items.Add(new Models.Relation(sqlDataReader.GetInt32(0), sqlDataReader.GetInt32(1), sqlDataReader.GetInt32(2)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return relations;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Finds an Relation by Employee and Workplace.
        /// </summary>
        /// <param name="employee">The Relation Employee to find.</param>
        /// <param name="workplace">The Relation Workplace to find.</param>
        /// <returns>The Relation list or null.</returns>
        public Models.Relations FindRelationByEmployeeAndWorkplace(string employee, string workplace)
        {
            try
            {
                // Open a connection to the database.
                SqlConnection sqlConnection = new SqlConnection(url);
                sqlConnection.Open();

                // Find the items in the Employees table with the stored procedure.
                Models.Employees employees = new Models.Employees();
                SqlCommand sqlCommand1 = new SqlCommand("spFindEmployeeByName", sqlConnection);
                sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand1.Parameters.AddWithValue("@name", employee);
                SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();

                // Store the items in an Employee list.
                while (sqlDataReader1.Read())
                {
                    employees.Items.Add(new Models.Employee(sqlDataReader1.GetInt32(0), sqlDataReader1.GetString(1), sqlDataReader1.GetString(2), sqlDataReader1.GetBoolean(3)));
                }

                // Close the dataReader.
                sqlDataReader1.Close();

                // Find the items in the Workplaces table with the stored procedure.
                Models.Workplaces workplaces = new Models.Workplaces();
                SqlCommand sqlCommand2 = new SqlCommand("spFindWorkplaceByName", sqlConnection);
                sqlCommand2.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand2.Parameters.AddWithValue("@name", workplace);
                SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();

                // Store the items in an Workplace list.
                while (sqlDataReader2.Read())
                {
                    workplaces.Items.Add(new Models.Workplace(sqlDataReader2.GetInt32(0), sqlDataReader2.GetString(1), sqlDataReader2.GetBoolean(2)));
                }

                // Close the dataReader.
                sqlDataReader2.Close();

                // There is at least one item that was found.
                int input2 = 0;
                int input3 = 0;
                if (employees.Items.Count > 0)
                {
                    // Because the previous search was on an Id, there should only be one item found.
                    input2 = employees.Items[0].EmployeeId;
                }
                if (workplaces.Items.Count > 0)
                {
                    // Because the previous search was on an Id, there should only be one item found.
                    input3 = workplaces.Items[0].WorkplaceId;
                }

                // Find the items in the Relations table with the stored procedure.
                Models.Relations relations = new Models.Relations();
                SqlCommand sqlCommand = new SqlCommand("spFindRelationByEmployeeAndWorkplace", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@employee", input2);
                sqlCommand.Parameters.AddWithValue("@workplace", input3);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                // Store the items in an Relation list.
                while (sqlDataReader.Read())
                {
                    relations.Items.Add(new Models.Relation(sqlDataReader.GetInt32(0), sqlDataReader.GetInt32(1), sqlDataReader.GetInt32(2)));
                }

                // Close the dataReader and the connection.
                sqlDataReader.Close();
                sqlConnection.Close();

                return relations;
            }
            catch
            {
                return null;
            }
        }

        #endregion Find

        #endregion Methods
    }
}