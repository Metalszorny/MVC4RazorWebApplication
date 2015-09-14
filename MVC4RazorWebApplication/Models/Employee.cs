using System.Collections.Generic;

namespace MVC4RazorWebApplication.Models
{
    /// <summary>
    /// Base class for Employee.
    /// </summary>
    public class Employee
    {
        #region Fields

        // The employeeId field of the Employee class.
        private int employeeId;

        // The employeeName field of the Employee class.
        private string employeeName;

        // The employeeEmail field of the Employee class.
        private string employeeEmail;

        // The employeeIsDeleted field of the Employee class.
        private bool employeeIsDeleted;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the employeeId.
        /// </summary>
        /// <value>
        /// The employeeId.
        /// </value>
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        /// <summary>
        /// Gets or sets the employeeName.
        /// </summary>
        /// <value>
        /// The employeeName.
        /// </value>
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }

        /// <summary>
        /// Gets or sets the employeeEmail.
        /// </summary>
        /// <value>
        /// The employeeEmail.
        /// </value>
        public string EmployeeEmail
        {
            get { return employeeEmail; }
            set { employeeEmail = value; }
        }

        /// <summary>
        /// Gets or sets the employeeIsDeleted.
        /// </summary>
        /// <value>
        /// The employeeIsDeleted.
        /// </value>
        public bool EmployeeIsDeleted
        {
            get { return employeeIsDeleted; }
            set { employeeIsDeleted = value; }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="employeeid">The input value of the employeeId field.</param>
        /// <param name="workplacename">The input value of the employeeName field.</param>
        /// <param name="employeeemail">The input value of the employeeEmail field.</param>
        /// <param name="workplaceisdeleted">The input value of the employeeIsDeleted field.</param>
        public Employee(int employeeid, string workplacename, string employeeemail, bool workplaceisdeleted)
        {
            employeeId = employeeid;
            employeeName = workplacename;
            employeeEmail = employeeemail;
            employeeIsDeleted = workplaceisdeleted;
        }

        #endregion Constructors

        #region Methods

        #endregion Methods
    }

    /// <summary>
    /// Base class for Employees.
    /// </summary>
    public class Employees : List<Employee>
    {
        #region Fields

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the Items.
        /// </summary>
        public List<Employee> Items { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Employees"/> class.
        /// </summary>
        public Employees()
        {
            Items = new List<Employee>();
        }

        #endregion Constructors

        #region Methods

        #endregion Methods
    }
}