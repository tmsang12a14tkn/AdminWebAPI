using Data.Manage.Entities;
using Data.Manage.Helpers;
using Data.Manage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Repo.Manage;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Service.Manage
{
    public interface IOrderService
    {
        IEnumerable<Orders> GetAll();
        void SaveChanges();
    }

    public class OrderService : IOrderService
    {
        private readonly NinjaSaiGonContext context;
        public OrderService(NinjaSaiGonContext context)
        {
            this.context = context;
        }

        public IEnumerable<Orders> GetAll()
        {
            return context.Orders;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
