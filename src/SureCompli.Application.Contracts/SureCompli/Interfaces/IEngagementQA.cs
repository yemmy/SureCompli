using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SureCompli.SureCompli.Interfaces
{
   
    public interface IEngagementQA :
      ICrudAppService< //Defines CRUD methods
          EngagementQADto, //Used to show data
          Guid, //Primary key
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          EngagementQADto> //Used to create/update an entry
    {
       
    }
}
