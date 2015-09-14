

namespace MVC4RazorWebApplication.Controllers
{
    /// <summary>
    /// Interaction logic for BusinessLogicLayer.
    /// </summary>
    public class BusinessLogicLayer
    {
        #region Fields

        // Connection to DataAccessLayer.
        private DataAccessLayer dataAccessLayer = new DataAccessLayer();

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
                return dataAccessLayer.ListWorkplaces();
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
                return dataAccessLayer.ListEmployees();
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
                return dataAccessLayer.ListRelations();
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
                return dataAccessLayer.DeleteWorkplace(input);
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
                return dataAccessLayer.DeleteEmployee(input);
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
                return dataAccessLayer.DeleteRelation(input);
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
                return dataAccessLayer.AddWorkplace(input);
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
                return dataAccessLayer.AddEmployee(input);
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
                return dataAccessLayer.AddRelation(input);
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
                return dataAccessLayer.ModifyWorkplace(input);
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
                return dataAccessLayer.ModifyEmployee(input);
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
                return dataAccessLayer.ModifyRelation(input);
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
                return dataAccessLayer.FindWorkplaceByName(input);
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
                return dataAccessLayer.FindEmployeeByName(input);
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
                return dataAccessLayer.FindEmployeeByEmail(input);
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
                return dataAccessLayer.FindEmployeeByNameAndEmail(name, email);
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
                return dataAccessLayer.FindRelationByEmployee(input);
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
                return dataAccessLayer.FindRelationByWorkplace(input);
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
                return dataAccessLayer.FindRelationByEmployeeAndWorkplace(employee, workplace);
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