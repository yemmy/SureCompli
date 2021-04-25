using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SureCompli.SureCompli
{
    public class RegulationQuestion : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("Regulation")]
        public virtual Guid RegulationId { get; set; }
        public virtual Regulation Regulation { get; set; }

        [ForeignKey("Question")]
        public virtual Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public virtual string Status { get; set; }
    }
}
