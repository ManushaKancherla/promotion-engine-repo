[TestClass]
public class PromotionEngineTest
{
  [TestMethod]
  public void TestMethod()
  {
    var stock = new Stock(){Skus=new List<Sku>(){new Sku('A',50),new Sku('B',30),new Sku('C',20),new Sku('D',15)}};
    var cart = new Cart(){Skus=new List<CartSku>(){new CartSku('A',50,4),new CartSku('B',30,3)}};
    var promotion1 = new PromotionTypeA(3, new Sku('A',130));
    var promotion2 = new PromotionTypeA(2, new Sku('B',45));
    var engine = new PromotionEngine(stock, new List<IPromotion>(){promotion1,promotion2});
    Assert.AreEqual(engine.applyPromotions(cart),255);
  }
}
