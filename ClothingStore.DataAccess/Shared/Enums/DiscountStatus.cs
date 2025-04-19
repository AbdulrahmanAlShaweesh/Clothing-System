 

namespace ClothingStore.Domain.Enums
{
    [Flags]
    public enum DiscountStatus : byte
    {
        None = 0,
        Discounted = 1,
        OnSale = 2,
        Clearance = 4, 
    }
}
