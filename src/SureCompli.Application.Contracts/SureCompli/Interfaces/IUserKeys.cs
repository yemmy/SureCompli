using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SureCompli.SureCompli.Interfaces
{
   
    public interface IUserKeys :
      ICrudAppService< //Defines CRUD methods
          UserKeyDto, //Used to show data
          Guid, //Primary key
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          UserKeyDto> //Used to create/update an entry
    {
       
    }
}
