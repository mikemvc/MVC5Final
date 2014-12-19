﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Final.Models
{
    public class GuestTable
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        // 新增 Email
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateTime PostDateTime { get; set; }
        // 加入檔案上傳        
        public string Name { get; set; }
        public int Size { get; set; }
        public string MimeType { get; set; }
        public byte[] FContent { get; set; }
        // 新增 approval
        public bool approval { get; set; }
    }
}