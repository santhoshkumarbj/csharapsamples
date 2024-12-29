using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout
{
    /// <summary>
    /// Request dto for Get EventChat
    /// </summary>
    public class EventChatQueryDto
    {
        [JsonProperty(PropertyName = "EventId")]
        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        /// <value>
        /// The event identifier.
        /// </value>
        public int EventId { get; set; }
    }


    public class GetUsersByUserIdsRequestDto
    {
        public List<int> UserIds { get; set; }
    }

}
