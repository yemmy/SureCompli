using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SureCompli.SureCompli
{
    public class Question : FullAuditedAggregateRoot<Guid>
    {
        public virtual string Text { get; set; }
        public virtual SureCompliEnum.QuestionType QuestionType { get; set; }
        public virtual SureCompliEnum.QuestionOwnerType OwerType { get; set; }
        public virtual Guid? OwnerId { get; set; } //supplied if the question is owned by business
        public virtual string OptionsCSV { get; set; }
        public virtual SureCompliEnum.BasicStatus Status { get; set; }

        public virtual ICollection<RegulationQuestion> RegulationQuestions { get; set; }
    }
}
