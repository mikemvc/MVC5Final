using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5Final.Models
{
    public class DbFile
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public int Size { get; set; }
        public string MimeType { get; set; }        
        public byte[] Content { get; set; }
    }
}