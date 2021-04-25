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
    public class UserKeyDto : AuditedEntityDto<Guid>
    {
        public virtual Guid CreatedNodeId { get; set; }
        public virtual Guid UserId { get; set; }
        public virtual string Address { get; set; }
        public virtual string Sk { get; set; }
        public virtual string Pk { get; set; }
        public virtual string SecureInfo { get; set; }
        public virtual string Status { get; set; }
    }
}
