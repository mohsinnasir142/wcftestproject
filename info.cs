using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Communicator
{
    [DataContract]
    public partial class info
    {
        
   
        [DataMember]
        public string Cid { get; set; }

        [DataMember]
        public string Cname { get; set; }
    }
}