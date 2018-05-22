using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LISAdapt.Models;

namespace LISAdapt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()

        {
            var randomList = KlasificejamaKopaInit();
            var readyList = new List<Lietotajs>();
            
            foreach (var item in randomList)
            {
                KlasificetLietotaju(item);
                readyList.Add(item);
            }
            var viewModel = new LietotajuSaraksts { Saraksts = readyList };
            return View(readyList);
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
        public List<Lietotajs> ApmacibasKopaInit()
        {
            var list = new List<Lietotajs>
            {
                new Lietotajs
                {
                    SeansuSkaits = 2,
                    PavaditaisLaiksSistema = 1,
                    PalidzibasApmeklesana = 0,
                    VeiktiePasutijumi = 0,
                    AtceltiePasutijumi = 4,
                    PiesaistiKlienti = 0,
                    Klase = "K1"
                },
                new Lietotajs
                {
                    SeansuSkaits = 3,
                    PavaditaisLaiksSistema = 3,
                    PalidzibasApmeklesana = 3,
                    VeiktiePasutijumi = 0,
                    AtceltiePasutijumi = 3,
                    PiesaistiKlienti = 0,
                    Klase = "K1"
                },
                new Lietotajs
                {
                    SeansuSkaits = 3,
                    PavaditaisLaiksSistema = 4,
                    PalidzibasApmeklesana = 9,
                    VeiktiePasutijumi = 0,
                    AtceltiePasutijumi = 0,
                    PiesaistiKlienti = 0,
                    Klase = "K1"
                },
                new Lietotajs
                {
                    SeansuSkaits = 4,
                    PavaditaisLaiksSistema = 2,
                    PalidzibasApmeklesana = 0,
                    VeiktiePasutijumi = 0,
                    AtceltiePasutijumi = 0,
                    PiesaistiKlienti = 3,
                    Klase = "K1"
                },
                new Lietotajs
                {
                    SeansuSkaits = 3,
                    PavaditaisLaiksSistema = 2,
                    PalidzibasApmeklesana = 3,
                    VeiktiePasutijumi = 0,
                    AtceltiePasutijumi = 1,
                    PiesaistiKlienti = 0,
                    Klase = "K1"
                },
                new Lietotajs
                {
                    SeansuSkaits = 1,
                    PavaditaisLaiksSistema = 1,
                    PalidzibasApmeklesana = 0,
                    VeiktiePasutijumi = 1,
                    AtceltiePasutijumi = 0,
                    PiesaistiKlienti = 0,
                    Klase = "K2"
                },
                new Lietotajs
                {
                    SeansuSkaits = 3,
                    PavaditaisLaiksSistema = 1,
                    PalidzibasApmeklesana = 3,
                    VeiktiePasutijumi = 2,
                    AtceltiePasutijumi = 1,
                    PiesaistiKlienti = 0,
                    Klase = "K2"
                },
                new Lietotajs
                {
                    SeansuSkaits = 4,
                    PavaditaisLaiksSistema = 4,
                    PalidzibasApmeklesana = 6,
                    VeiktiePasutijumi = 1,
                    AtceltiePasutijumi = 3,
                    PiesaistiKlienti = 1,
                    Klase = "K2"
                },
                new Lietotajs
                {
                    SeansuSkaits = 5,
                    PavaditaisLaiksSistema = 5,
                    PalidzibasApmeklesana = 0,
                    VeiktiePasutijumi = 1,
                    AtceltiePasutijumi = 0,
                    PiesaistiKlienti = 1,
                    Klase = "K2"
                },
                new Lietotajs
                {
                    SeansuSkaits = 2,
                    PavaditaisLaiksSistema = 5,
                    PalidzibasApmeklesana = 0,
                    VeiktiePasutijumi = 1,
                    AtceltiePasutijumi = 0,
                    PiesaistiKlienti = 1,
                    Klase = "K2"
                },
                new Lietotajs
                {
                    SeansuSkaits = 5,
                    PavaditaisLaiksSistema = 5,
                    PalidzibasApmeklesana = 0,
                    VeiktiePasutijumi = 1,
                    AtceltiePasutijumi = 0,
                    PiesaistiKlienti = 1,
                    Klase = "K3"
                },
                new Lietotajs
                {
                    SeansuSkaits = 2,
                    PavaditaisLaiksSistema = 4,
                    PalidzibasApmeklesana = 0,
                    VeiktiePasutijumi = 2,
                    AtceltiePasutijumi = 1,
                    PiesaistiKlienti = 4,
                    Klase = "K3"
                },
                new Lietotajs
                {
                    SeansuSkaits = 8,
                    PavaditaisLaiksSistema = 6,
                    PalidzibasApmeklesana = 0,
                    VeiktiePasutijumi = 3,
                    AtceltiePasutijumi = 3,
                    PiesaistiKlienti = 1,
                    Klase = "K3"
                },
                new Lietotajs
                {
                    SeansuSkaits = 5,
                    PavaditaisLaiksSistema = 9,
                    PalidzibasApmeklesana = 6,
                    VeiktiePasutijumi = 7,
                    AtceltiePasutijumi = 4,
                    PiesaistiKlienti = 1,
                    Klase = "K3"
                },
                new Lietotajs
                {
                    SeansuSkaits = 4,
                    PavaditaisLaiksSistema = 10,
                    PalidzibasApmeklesana = 1,
                    VeiktiePasutijumi = 3,
                    AtceltiePasutijumi = 2,
                    PiesaistiKlienti = 8,
                    Klase = "K3"
                }
            };
            return list;
        }
        public List<Lietotajs> KlasificejamaKopaInit()
        {
            var list = new List<Lietotajs>();
            for (var i = 0; i < 15; i++)
            {
                var r = new Random();
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

        public Lietotajs KlasificetLietotaju(Lietotajs lietotajs)
        {

            var K1Balsts = 0;
            var K2Balsts = 0;
            var K3Balsts = 0;
            var apmacibasKopa = ApmacibasKopaInit();
            foreach (var item in apmacibasKopa)
            {
                if (item.SeansuSkaits - lietotajs.SeansuSkaits <= 2 && item.PalidzibasApmeklesana - lietotajs.PalidzibasApmeklesana <= 3)
                {
                    switch (item.Klase)
                    {
                        case "K1":
                            K1Balsts++;
                            break;
                        case "K2":
                            K2Balsts++;
                            break;
                        case "K3":
                            K3Balsts++;
                            break;
                    }
                }
                if (item.PavaditaisLaiksSistema - lietotajs.PavaditaisLaiksSistema <= 3 && item.AtceltiePasutijumi - lietotajs.AtceltiePasutijumi <= 1)
                {
                    switch (item.Klase)
                    {
                        case "K1":
                            K1Balsts++;
                            break;
                        case "K2":
                            K2Balsts++;
                            break;
                        case "K3":
                            K3Balsts++;
                            break;
                    }
                }
                if (item.VeiktiePasutijumi - lietotajs.VeiktiePasutijumi <= 1 && item.PiesaistiKlienti - lietotajs.PiesaistiKlienti <= 1)
                {
                    switch (item.Klase)
                    {
                        case "K1":
                            K1Balsts++;
                            break;
                        case "K2":
                            K2Balsts++;
                            break;
                        case "K3":
                            K3Balsts++;
                            break;
                    }
                }
            }
            if (K1Balsts > K2Balsts && K1Balsts > K3Balsts)
            {
                lietotajs.Klase = "K1";
            }
            else if (K2Balsts > K1Balsts && K2Balsts > K3Balsts)
            {
                lietotajs.Klase = "K2";
            }
            else
            {
                lietotajs.Klase = "K3";
            }
            return lietotajs;
        }
    }
    
}
