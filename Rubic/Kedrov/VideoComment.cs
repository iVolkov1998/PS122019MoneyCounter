using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Kedrov
{
    public class VideoComment
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public string Text { get; set; }
        public DateTimeOffset DateTimeStamp { get; set; }
        public Video Video { get; set; }
    }
}
