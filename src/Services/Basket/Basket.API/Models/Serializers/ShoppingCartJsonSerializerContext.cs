using System.Text.Json.Serialization;

namespace Basket.API.Models.Serializer
{
    [JsonSerializable(typeof(ShoppingCart))]
    internal partial class ShoppingCartJsonSerializerContext : JsonSerializerContext
    { }
}
