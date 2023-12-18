using SynthMania.Models;

namespace SynthMania;

public class ShoppingCartState
{
    public event EventHandler<CartChangedEventArgs> CartChanged;

    public List<Product> ShoppingCart { get; set; } = new List<Product>();

    public int Count => ShoppingCart.Count;

    public decimal TotalPrice => ShoppingCart.Sum(product => product.Price);


    public void AddProduct(Product product)
    {
        ShoppingCart.Add(product);

        CartChanged?.Invoke(this, new CartChangedEventArgs() { Added = true });

    }

    public void RemoveProduct(Product product)
    {
        ShoppingCart.Remove(product);

        CartChanged?.Invoke(this, new CartChangedEventArgs() { Added = false });
    }

    public void CompletePurchase()
    {
        ShoppingCart.Clear();

        CartChanged?.Invoke(this, new CartChangedEventArgs() { Added = false });
    }
}

public class CartChangedEventArgs : EventArgs
{
    public bool Added { get; set; }
}