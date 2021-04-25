using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SureCompli.SureCompli.Interfaces
{
   
    public interface IRegulationQuestions :
      ICrudAppService< //Defines CRUD methods
          RegulationQuestionDto, //Used to show data
          Guid, //Primary key
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          RegulationQuestionDto> //Used to create/update an entry
    {
       
    }
}
