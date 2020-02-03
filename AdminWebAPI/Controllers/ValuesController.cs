using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminWebAPI.Entities;
using AdminWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AdminWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private NinjaSaiGonContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public ValuesController(NinjaSaiGonContext context, UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet("[action]")]
        public List<OrderSources> GetOrderSources()
        {
            return _context.OrderSources.ToList();
        }

        [HttpGet("[action]")]
        public List<Agencies> GetAgencies()
        {
            return _context.Agencies.ToList();
        }

        [HttpGet("[action]")]
        public IEnumerable<Object> GetPhones()
        {
            return (from p in _context.ContactPhones
                    select new { p.Id, p.PhoneNumber, p.ContactInfoId });
        }

        [HttpGet("[action]")]
        public IEnumerable<Object> GetAddresses()
        {
            return (from p in _context.ContactAddresses
                    select new { p.Id, p.MoreInfo, p.ContactInfoId });
        }

        [HttpGet("[action]")]
        public IEnumerable<Object> GetPersons()
        {
            return (from p in _context.Persons
                    where p.PersonType == 1
                    select new { p.Id, p.PrimaryName, p.Code });
        }

        [HttpGet("[action]")]
        public List<Orders> GetOrderForUpdateSource()
        {
            var query = _context.Orders.Where(o => !o.IsDeleted && o.PhoneNumber.Trim().Length >= 10 && o.OrderSourceId == null)
                                        .ToList();
            return query;
        }

        [HttpGet("[action]")]
        public List<Orders> GetOrdersForUpdate()
        {
            var query = _context.Orders.Where(o => !o.IsDeleted && o.PhoneNumber.Trim().Length >= 10 && o.AgencyId == null && o.CustomerId == null)
                                        .ToList();
            return query;
        }



        [HttpGet("[action]")]
        public List<Orders> GetOrders()
        {
            var query = _context.Orders.Where(o => !o.IsDeleted && o.PhoneNumber.Trim().Length >= 10)
                                        .GroupBy(u => u.PhoneNumber)
                                        .Select(grp => grp.ToList())
                                        .ToList();
            List<Orders> lstTemp = new List<Orders>();
            foreach (List<Orders> order in query)
                lstTemp.Add(order[0]);

            return lstTemp.OrderBy(o => o.AddressLine).ToList();
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public List<Orders> GetOrdersByPhoneNumber([FromBody] OrderEnt model)
        {
            var query = _context.Orders.Where(o => !o.IsDeleted && o.PhoneNumber == model.phone && o.AgencyId == null && o.CustomerId == null)
                                        .ToList();
            return query;
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public IActionResult UpdateOrderCustomerAgency([FromBody] UpdateOrderCustomerEnt model)
        {
            if(model.id == null)
                return Ok(new { code = 0 });
            if (model.orders.Count <= 0)
                return Ok(new { code = -1 });
            foreach (var order in model.orders)
            {
                var obj = _context.Orders.Where(o => o.OrderId == order.OrderId).FirstOrDefault();
                if(model.agencyType == 0)//khach hang
                    obj.CustomerId = model.id;
                else if((model.agencyType == 1))//dai ly
                    obj.AgencyId = model.id;
                _context.SaveChanges();
            }
            return Ok(new { code = 1 });
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public IActionResult UpdateOrderSource([FromBody] UpdateOrderCustomerEnt model)
        {
            if (model.id == null)
                return Ok(new { code = 0 });
            if (model.orders.Count <= 0)
                return Ok(new { code = -1 });
            foreach (var order in model.orders)
            {
                var obj = _context.Orders.Where(o => o.OrderId == order.OrderId).FirstOrDefault();
                obj.OrderSourceId = model.id;
                _context.SaveChanges();
            }
            return Ok(new { code = 1 });
        }

        [HttpPost("[action]")]
        [AllowAnonymous]
        public Object GetQuantityDrinkForChart([FromBody] ChartModelParam model)
        {
            if (model.from == null)
                model.from = new DateTime(2018, 9, 1);
            if (model.to == null)
                model.to = DateTime.Now.AddMonths(1);
            var query = _context.Orders.Where(o => !o.IsDeleted && o.OrderPlaced >= model.from && o.OrderPlaced <= model.to)
                .Join(_context.OrderDetails, o => o.OrderId, od => od.OrderId, (o, od) => new { o, od })
                .Join(_context.Drinks, ood => ood.od.DrinkId, d => d.Id, (ood, d) => new { ood, d })
                .Join(_context.DrinkCategories, oodd => oodd.d.CategoryId, dc => dc.Id, (oodd, dc) => new { oodd, dc })
                .Where(w => w.oodd.d.CategoryId == model.category && w.oodd.d.IsActive)
                .GroupBy(gb => new { gb.oodd.d.CategoryId, gb.oodd.ood.o.OrderPlaced.Month, gb.oodd.ood.o.OrderPlaced.Year, gb.oodd.ood.od.DrinkName, gb.oodd.ood.od.DrinkId })
                .Select(grp => new
                {
                    CategoryId = grp.Key.CategoryId,
                    Quantity = grp.Sum(grps => grps.oodd.ood.od.Quantity),
                    DrinkName = grp.Key.DrinkName,
                    DrinkId = grp.Key.DrinkId,
                    Month = grp.Key.Month,
                    Year = grp.Key.Year,
                })
                .OrderBy(o => o.Year).ThenBy(m => m.Month)
                .GroupBy(gb2 => new { gb2.DrinkId, gb2.DrinkName })
                .ToList();
            ChartCategoryInfoEnt infos = new ChartCategoryInfoEnt();
            for (var begin = model.from; begin <= model.to; begin = begin.AddMonths(1))
            {
                infos.labelDates.Add(begin.Month.ToString() + "/" + begin.Year.ToString());
                infos.labelDatesDT.Add(begin);
            }


            foreach (var q in query)
            {
                ChartDataEnt chartData = new ChartDataEnt();
                chartData.label = q.Key.DrinkName;
                if (q.Count() > 0)
                {
                    foreach (var y in infos.labelDatesDT)
                    {
                        var obj = q.Where(l => l.Month == y.Month && l.Year == y.Year).FirstOrDefault();
                        if (obj == null)
                            chartData.data.Add(0);
                        else
                            chartData.data.Add(obj.Quantity);
                    }
                    infos.chartDatas.Add(chartData);
                }
            }
            return infos;
        }



        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2", "value3" };
        }

        // GET api/values/5
        [HttpGet("[action]")]
        public IEnumerable<Object> GetDrinkCategories()
        {
            return (from dc in _context.DrinkCategories
                    select new { dc.Id, dc.Name });
        }



        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
