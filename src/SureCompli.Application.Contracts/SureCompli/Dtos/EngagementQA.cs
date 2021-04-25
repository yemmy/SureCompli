using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities.Auditing;

namespace SureCompli.SureCompli
{
    public class EngagementQADto : AuditedEntityDto<Guid>
    {

        public virtual Guid EngagementId { get; set; }
        public virtual Guid AnswererId { get; set; }
        public virtual Guid QuestionId { get; set; }
        public virtual Guid CheckedBy { get; set; } //who checked this at the Busness side

        public virtual string Answer { get; set; }
        public virtual string Status { get; set; }
    }
}
