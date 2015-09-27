using System;
using Pizza.Contracts.Default.Persistence;
using Pizza.Contracts.Persistence.Attributes;
using Pizza.Framework.TestTypes.Domain.Common;

namespace Pizza.Framework.TestTypes.Domain.PersistenceModels
{
    public class Customer : SoftDeletableModelBase
    {
        [Unique, UnicodeString(30)]
        public virtual string Login { get; set; }

        [FixedLengthAnsiString(128)]
        public virtual string Password { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int FingersCount { get; set; }
        public virtual DateTime PreviousSurgeryDate { get; set; }
        public virtual double HairLength { get; set; }
        public virtual CustomerType Type { get; set; }
        
        public virtual string FullName
        {
            get { return string.Format("{0} {1}", this.FirstName, this.LastName); }
        }
    }
}