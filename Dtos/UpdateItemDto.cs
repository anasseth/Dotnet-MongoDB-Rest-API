using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateItemDto
    {
        [Required]
        public Guid Id { get; init; }
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(1, 1000)]
        public double? Price { get; init; }
    }
}