using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using Openpay;
using Openpay.Entities;
using Openpay.Entities.Request;

namespace OpenpayNet.Controllers
{
    public class OpenpayController : Controller
    {
        // 


        public IActionResult Index()
        {
            return View();
        }

        // 
        [HttpPost]

        public IActionResult Openpaycard(string token, string deviceSessionId)
        {
            Random r = new Random();
        
            OpenpayAPI openpayAPI = new OpenpayAPI("Llave secreta", "Merchant ID", "PE", false);

            ChargeRequest newCharge = new ChargeRequest();
            newCharge.Method = "card";
            newCharge.SourceId = token;
            newCharge.Amount = 100;
            newCharge.Currency = "PEN";
            newCharge.Description = "Cargo de prueba";
            newCharge.OrderId = "Pago_"+r.Next(1,1000);
            newCharge.DeviceSessionId = deviceSessionId;

            Customer customer = new Customer();
            customer.Name = "Cliente Perú";
            customer.LastName = "Vazquez Juarez";
            customer.PhoneNumber = "4448936475";
            customer.Email = "juan.vazquez@empresa.pe";
            newCharge.Customer = customer;

            Charge charge = openpayAPI.ChargeService.Create(newCharge);

            return View();

        }
        

        public IActionResult Welcome(string name, int numTimes = 1)
        {

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }
    }
}