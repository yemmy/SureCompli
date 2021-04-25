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
    public class BlockChainNodeDto : AuditedEntityDto<Guid>
    {
        public virtual Guid BlockChainId { get; set; }       
        public virtual Guid OwnerId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Port { get; set; }
        public virtual string Protocol { get; set; }
        public virtual string SecureInfo { get; set; }
        public virtual string Status { get; set; }
    }
}
