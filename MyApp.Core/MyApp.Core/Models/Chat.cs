using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Models
{
    class Chat
    {
        public string MessageId { get; set; }

        [StringLength(40)]
        public string Subject { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public Chat()
        {
            //Adding flexability to what tech databases I can use. 
            //rather than letting it auto generate
            this.MessageId = Guid.NewGuid().ToString();
        }
    }
}
