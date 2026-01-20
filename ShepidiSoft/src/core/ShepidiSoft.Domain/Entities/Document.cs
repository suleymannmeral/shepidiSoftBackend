using ShepidiSoft.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShepidiSoft.Domain.Entities
{
    public sealed class Document : BaseEntity<int>
    {
        public int DocumentTopicId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string FileUrl { get; set; } = null!;
        public DateTime PublishedAt { get; set; }
        public string UploadedByUserId { get; set; } = null!;

        //// Navigation Properties
        //public DocumentTopic DocumentTopic { get; set; } = null!;
    }
}
