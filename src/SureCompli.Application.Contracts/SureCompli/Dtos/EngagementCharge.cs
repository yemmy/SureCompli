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
    public class EngagementChargeDto : AuditedEntityDto<Guid>
    {
        public virtual Guid EngagementId { get; set; }
        public virtual SureCompliEnum.ChargeType ChargeType { get; set; }
        public virtual Guid ChargeReceiverId { get; set; }
        public virtual decimal Amount { get; set; }
    }
}
