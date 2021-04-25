using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SureCompli.SureCompli.Interfaces
{
   
    public interface IBlockChain :
      ICrudAppService< //Defines CRUD methods
          BlockChainDto, //Used to show data
          Guid, //Primary key
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          BlockChainDto> //Used to create/update an entry
    {
       
    }
}
