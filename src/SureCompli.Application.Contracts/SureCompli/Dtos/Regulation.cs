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
    public class RegulationDto : AuditedEntityDto<Guid>
    {
        public virtual string Title { get; set; }
        public virtual string Ministry { get; set; }
        public virtual string Industry { get; set; }
        public virtual string Tags { get; set; }
        public virtual SureCompliEnum.RegulationOwner OwnerType { get; set; }

        public virtual Guid CategoryId { get; set; }
        public virtual string Document { get; set; }
        public virtual Guid OwnerId { get; set; }
        public virtual Guid CountryId { get; set; }


    }
}
