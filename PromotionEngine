public class Sku
{
  public char SkuId{get;set;}
  public decimal Price{get;set;}
  public Sku(char skuId, decimal price)
  {
    SkuId=skuId;
    Price=price;
  }
} 

public class CartSku:Sku
{
  public int Units{get;set;}
  public bool IsPromotionApplied{get;set;}
  public CartSku(char skuId, decimal price, int units): base(skuId, price)
  {
    Units=units;
    IsPromotionApplied=false;
  }
}

public class Stock
{
  public List<Sku> Skus{get;set;}
}

public class Cart
{
  public List<CartSku> Skus{get;set;}
  public decimal TotalValue{get;set;}
}

public interface IPromotion
{
  Cart Apply(Cart cart)
}

public class PromotionTypeA: IPromotion
{
  public int Units{get;set;}
  public Sku Sku {get;set;}
  public PromotionTypeA(int units, Sku sku)
  {
    Units=units;
    Sku=sku;
  }
  public Cart Apply(Cart cart)
  {
    int skuIndex=cart.Skus.FindIndex(s=>s.SkuId==Sku.SkuId);
    if(skuIndex>=0)
    {
      cart.Skus[skuIndex].IsPromotionApplied = true;
      cart.TotalValue=cart.TotalValue + ((cart.Skus[skuIndex].Units/Units)*Sku.Price)+((cart.Skus[skuIndex].Units%Units)*cart.Skus[skuIndex].Price);
    }
    return cart;
  }
}

public class PromotionEngine
{
  public List<IPromotion> Promotions{get;set;}
  public Stock Stock{get;set;}
  public PromotionsEngin(Stock stock, List<IPromotion> promotions)
  {
    Stock=stock;
    Promotions=promotions;
  }
  public decimal applyPromotions(Cart cart)
  {
    foreach(var promotion in Promotions)
    {
      promotion.Appy(cart);
    }
    return cart.TotalValue;
}
