using SureCompli.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SureCompli.SureCompli
{
    public class Engagement : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("Regulation")]
        public virtual Guid RegulationId { get; set; }
        public virtual Regulation Regulation { get; set; }

        //[ForeignKey("Business")]
        public virtual Guid BusinessId { get; set; }
        //public virtual AppUser Business { get; set; }

        //[ForeignKey("Customer")]
        public virtual Guid CustomerId { get; set; }
        //public virtual AppUser Customer { get; set; }

        //[ForeignKey("Broker")]
        public virtual Guid? BrokerId { get; set; }
        //public virtual AppUser Broker { get; set; }

        public virtual ICollection<EngagementQA> EngagementQA { get; set; }
        public virtual ICollection<EngagementCharge> EngagementCharges { get; set; }

        public virtual decimal Cost { get; set; }
        public virtual string HashId { get; set; }
        public virtual string ContractAddress { get; set; }
        public virtual string ContractTransactionDump { get; set; }
        public virtual string ISIN { get; set; }
        public virtual string Status { get; set; }
    }
}
