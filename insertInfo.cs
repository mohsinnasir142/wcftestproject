using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Communicator
{
    public class insertInfo
    {

        [DataMember]
        public string insertId { get; set; }

        [DataMember]
        public string insertName { get; set; }

    }
}