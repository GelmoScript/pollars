using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.Models
{
    public class Poll : BaseEntity
    {
        public string Title { get; set; }
        public int QuestionCount { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<User> Applicants { get; set; }
    }
}
