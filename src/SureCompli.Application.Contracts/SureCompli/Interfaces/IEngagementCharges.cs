using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SureCompli.SureCompli.Interfaces
{
   
    public interface IEngagementCharges :
      ICrudAppService< //Defines CRUD methods
          EngagementChargeDto, //Used to show data
          Guid, //Primary key
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          EngagementChargeDto> //Used to create/update an entry
    {
       
    }
}
