using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _5951071031_Ha_Nhat_Huy.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name ="hoten")]
        public string Hoten { get; set; }
        [DataMember(Name = "mssv")]
        public string MaSoSv { get; set; }
        [DataMember(Name = "lop")]
        public string Lop { get; set; }
        [DataMember(Name = "ngaySinh")]
        public DateTime NgaySinh { get; set; }


    }
}