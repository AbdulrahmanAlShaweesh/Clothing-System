 

namespace ClothingStore.DataAccess.Shared.Classess
{
    public class BaseEntity
    { 
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool IsDeleted  { get; set; }                        // Soft Delete
    }
}
