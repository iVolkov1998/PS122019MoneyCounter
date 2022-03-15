using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Ovchinnikov
{
    public class VideoComment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateTimeStamp { get; set; }

        public int VideoId { get; set; }
        public Video Video { get; set; }
    }
}
