using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.Models.Questions
{
    public class Question : BaseEntity
    {
        public int PollId { get; set; }
        public string QuestionText { get; set; }
        public virtual Poll Poll { get; set; }
    }
}
