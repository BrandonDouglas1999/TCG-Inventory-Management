using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    internal class ShoppingCart
    {
        public List<Card> cart;

        public ShoppingCart()
        {
            cart = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cart.Add(card);
        }

        public void DeleteCard(Card card)
        {
            cart.Remove(card);
        }

        public void Clear()
        {
            cart.Clear();
        }

        public List<Card> GetCart()
        {
            return cart;
        }

        public Card ViewCart(int index)
        {
            return cart[index];
        }
    }
}
