using Domain.Model.ENUM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamAspNetApi.App.Application.Commands.Update
{
    public class UpdateApplicationCommand
    {
        public int Id { get; set; }
        public string IIN { get; set; }
        public int Score { get; set; }
        public College College { get; set; }
        public Profile Profile1 { get; set; }
        public Profile Profile2 { get; set; }
    }
}
