using System.Collections.Generic;

namespace Pollars.Dtos
{
    public class PollDto : BaseDto
    {
        public string Title { get; set; }
        public int QuestionCount { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
        public List<UserDto> Applicants { get; set; }
    }
}
