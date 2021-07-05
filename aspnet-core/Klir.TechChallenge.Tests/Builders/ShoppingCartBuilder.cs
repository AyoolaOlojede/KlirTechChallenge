using Klir.TechChallenge.Core.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Klir.TechChallenge.Tests.UnitTests.Builders
{
    public class ShoppingCartBuilder
    {
        private ShoppingCart shoppingCart;
        public int Id => 1;
        public ShoppingCartBuilder()
        {
            shoppingCart = ShoppingCartWithoutItems();
        }

        public ShoppingCart ShoppingCartWithoutItems()
        {
            var shoppingCartMock = new Mock<ShoppingCart>();
            shoppingCartMock.SetupGet(s => s.Id).Returns(Id);

            shoppingCart = shoppingCartMock.Object;
            return shoppingCart;
        }

        public ShoppingCart ShoppingCartWithOneItem()
        {
            var shoppingCartMock = new Mock<ShoppingCart>();
            shoppingCart = shoppingCartMock.Object;
            shoppingCart.AddCartItem(1, 50, 1);
            return shoppingCart;
        }

    }
}
