using System;

namespace Catalog.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public double? Price { get; init; }
        public DateTimeOffset CreationDate { get; init; }
    }
}