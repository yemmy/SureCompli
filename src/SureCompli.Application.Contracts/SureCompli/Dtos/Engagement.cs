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
    public class EngagementDto : AuditedEntityDto<Guid>
    {       
        public virtual Guid RegulationId { get; set; }
        public virtual Guid BusinessId { get; set; }       
        public virtual Guid CustomerId { get; set; }
        public virtual Guid? BrokerId { get; set; }
        public virtual decimal Cost { get; set; }
        public virtual string HashId { get; set; }
        public virtual string ContractAddress { get; set; }
        public virtual string ContractTransactionDump { get; set; }
        public virtual string ISIN { get; set; }
        public virtual string Status { get; set; }
    }
}
