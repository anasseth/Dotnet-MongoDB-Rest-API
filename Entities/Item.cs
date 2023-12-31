using System;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public double? Price { get; init; }
        public DateTimeOffset CreationDate { get; init; }
    }
}