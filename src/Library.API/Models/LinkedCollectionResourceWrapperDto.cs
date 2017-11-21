using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.API.Models
{
    /// <summary>
    /// HATEOAS - Staticly typed approch using a wrapper class to generate the links.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedCollectionResourceWrapperDto<T> : LinkedResourceBaseDto
        where T : LinkedResourceBaseDto
    {
        public IEnumerable<T> Value { get; set; }

        public LinkedCollectionResourceWrapperDto(IEnumerable<T> value)
        {
            Value = value;
        }

    }
}
