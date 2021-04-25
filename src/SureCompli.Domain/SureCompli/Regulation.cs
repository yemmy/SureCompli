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
    public class Regulation : FullAuditedAggregateRoot<Guid>
    {
        public virtual string Title { get; set; }
        public virtual string Ministry { get; set; }
        public virtual string Industry { get; set; }
        public virtual string Tags { get; set; }
        public virtual SureCompliEnum.RegulationOwner OwnerType { get; set; }

        [ForeignKey("Category")]
        public virtual Guid CategoryId { get; set; }
        public virtual RegulationCategory Category { get; set; }
        public virtual string Document { get; set; }

        [ForeignKey("Owner")]
        public virtual Guid OwnerId { get; set; }
        public virtual AppUser Owner { get; set; }

        public virtual Country Country { get; set; }
        [ForeignKey("Country")]
        public virtual Guid CountryId { get; set; }

        public virtual ICollection<RegulationQuestion> RegulationQuestions { get; set; }


    }
}
