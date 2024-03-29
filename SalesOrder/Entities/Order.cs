﻿using System;
using System.Collections.Generic;
using SalesOrder.Entities.Enums;

namespace SalesOrder.Entities
{
    class Order
    {
        public int id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Customer Costumer { get; set; }
        public List<OrderItem> Items = new List<OrderItem>();

        public Order() { }

        public Order(int id, DateTime moment, OrderStatus status, Customer costumer)
        {
            this.id = id;
            Moment = moment;
            Status = status;
            Costumer = costumer;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            return id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
