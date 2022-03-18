﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BookStore.Server.BLL.Models
{
    public class OrderModel
    {
        public OrderModel()
        {
            CartItems = new List<CartItemModel>();
            OrderDate = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [JsonPropertyName("total")]
        public decimal Total { get; set; }

        public List<CartItemModel> CartItems { get; set; }

    }
}
