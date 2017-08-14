using System.Collections.Generic;

namespace SimpleNetCore.Data
{
    public class Tag : ConferenceDTO.Tag
    {
        public virtual ICollection<SessionTag> SessionTags { get; set; }
    }
}
