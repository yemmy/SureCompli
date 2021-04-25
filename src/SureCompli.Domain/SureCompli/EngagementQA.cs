using SureCompli.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace SureCompli.SureCompli
{
    public class EngagementQA : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey("Engagement")]
        public virtual Guid EngagementId { get; set; }
        public virtual Engagement Engagement { get; set; }

        [ForeignKey("AnswersBy")]
        public virtual Guid AnswererId { get; set; }
        public virtual AppUser Answerer { get; set; }


        [ForeignKey("Question")]
        public virtual Guid QuestionId { get; set; }
        public virtual Question Question { get; set; }

        public virtual Guid CheckedBy { get; set; } //who checked this at the Busness side

        public virtual string Answer { get; set; }
        public virtual string Status { get; set; }
    }
}
