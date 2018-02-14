using Newtonsoft.Json;
using System;

namespace DShop.Messages.Commands.Products
{
	public class CreateProduct : ICommand
	{
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string Vendor { get; }
        public decimal Price { get; }
        
        [JsonConstructor]
        private CreateProduct(Guid? id, string name, string description, string vendor, decimal price)
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            Description = description;
            Vendor = vendor;
            Price = price;
        }
	}
}