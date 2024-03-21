#nullable disable

using ShipEngineSDK.Common;
using ShipEngineSDK.Common.Enums;
using System;
using System.Collections.Generic;

namespace ShipEngineSDK.ListSalesOrder
{
    /// <summary>
    /// List Carrier Results
    /// </summary>
    public class Result
    {
        public List<SalesOrder> SalesOrders { get; set; }
        public int Total { get; set; }
    }

    public class SalesOrder
    {
        public string SalesOrderId { get; set; }
        public string ExternalOrderId { get; set; }
        public string ExternalOrderNumber { get; set; }
        public OrderSource OrderSource { get; set; }
        public SalesOrderStatus SalesOrderStatus { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        public Customer Customer { get; set; }
        public BillTo BillTo { get; set; }
        public Address ShipTo { get; set; }
        public SalesOrderItems SalesOrderItems { get; set; }
    }

    public class SalesOrderItems
    {
        public string SalesOrderItemId { get; set; }
        public List<LineItemDetails> LineItemDetails { get; set; }
    }

    public class LineItemDetails
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public Weight Weight { get; set; }
        public Address ShipTo { get; set; }
        public RequestedShippingOptions RequestedShippingOptions { get; set; }
        public PriceSummary PriceSummary { get; set; }
        public int Quantity { get; set; }
        public bool IsGift { get; set; }
    }

    public class PriceSummary
    {
        public MonetaryValue UnitPrice { get; set; }
        public MonetaryValue EstimatedTax { get; set; }
        public string EstimatedShipping { get; set; }
        public MonetaryValue Total { get; set; }
    }

    public class RequestedShippingOptions
    {
        public string ShippingSerive { get; set; }
        public DateTime? ShipDate { get; set; }
    }

    public class BillTo
    {
        public string Email { get; set; }
        public Address Address { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class PaymentDetails
    {
        public MonetaryValue Subtotal { get; set; }
        public MonetaryValue EstimatesShipping { get; set; }
        public MonetaryValue EstimatesTax { get; set; }
        public MonetaryValue GrandTotal { get; set; }
    }

    public class SalesOrderStatus
    {
        public string PaymentStatus { get; set; }
        public string FulfillmentStatus { get; set; }
        public bool IsCancelled { get; set; }
    }

    public class OrderSource
    {
        public string OrderSourceId { get; set; }
        public string OrderSourceNickname { get; set; }
        public string OrderSourceCode { get; set; }
        public string OrderSourceFriendlyName { get; set; }
        public RefreshInfo RefreshInfo { get; set; }
        public bool Active { get; set; }
    }
    public class RefreshInfo
    {
        public string Status { get; set; }
        public string LastRefreshAttempt { get; set; }
        public string RefreshDate { get; set; }
    }


}