using System;
using System.Collections.Generic;
using System.Text;

namespace SureCompli.SureCompli.BlockChain
{
    public class CreateAccountDto
    {
        public string UserEmail { get; set; }
        public string Passphrase { get; set; }
    }

    public class AccountResultDto
    {
        public string UserEmail { get; set; }
        public string Address { get; set; }
        public string Sk { get; set; }
        public string Pk { get; set; }
    }

    /*
     
    geth --datadir "$ethereum_home/EthMasterChain" --networkid 5657 --rpc --rpcapi db,eth,net,web3,personal --cache=1024 --rpcport 8545 --rpcaddr 127.0.0.1 --rpccorsdomain "*"

    geth --rpc --rpcport 8585 --rpccorsdomain "*" console --gcmode archive

    geth --rpc --rpcport 8585 --rpccorsdomain "*" --gcmode archive

    geth --rpc --rpccorsdomain "http://localhost:8000" --rpcaddr="localhost" console --gcmode archive
     
     */
}
