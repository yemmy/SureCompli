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
    public class RegulationQuestionDto : AuditedEntityDto<Guid>
    {
        public virtual Guid RegulationId { get; set; }

        public virtual Guid QuestionId { get; set; }

        public virtual string Status { get; set; }
    }
}
