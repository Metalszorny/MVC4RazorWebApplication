using System.Web.Mvc;

namespace MVC4RazorWebApplication.Controllers
{
    /// <summary>
    /// Interaction logic for HomeController.
    /// </summary>
    public class HomeController : Controller
    {
        #region Fields

        // Connection to BusinessLogicLayer.
        private BusinessLogicLayer businessLogicLayer = new BusinessLogicLayer();

        #endregion Fields

        #region Methods

        #region List

        /// <summary>
        /// Lists the database tables.
        /// </summary>
        /// <returns>The Index view.</returns>
        public ActionResult Index()
        {
            // List the items from the tables.
            Models.Workplaces workplaces = businessLogicLayer.ListWorkplaces();
            Models.Employees employees = businessLogicLayer.ListEmployees();
            Models.Relations relations = businessLogicLayer.ListRelations();

            // Store the items in the ViewBag so the Index view can use them.
            ViewBag.Workplaces = workplaces;
            ViewBag.Employees = employees;
            ViewBag.Relations = relations;

            return View();
        }

        #endregion List

        #region Edit

        /// <summary>
        /// Edits a Workplace.
        /// </summary>
        /// <param name="id">The workplaceId that was selected.</param>
        /// <returns>The EditWorkplace view.</returns>
        // Load the view.
        public ActionResult EditWorkplace(int id)
        {
            // Find the selected Workplace and store it in the ViewBag.
            Models.Workplace workplace = businessLogicLayer.ListWorkplaces().Items.Find(x => x.WorkplaceId == id);
            ViewBag.Workplace = workplace;

            return View();
        }

        /// <summary>
        /// Edits a Workplace.
        /// </summary>
        /// <param name="workplace">The Workplace to edit.</param>
        /// <returns>The Index or the EditWorkplace view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult EditWorkplace(Models.Workplace workplace)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // The edit was successful
                if (businessLogicLayer.ModifyWorkplace(workplace))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        /// <summary>
        /// Edits a Employee.
        /// </summary>
        /// <param name="id">The employeeId that was selected.</param>
        /// <returns>The EditEmployee view.</returns>
        // Load the view.
        public ActionResult EditEmployee(int id)
        {
            // Find the selected Employee and store it in the ViewBag.
            Models.Employee employee = businessLogicLayer.ListEmployees().Items.Find(x => x.EmployeeId == id);
            ViewBag.Employee = employee;

            return View();
        }

        /// <summary>
        /// Edits a Employee.
        /// </summary>
        /// <param name="employee">The Employee to edit.</param>
        /// <returns>The Index or the EditEmployee view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult EditEmployee(Models.Employee employee)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // The edit was successful.
                if (businessLogicLayer.ModifyEmployee(employee))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        /// <summary>
        /// Edits a Relation.
        /// </summary>
        /// <param name="id">The relationId that was selected.</param>
        /// <returns>The EditRelation view.</returns>
        // Load the view.
        public ActionResult EditRelation(int id)
        {
            // Find the selected Relation and store it in the ViewBag.
            Models.Relation relation = businessLogicLayer.ListRelations().Items.Find(x => x.RelationId == id);
            ViewBag.Relation = relation;

            // List the Workplaces and store them in the ViewBag.
            Models.Workplaces workplaces = businessLogicLayer.ListWorkplaces();
            ViewBag.Workplaces = workplaces;

            // Lists the Employees and store them in the ViewBag.
            Models.Employees employees = businessLogicLayer.ListEmployees();
            ViewBag.Employees = employees;

            return View();
        }

        /// <summary>
        /// Edits a Relation.
        /// </summary>
        /// <param name="relation">The Relation to edit.</param>
        /// <returns>The Index or the EditRelation view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult EditRelation(Models.Relation relation)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // The edit was successful.
                if (businessLogicLayer.ModifyRelation(relation))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        #endregion Edit

        #region Delete

        /// <summary>
        /// Deletes a Workplace.
        /// </summary>
        /// <param name="id">The workplaceId that was selected.</param>
        /// <returns>The DeleteWorkplace view.</returns>
        // Load the view.
        public ActionResult DeleteWorkplace(int id)
        {
            // Find the selected Workplace and store it in the ViewBag.
            Models.Workplace workplace = businessLogicLayer.ListWorkplaces().Items.Find(x => x.WorkplaceId == id);
            ViewBag.Workplace = workplace;

            // Find the selected Workplace's Relations and store them in the ViewBag.
            Models.Relation relation = businessLogicLayer.ListRelations().Items.Find(x => x.RelationWorkplace == id);
            ViewBag.Relation = relation;

            return View();
        }

        /// <summary>
        /// Deletes a Workplace.
        /// </summary>
        /// <param name="workplace">The Workplace to delete.</param>
        /// <returns>The Index or the DeleteWorkplace view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult DeleteWorkplace(Models.Workplace workplace)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // The delete was successful.
                if (businessLogicLayer.DeleteWorkplace(workplace))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        /// <summary>
        /// Deletes a Employee.
        /// </summary>
        /// <param name="id">The employeeId that was selected.</param>
        /// <returns>The DeleteEmployee view.</returns>
        // Load the view.
        public ActionResult DeleteEmployee(int id)
        {
            // Find the selected Employee and store it in the ViewBag.
            Models.Employee employee = businessLogicLayer.ListEmployees().Items.Find(x => x.EmployeeId == id);
            ViewBag.Employee = employee;

            // Find the selected Employee's Relations and store them in the ViewBag.
            Models.Relation relation = businessLogicLayer.ListRelations().Items.Find(x => x.RelationEmployee == id);
            ViewBag.Relation = relation;

            return View();
        }

        /// <summary>
        /// Deletes a Employee.
        /// </summary>
        /// <param name="employee">The Employee to delete.</param>
        /// <returns>The Index or the DeleteEmployee view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult DeleteEmployee(Models.Employee employee)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // The delete was successful.
                if (businessLogicLayer.DeleteEmployee(employee))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        /// <summary>
        /// Deletes a Relation.
        /// </summary>
        /// <param name="id">The relationId that was selected.</param>
        /// <returns>The DeleteRelation view.</returns>
        // Load the view.
        public ActionResult DeleteRelation(int id)
        {
            // Find the selected Relation and store it in the ViewBag.
            Models.Relation relation = businessLogicLayer.ListRelations().Items.Find(x => x.RelationId == id);
            ViewBag.Relation = relation;

            return View();
        }

        /// <summary>
        /// Deletes a Relation.
        /// </summary>
        /// <param name="relation">The Relation to delete.</param>
        /// <returns>The Index or the DeleteRelation view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult DeleteRelation(Models.Relation relation)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // The delete was successful.
                if (businessLogicLayer.DeleteRelation(relation))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        #endregion Delete

        #region Add

        /// <summary>
        /// Adds a Workplace.
        /// </summary>
        /// <returns>The AddWorkplace view.</returns>
        // Load the view.
        public ActionResult AddWorkplace()
        {
            return View();
        }

        /// <summary>
        /// Adds a Workplace.
        /// </summary>
        /// <param name="formCollection">The Workplace to add.</param>
        /// <returns>The Index or the AddWorkplace view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult AddWorkplace(FormCollection formCollection)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // Create the Workplace to add.
                Models.Workplace workplace = new Models.Workplace();
                workplace.WorkplaceId = businessLogicLayer.ListWorkplaces().Items.Count + 1;
                workplace.WorkplaceName = formCollection["workplaceName"];
                workplace.WorkplaceIsDeleted = false;

                // The add was successful.
                if (businessLogicLayer.AddWorkplace(workplace))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        /// <summary>
        /// Adds a Employee.
        /// </summary>
        /// <returns>The AddEmployee view.</returns>
        // Load the view.
        public ActionResult AddEmployee()
        {
            return View();
        }

        /// <summary>
        /// Adds a Employee.
        /// </summary>
        /// <param name="formCollection">The Employee to add.</param>
        /// <returns>The Index or the AddEmployee view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult AddEmployee(FormCollection formCollection)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // Create the Workplace to add.
                Models.Employee employee = new Models.Employee();
                employee.EmployeeId = businessLogicLayer.ListEmployees().Items.Count + 1;
                employee.EmployeeName = formCollection["employeeName"];
                employee.EmployeeEmail = formCollection["employeeEmail"];
                employee.EmployeeIsDeleted = false;

                // The add was successful.
                if (businessLogicLayer.AddEmployee(employee))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        /// <summary>
        /// Adds a Relation.
        /// </summary>
        /// <returns>The AddRelation view.</returns>
        // Load the view.
        public ActionResult AddRelation()
        {
            // List the Relations and store them in the ViewBag.
            Models.Relations relations = businessLogicLayer.ListRelations();
            ViewBag.Relations = relations;

            // List the Workplaces and store them in the ViewBag.
            Models.Workplaces workplaces = businessLogicLayer.ListWorkplaces();
            ViewBag.Workplaces = workplaces;

            // List the Employees and store them in the ViewBag.
            Models.Employees employees = businessLogicLayer.ListEmployees();
            ViewBag.Employees = employees;

            return View();
        }

        /// <summary>
        /// Adds a Relation.
        /// </summary>
        /// <param name="formCollection">The Relation to add.</param>
        /// <returns>The Index or the AddRelation view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult AddRelation(FormCollection formCollection)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                // Create the Workplace to add.
                Models.Relation relation = new Models.Relation();
                relation.RelationId = businessLogicLayer.ListRelations().Items.Count + 1;
                relation.RelationEmployee = int.Parse(formCollection["relationEmployee"]);
                relation.RelationWorkplace = int.Parse(formCollection["relationWorkplace"]);

                // The add was successful.
                if (businessLogicLayer.AddRelation(relation))
                {
                    return RedirectToAction("Index");
                }

                return View();
            }

            return View();
        }

        #endregion Add

        #region Find

        /// <summary>
        /// Finds a Workplace.
        /// </summary>
        /// <returns>The FindWorkplace view.</returns>
        // Load the view.
        public ActionResult FindWorkplace()
        {
            return View();
        }

        /// <summary>
        /// Finds a Workplace.
        /// </summary>
        /// <param name="formCollection">The Workplace to find.</param>
        /// <returns>The FindWorkplace view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult FindWorkplace(FormCollection formCollection)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                Models.Workplaces result = new Models.Workplaces();

                if (!string.IsNullOrEmpty(formCollection["workplaceName"]))
                {
                    // The workplaceName query field was not empty so find the items. 
                    result = businessLogicLayer.FindWorkplaceByName(formCollection["workplaceName"]);
                }
                else
                {
                    // The workplaceName query field was empty so list all items. 
                    result = businessLogicLayer.ListWorkplaces();
                }

                // Store the result in the ViewBag.
                ViewBag.Workplaces = result;
            }

            return View();
        }

        /// <summary>
        /// Finds a Employee.
        /// </summary>
        /// <returns>The FindEmployee view.</returns>
        // Load the view.
        public ActionResult FindEmployee()
        {
            return View();
        }

        /// <summary>
        /// Finds a Employee.
        /// </summary>
        /// <param name="formCollection">The Employee to find.</param>
        /// <returns>The FindEmployee view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult FindEmployee(FormCollection formCollection)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                Models.Employees result = new Models.Employees();

                if (!string.IsNullOrEmpty(formCollection["employeeName"]) && !string.IsNullOrEmpty(formCollection["employeeEmail"]))
                {
                    // The employeeName and employeeEmail query fields were not empty so list find the items. 
                    result = businessLogicLayer.FindEmployeeByNameAndEmail(formCollection["employeeName"], formCollection["employeeEmail"]);
                }
                else if (!string.IsNullOrEmpty(formCollection["employeeName"]) && string.IsNullOrEmpty(formCollection["employeeEmail"]))
                {
                    // The employeeEmail was empty, but the employeeName was not, so find the items based on the employeeName query field.
                    result = businessLogicLayer.FindEmployeeByName(formCollection["employeeName"]);
                }
                else if (string.IsNullOrEmpty(formCollection["employeeName"]) && !string.IsNullOrEmpty(formCollection["employeeEmail"]))
                {
                    // The employeeName was empty, but the employeeEmail was not, so find the items based on the employeeEmail query field.
                    result = businessLogicLayer.FindEmployeeByEmail(formCollection["employeeEmail"]);
                }
                else
                {
                    // The employeeName and employeeEmail query fields were empty so list all items. 
                    result = businessLogicLayer.ListEmployees();
                }

                // Store the result in the ViewBag.
                ViewBag.Employees = result;
            }

            return View();
        }

        /// <summary>
        /// Finds a Relation.
        /// </summary>
        /// <returns>The FindRelation view.</returns>
        // Load the view.
        public ActionResult FindRelation()
        {
            return View();
        }

        /// <summary>
        /// Finds a Relation.
        /// </summary>
        /// <param name="formCollection">The Relation to find.</param>
        /// <returns>The FindRelation view.</returns>
        // Click of the button.
        [HttpPost]
        public ActionResult FindRelation(FormCollection formCollection)
        {
            // The input conversion is valid.
            if (ModelState.IsValid)
            {
                Models.Relations result = new Models.Relations();

                if (!string.IsNullOrEmpty(formCollection["relationEmployee"]) && !string.IsNullOrEmpty(formCollection["relationWorkplace"]))
                {
                    // The relationEmployee and relationWorkplace query fields were not empty so find the items. 
                    result = businessLogicLayer.FindRelationByEmployeeAndWorkplace(formCollection["relationEmployee"], formCollection["relationWorkplace"]);
                }
                else if (!string.IsNullOrEmpty(formCollection["relationEmployee"]) && string.IsNullOrEmpty(formCollection["relationWorkplace"]))
                {
                    // The relationWorkplace was empty, but the relationEmployee was not, so find the items based on the relationEmployee query field.
                    result = businessLogicLayer.FindRelationByEmployee(formCollection["relationEmployee"]);
                }
                else if (string.IsNullOrEmpty(formCollection["relationEmployee"]) && !string.IsNullOrEmpty(formCollection["relationWorkplace"]))
                {
                    // The relationEmployee was empty, but the relationWorkplace was not, so find the items based on the relationWorkplace query field.
                    result = businessLogicLayer.FindRelationByWorkplace(formCollection["relationWorkplace"]);
                }
                else
                {
                    // The relationEmployee and relationWorkplace query fields were empty so list all items. 
                    result = businessLogicLayer.ListRelations();
                }

                // Store the result in the ViewBag.
                ViewBag.Relations = result;
            }

            return View();
        }

        #endregion Find

        #endregion Methods
    }
}
