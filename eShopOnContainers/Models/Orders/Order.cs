﻿using System.Text.Json.Serialization;

namespace eShopOnContainers.Models.Orders;

public class Order
{
    public Order()
    {
        SequenceNumber = 1;
        OrderItems = new List<OrderItem>();
    }

    public string BuyerId { get; set; }

    public int SequenceNumber { get; set; }

    [JsonPropertyName("date")]
    public DateTime OrderDate { get; set; }

    [JsonPropertyName("status")]
    public OrderStatus OrderStatus { get; set; }

    [JsonPropertyName("city")]
    public string ShippingCity { get; set; }

    [JsonPropertyName("street")]
    public string ShippingStreet { get; set; }

    [JsonPropertyName("state")]
    public string ShippingState { get; set; }

    [JsonPropertyName("country")]
    public string ShippingCountry { get; set; }

    [JsonPropertyName("zipCode")]
    public string ShippingZipCode { get; set; }

    public int CardTypeId { get; set; }

    public string CardNumber { get; set; }

    public string CardHolderName { get; set; }

    public DateTime CardExpiration { get; set; }

    public string CardSecurityNumber { get; set; }

    [JsonPropertyName("orderitems")]
    public List<OrderItem> OrderItems { get; set; }

    [JsonPropertyName("total")]
    public decimal Total { get; set; }

    [JsonPropertyName("ordernumber")]
    public int OrderNumber { get; set; }
}