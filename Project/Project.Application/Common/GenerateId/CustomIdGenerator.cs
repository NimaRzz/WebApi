using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Application.Common.Validations.Common;
using Project.Domain.Common.Dto;


namespace Project.Application.Common.GenerateId
{
    public class CustomIdGenerator
    {
        public static async Task<string> GenerateId<T1, T2>(T1 value1, T2 value2)
        {
           
               long id1 = Convert.ToInt64(value1);
               long id2 = Convert.ToInt64(value2);
         
            string Id = null;

            if (id1 < 10 && id2 < 10)
            {
                Id = $"0{id1}0{id2}";
            }
            else if (id1 >= 10 && id2 >= 10)
            {
                Id = $"{id1}{id2}";
            }
            else if (id1 < 10 && id2 >= 10)
            {
                Id = $"0{id1}{id2}";
            }
            else if (id1 >= 10 && id2 < 10)
            {
                Id = $"{id1}0{id2}";
            }

            return Id;
        }
    }
}
