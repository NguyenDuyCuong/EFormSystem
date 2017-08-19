using System;
using System.Collections.Generic;
using System.Text;

namespace EFS.APIModel.Base
{
    public class ModelItem : IValidatable
    {
        /// <summary>
        /// The validation errors
        /// </summary>
        private readonly ValidationErrors _validationErrors;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityBase" /> class.
        /// </summary>
        protected ModelItem()
        {
            _validationErrors = new ValidationErrors();
        }

        /// <summary>
        /// Gets a value indicating whether this instance is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsValid
        {
            get
            {
                return ValidationErrors.Items.Count == 0;
            }
        }
        
        /// <summary>
        /// Gets the validation errors.
        /// </summary>
        /// <value>
        /// The validation errors.
        /// </value>
        public virtual ValidationErrors ValidationErrors
        {
            get { return _validationErrors; }
        }

        public virtual void SetLogicError(string propName, string msg)
        {
            _validationErrors.Add(new ValidationError(propName, msg, Common.Global.ValidationErrorTypes.LogicError));
        }
    }
}
