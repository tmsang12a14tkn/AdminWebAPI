using Data.Manage.Entities;
using Data.Manage.Helpers;
using Data.Manage.Models;
using Microsoft.AspNetCore.Identity;
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
    public interface IOrderDetailService
    {
        IEnumerable<OrderDetails> GetAll();
        void SaveChanges();
    }

    public class OrderDetailService : IOrderDetailService
    {
        private readonly NinjaSaiGonContext context;
        public OrderDetailService(NinjaSaiGonContext context)
        {
            this.context = context;
        }

        public IEnumerable<OrderDetails> GetAll()
        {
            return context.OrderDetails;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
