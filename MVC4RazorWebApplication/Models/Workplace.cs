using System.Collections.Generic;

namespace MVC4RazorWebApplication.Models
{
    /// <summary>
    /// Base class for Workplace.
    /// </summary>
    public class Workplace
    {
        #region Fields

        // The workplaceId field of the Workplace class.
        private int workplaceId;

        // The workplaceName field of the Workplace class.
        private string workplaceName;

        // The workplaceIsDeleted field of the Workplace class.
        private bool workplaceIsDeleted;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the workplaceId.
        /// </summary>
        /// <value>
        /// The workplaceId.
        /// </value>
        public int WorkplaceId
        {
            get { return workplaceId; }
            set { workplaceId = value; }
        }

        /// <summary>
        /// Gets or sets the workplaceName.
        /// </summary>
        /// <value>
        /// The workplaceName.
        /// </value>
        public string WorkplaceName
        {
            get { return workplaceName; }
            set { workplaceName = value; }
        }

        /// <summary>
        /// Gets or sets the workplaceIsDeleted.
        /// </summary>
        /// <value>
        /// The workplaceIsDeleted.
        /// </value>
        public bool WorkplaceIsDeleted
        {
            get { return workplaceIsDeleted; }
            set { workplaceIsDeleted = value; }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Workplace"/> class.
        /// </summary>
        public Workplace()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workplace"/> class.
        /// </summary>
        /// <param name="workplaceid">The input value for the workspadeId field.</param>
        /// <param name="workplacename">The input value for the workspadeName field.</param>
        /// <param name="workplaceisdeleted">The input value for the workspadeIsDeleted field.</param>
        public Workplace(int workplaceid, string workplacename, bool workplaceisdeleted)
        {
            workplaceId = workplaceid;
            workplaceName = workplacename;
            workplaceIsDeleted = workplaceisdeleted;
        }
		
		/// <summary>
        /// Destroys the instance of the <see cref="Workplace"/> class.
        /// </summary>
        ~Workplace()
        { }

        #endregion Constructors

        #region Methods

        #endregion Methods
    }

    /// <summary>
    /// Base class for Workplaces.
    /// </summary>
    public class Workplaces : List<Workplace>
    {
        #region Fields

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the Items.
        /// </summary>
        public List<Workplace> Items
		{ get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Workplaces"/> class.
        /// </summary>
        public Workplaces()
        {
            Items = new List<Workplace>();
        }
		
		/// <summary>
        /// Destroys the instance of the <see cref="Workplaces"/> class.
        /// </summary>
        ~Workplaces()
        { }

        #endregion Constructors

        #region Methods

        #endregion Methods
    }
}