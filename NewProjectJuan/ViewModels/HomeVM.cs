using Core.Entities;

namespace NewProjectJuan.ViewModels;

public class HomeVM
{
    public IEnumerable<SlideItem> SlideItems { get; set; } = null!;
public IEnumerable<ShippingItem> ShippingItems { get; set; } = null!;   

}
