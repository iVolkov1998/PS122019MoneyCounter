using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Anisimov
{
    public class VideoComment
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public string Text { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public Video Video { get; set; }
    }
}
