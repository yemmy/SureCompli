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
    public class RegulationCategory : FullAuditedAggregateRoot<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool HasParent { get; set; }

        [ForeignKey("Parent")]
        public virtual Guid ParentId { get; set; }
        public virtual RegulationCategory Parent { get; set; }

        public virtual Country Country { get; set; }
        [ForeignKey("Country")]
        public virtual Guid CountryId { get; set; }
        public virtual ICollection<Regulation> Regulations { get; set; }


    }
}
