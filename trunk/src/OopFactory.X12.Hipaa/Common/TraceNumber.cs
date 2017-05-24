using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OopFactory.X12.Hipaa.Common
{
    public class TraceNumber
    {
        public Lookup Type { get; set; }
        [XmlAttribute]
        public string OriginatingCompanyIdentifier { get; set; }
        [XmlAttribute]
        public string Id { get; set; }
    }
}