using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.Dtos
{
    public class QuestionDto : BaseDto
    {
        public int PollId { get; set; }
        public string QuestionText { get; set; }
        public PollDto Poll { get; set; }
    }
}
