using Domain.Model.ENUM;
using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Application.DTO
{
    public class ApplicationDTO
    {
        public int Id { get; set; }
        public string IIN { get; set; }
        public int Score { get; set; }
        public College College { get; set; }
        public Profile Profile1 { get; set; }
        public Profile Profile2 { get; set; }
    }
}
