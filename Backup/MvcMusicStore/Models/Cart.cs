using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { set; get; }
        public string CartId { set; get; }
        public int AlbumId { set; get; }
        public int Count { set; get; }
        public System.DateTime DateCreated { set; get; }
        public virtual Album Album { set; get; }
    }
}