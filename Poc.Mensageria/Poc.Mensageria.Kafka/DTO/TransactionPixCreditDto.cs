using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Mensageria.Kafka.DTO
{
    internal record TransactionPixCreditDto(Guid GuidTransaction, Decimal ValeuTransaction, string NameFull, byte Quantity = 1);
     
}
