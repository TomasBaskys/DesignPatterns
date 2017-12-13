using System.Collections.Generic;

namespace Prototype
{
    public class Supermarket
    {
        private readonly Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

        public void AddProduct(string key, ProductPrototype productPrototype)
        {
            _productList.Add(key, productPrototype);
        }

        public ProductPrototype GetProduct(string key)
        {
            ProductPrototype product = _productList[key];

            return product.Clone();
        }
    }
}