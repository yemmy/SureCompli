using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities.Auditing;

namespace SureCompli.SureCompli
{
    public class CountryDto: AuditedEntityDto<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Capital { get; set; }
        public virtual string Status { get; set; }
        //public virtual ICollection<Regulation> Regulations { get; set; }
    }
}
