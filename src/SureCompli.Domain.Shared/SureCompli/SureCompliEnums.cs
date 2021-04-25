using System;
using System.Collections.Generic;
using System.Text;

namespace SureCompli.SureCompli
{
    public class SureCompliEnum
    {
        public enum BasicStatus
        {
            ACTIVE,
            INACTIVE
        }

        public enum RegulationOwner
        {
            REGULATOR,
            BUSINESS
        }

        public enum QuestionType
        {
            MULTIPLECHOICE,
            NUMBERANSWER,
            TEXTANSWER
        }

        public enum QuestionOwnerType
        {
            REGULATOR,
            BUSINESS
        }

        public enum ChargeType
        {
            ONBOARDINGFEE,
            BUSINESS
        }
    }
}
