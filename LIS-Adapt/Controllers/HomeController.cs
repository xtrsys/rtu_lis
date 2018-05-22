using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIS_Adapt.Models;

namespace LIS_Adapt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //seasnsu skaits
        //pavaditais laiks sistema
        //palidzibas apmeklesana
        //veikto pasutiju skaits
        //atcelto pasutiju skaits
        //piesaistito klientu skaits

        //k1 potencials klients        //k2 klients, ar vismaz 1 pasutiju                       //k3 patstavigais klients
        //reklamas                  radas specialie piedavajumi     radas piedavajumi balstoties uz ieprieksejo pirkumu     neradas
        //pasutijumu noformesana    tiek veiktas visas parbaudes    parbaude vai izmantoto tos pasus datus                  parbaudes netiek veiktas
        //produktu apraksts         radas galvena specifikacija     radas galvena specifikacija                             radas pilna produktu specifikacija
        //atlaides                  nav atlaide                     sakotneja atlaide                                       atlaide balstoties uz veiktiem pirkumiem un piesaisitiem klientiem
        public List<Lietotajs> apmacibasKopaInit()
        {
            var list = new List<Lietotajs>();
            list.Add(new Lietotajs
            {
                SeansuSkaits = 2,
                PavaditaisLaiksSistema = 1,
                PalidzibasApmeklesana = 0,
                VeiktiePasutijumi = 0,
                AtceltiePasutijumi = 4,
                PiesaistiKlienti = 0,
                Klase = "K1"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 3,
                PavaditaisLaiksSistema = 3,
                PalidzibasApmeklesana = 3,
                VeiktiePasutijumi = 0,
                AtceltiePasutijumi = 3,
                PiesaistiKlienti = 0,
                Klase = "K1"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 3,
                PavaditaisLaiksSistema = 4,
                PalidzibasApmeklesana = 9,
                VeiktiePasutijumi = 0,
                AtceltiePasutijumi = 0,
                PiesaistiKlienti = 0,
                Klase = "K1"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 4,
                PavaditaisLaiksSistema = 2,
                PalidzibasApmeklesana = 0,
                VeiktiePasutijumi = 0,
                AtceltiePasutijumi = 0,
                PiesaistiKlienti = 3,
                Klase = "K1"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 3,
                PavaditaisLaiksSistema = 2,
                PalidzibasApmeklesana = 3,
                VeiktiePasutijumi = 0,
                AtceltiePasutijumi = 1,
                PiesaistiKlienti = 0,
                Klase = "K1"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 1,
                PavaditaisLaiksSistema = 1,
                PalidzibasApmeklesana = 0,
                VeiktiePasutijumi = 1,
                AtceltiePasutijumi = 0,
                PiesaistiKlienti = 0,
                Klase = "K2"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 3,
                PavaditaisLaiksSistema = 1,
                PalidzibasApmeklesana = 3,
                VeiktiePasutijumi = 2,
                AtceltiePasutijumi = 1,
                PiesaistiKlienti = 0,
                Klase = "K2"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 4,
                PavaditaisLaiksSistema = 4,
                PalidzibasApmeklesana = 6,
                VeiktiePasutijumi = 1,
                AtceltiePasutijumi = 3,
                PiesaistiKlienti = 1,
                Klase = "K2"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 5,
                PavaditaisLaiksSistema = 5,
                PalidzibasApmeklesana = 0,
                VeiktiePasutijumi = 1,
                AtceltiePasutijumi = 0,
                PiesaistiKlienti = 1,
                Klase = "K2"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 2,
                PavaditaisLaiksSistema = 5,
                PalidzibasApmeklesana = 0,
                VeiktiePasutijumi = 1,
                AtceltiePasutijumi = 0,
                PiesaistiKlienti = 1,
                Klase = "K2"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 5,
                PavaditaisLaiksSistema = 5,
                PalidzibasApmeklesana = 0,
                VeiktiePasutijumi = 1,
                AtceltiePasutijumi = 0,
                PiesaistiKlienti = 1,
                Klase = "K3"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 2,
                PavaditaisLaiksSistema = 4,
                PalidzibasApmeklesana = 0,
                VeiktiePasutijumi = 2,
                AtceltiePasutijumi = 1,
                PiesaistiKlienti = 4,
                Klase = "K3"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 8,
                PavaditaisLaiksSistema = 6,
                PalidzibasApmeklesana = 0,
                VeiktiePasutijumi = 3,
                AtceltiePasutijumi = 3,
                PiesaistiKlienti = 1,
                Klase = "K3"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 5,
                PavaditaisLaiksSistema = 9,
                PalidzibasApmeklesana = 6,
                VeiktiePasutijumi = 7,
                AtceltiePasutijumi = 0,
                PiesaistiKlienti = 1,
                Klase = "K3"
            });
            list.Add(new Lietotajs
            {
                SeansuSkaits = 4,
                PavaditaisLaiksSistema = 12,
                PalidzibasApmeklesana = 1,
                VeiktiePasutijumi = 3,
                AtceltiePasutijumi = 0,
                PiesaistiKlienti = 8,
                Klase = "K3"
            });
            return list;
        }
        public List<Lietotajs> klasificejamaKopaInit()
        {
            var list = new List<Lietotajs>();
            for (int i = 0; i < 15; i++)
            {
                Random r = new Random();
                list.Add(new Lietotajs
                {
                    SeansuSkaits = r.Next(0, 10),
                    PavaditaisLaiksSistema = r.Next(0, 10),
                    PalidzibasApmeklesana = r.Next(0, 10),
                    VeiktiePasutijumi = r.Next(0, 10),
                    AtceltiePasutijumi = r.Next(0, 10),
                    PiesaistiKlienti = r.Next(0, 10),
                });
            }
            return list;
        }

    }
    public class Lietotajs
    {
        public int SeansuSkaits { get; set; }
        public int PavaditaisLaiksSistema { get; set; }
        public int PalidzibasApmeklesana { get; set; }
        public int VeiktiePasutijumi { get; set; }
        public int AtceltiePasutijumi { get; set; }
        public int PiesaistiKlienti { get; set; }
        public string Klase { get; set; }
    }
}
