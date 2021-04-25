using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SureCompli.SureCompli.Interfaces
{
   
    public interface IRegulations :
      ICrudAppService< //Defines CRUD methods
          RegulationDto, //Used to show data
          Guid, //Primary key
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          RegulationDto> //Used to create/update an entry
    {
       
    }
}
