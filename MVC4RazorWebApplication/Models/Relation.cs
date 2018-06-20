using System.Collections.Generic;

namespace MVC4RazorWebApplication.Models
{
    /// <summary>
    /// Base class for Relation.
    /// </summary>
    public class Relation
    {
        #region Fields

        // The relationId field of the Relation class.
        private int relationId;

        // The relationEmployee field of the Relation class.
        private int relationEmployee;

        // The relationWorkplace field of the Relation class.
        private int relationWorkplace;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the relationId.
        /// </summary>
        /// <value>
        /// The relationId.
        /// </value>
        public int RelationId
        {
            get { return relationId; }
            set { relationId = value; }
        }

        /// <summary>
        /// Gets or sets the relationEmployee.
        /// </summary>
        /// <value>
        /// The relationEmployee.
        /// </value>
        public int RelationEmployee
        {
            get { return relationEmployee; }
            set { relationEmployee = value; }
        }

        /// <summary>
        /// Gets or sets the relationWorkplace.
        /// </summary>
        /// <value>
        /// The relationWorkplace.
        /// </value>
        public int RelationWorkplace
        {
            get { return relationWorkplace; }
            set { relationWorkplace = value; }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Relation"/> class.
        /// </summary>
        public Relation()
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Relation"/> class.
        /// </summary>
        /// <param name="relationid">The input value for the relationId field.</param>
        /// <param name="relationemployee">The input value for the relationEmployee field.</param>
        /// <param name="relationworkplace">The input value for the relationWorkplace field.</param>
        public Relation(int relationid, int relationemployee, int relationworkplace)
        {
            relationId = relationid;
            relationEmployee = relationemployee;
            relationWorkplace = relationworkplace;
        }
		
		/// <summary>
        /// Destroys the instance of the <see cref="Relation"/> class.
        /// </summary>
        ~Relation()
        { }

        #endregion Constructors

        #region Methods

        #endregion Methods
    }

    /// <summary>
    /// Base class for Relations.
    /// </summary>
    public class Relations : List<Relation>
    {
        #region Fields

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets the Items.
        /// </summary>
        public List<Relation> Items
		{ get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Relations"/> class.
        /// </summary>
        public Relations()
        {
            Items = new List<Relation>();
        }
		
		/// <summary>
        /// Destroys the instance of the <see cref="Relations"/> class.
        /// </summary>
        ~Relations()
        { }

        #endregion Constructors

        #region Methods

        #endregion Methods
    }
}