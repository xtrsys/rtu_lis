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
            var prezicitate = new SalidzinasasPrecizitate
            {
                p1 = 2,
                p2 = 3,
                p3 = 3,
                p4 = 1,
                p5 = 1,
                p6 = 1
            };
            var randomList = KlasificejamaKopaInit();
            var randomBinarList = BinarKopaInit(randomList);
            var readyList = new List<Lietotajs>();

            foreach (var item in randomList)
            {
                KlasificetLietotaju(item, prezicitate);
                readyList.Add(item);
            }
            return View(randomList);
        }
        public IActionResult IndexManual(SalidzinasasPrecizitate precizitate)
        {
            return View();

        }

        public IActionResult About()
        {
            var randomList = KlasificejamaKopaInit();
            var randomBinarList = BinarKopaInit(randomList);
            var apmacibasKopa = ApmacibasKopaInit();
            var apmacibasKopaBinar = BinarKopaInit(apmacibasKopa);
            var readyList = new List<BinarLietotajs>();

            foreach (var item in randomBinarList)
            {
                KlasificetBinarLietotaju(item, apmacibasKopaBinar);
                readyList.Add(item);
            }
            return View(readyList);
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
        public List<BinarLietotajs> KlasificejamaKopaBinarInit()
        {
            var list = new List<BinarLietotajs>();
            for (int i = 0; i < 15; i++)
            {
                var r = new Random();
                var user = new BinarLietotajs();
                for (int z = 0; z < 6; z++)
                {
                    var rnd = r.Next(0, 3);
                    switch (z)
                    {
                        case 0:
                            if (rnd == 1)
                            {
                                user.a1 = 1;
                            }
                            else if (rnd == 2)
                            {
                                user.b1 = 1;
                            }
                            else
                            {
                                user.c1 = 1;
                            }
                            break;
                        case 1:
                            if (rnd == 1)
                            {
                                user.a2 = 1;
                            }
                            else if (rnd == 2)
                            {
                                user.b2 = 1;
                            }
                            else
                            {
                                user.c2 = 1;
                            }
                            break;
                        case 2:
                            if (rnd == 1)
                            {
                                user.a3 = 1;
                            }
                            else if (rnd == 2)
                            {
                                user.b3 = 1;
                            }
                            else
                            {
                                user.c3 = 1;
                            }
                            break;
                        case 3:
                            if (rnd == 1)
                            {
                                user.a4 = 1;
                            }
                            else if (rnd == 2)
                            {
                                user.b4 = 1;
                            }
                            else
                            {
                                user.c4 = 1;
                            }
                            break;
                        case 4:
                            if (rnd == 1)
                            {
                                user.a5 = 1;
                            }
                            else if (rnd == 2)
                            {
                                user.b5 = 1;
                            }
                            else
                            {
                                user.c5 = 1;
                            }
                            break;
                        case 5:
                            if (rnd == 1)
                            {
                                user.a6 = 1;
                            }
                            else if (rnd == 2)
                            {
                                user.b6 = 1;
                            }
                            else
                            {
                                user.c6 = 1;
                            }
                            break;
                    }
                }
                list.Add(user);
            }
            return list;
        }

        public Lietotajs KlasificetLietotaju(Lietotajs lietotajs, SalidzinasasPrecizitate precizitate)
        {
            var dict = new Dictionary<string, int>
            {
                {"K1",0 },
                {"K2",0 },
                {"K3",0 },
            };
            var apmacibasKopa = ApmacibasKopaInit();
            foreach (var item in apmacibasKopa)
            {
                var o1 = Math.Abs(item.SeansuSkaits - lietotajs.SeansuSkaits) <= precizitate.p1 && Math.Abs(item.PalidzibasApmeklesana - lietotajs.PalidzibasApmeklesana) <= precizitate.p3;
                var o2 = Math.Abs(item.PavaditaisLaiksSistema - lietotajs.PavaditaisLaiksSistema) <= precizitate.p2 && Math.Abs(item.AtceltiePasutijumi - lietotajs.AtceltiePasutijumi) <= precizitate.p5;
                var o3 = Math.Abs(item.VeiktiePasutijumi - lietotajs.VeiktiePasutijumi) <= precizitate.p4 && Math.Abs(item.PiesaistiKlienti - lietotajs.PiesaistiKlienti) <= precizitate.p6;
                if (o1 || o2 || o3) dict[item.Klase] += 1;
            }
            lietotajs.Klase = dict.OrderByDescending(k => k.Value).FirstOrDefault().Key;

            return lietotajs;
        }
        public BinarLietotajs KlasificetBinarLietotaju(BinarLietotajs lietotajs, List<BinarLietotajs> apmacibasKopa)
        {
            var K1Balsts = 0;
            var K2Balsts = 0;
            var K3Balsts = 0;
            var kopa1 = lietotajs.a1 + lietotajs.a2 + lietotajs.a3;
            var kopa2 = lietotajs.b1 + lietotajs.b2 + lietotajs.b3;
            var kopa3 = lietotajs.c1 + lietotajs.c2 + lietotajs.c3;
            var kopa4 = lietotajs.a4 + lietotajs.a5 + lietotajs.a6;
            var kopa5 = lietotajs.b4 + lietotajs.b5 + lietotajs.b6;
            var kopa6 = lietotajs.c4 + lietotajs.c5 + lietotajs.c6;
            foreach (var item in apmacibasKopa)
            {
                switch (item.Klase)
                {
                    case "K1":
                        if (kopa1 == item.a1 + item.a2 + item.a3)
                        {
                            K1Balsts++;
                        }
                        if (kopa2 == item.b1 + item.b2 + item.b3)
                        {
                            K1Balsts++;
                        }
                        if (kopa3 == item.c1 + item.c2 + item.c3)
                        {
                            K1Balsts++;
                        }
                        if (kopa4 == item.a4 + item.a5 + item.a6)
                        {
                            K1Balsts++;
                        }
                        if (kopa5 == item.b4 + item.b5 + item.b6)
                        {
                            K1Balsts++;
                        }
                        if (kopa6 == item.c4 + item.c5 + item.c6)
                        {
                            K1Balsts++;
                        }
                        break;
                    case "K2":
                        if (kopa1 == item.a1 + item.a2 + item.a3)
                        {
                            K2Balsts++;
                        }
                        if (kopa2 == item.b1 + item.b2 + item.b3)
                        {
                            K2Balsts++;
                        }
                        if (kopa3 == item.c1 + item.c2 + item.c3)
                        {
                            K2Balsts++;
                        }
                        if (kopa4 == item.a4 + item.a5 + item.a6)
                        {
                            K2Balsts++;
                        }
                        if (kopa5 == item.b4 + item.b5 + item.b6)
                        {
                            K2Balsts++;
                        }
                        if (kopa6 == item.c4 + item.c5 + item.c6)
                        {
                            K2Balsts++;
                        }
                        break;
                    case "K3":
                        if (kopa1 == item.a1 + item.a2 + item.a3)
                        {
                            K3Balsts++;
                        }
                        if (kopa2 == item.b1 + item.b2 + item.b3)
                        {
                            K3Balsts++;
                        }
                        if (kopa3 == item.c1 + item.c2 + item.c3)
                        {
                            K3Balsts++;
                        }
                        if (kopa4 == item.a4 + item.a5 + item.a6)
                        {
                            K3Balsts++;
                        }
                        if (kopa5 == item.b4 + item.b5 + item.b6)
                        {
                            K3Balsts++;
                        }
                        if (kopa6 == item.c4 + item.c5 + item.c6)
                        {
                            K3Balsts++;
                        }
                        break;
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
        public List<BinarLietotajs> BinarKopaInit(List<Lietotajs> lietotajuSaraksts)
        {
            var list = new List<BinarLietotajs>();
            foreach (var item in lietotajuSaraksts)
            {
                var binarLietotajs = new BinarLietotajs();
                //1
                if (item.SeansuSkaits <= 1)
                {
                    binarLietotajs.a1 = 1;
                }
                else if (item.SeansuSkaits > 1 && item.SeansuSkaits <= 5)
                {
                    binarLietotajs.b1 = 1;
                }
                else if (item.SeansuSkaits > 5)
                {
                    binarLietotajs.c1 = 1;
                }
                //2
                if (item.PavaditaisLaiksSistema <= 3)
                {
                    binarLietotajs.a2 = 1;
                }
                else if (item.PavaditaisLaiksSistema > 3 && item.PavaditaisLaiksSistema <= 8)
                {
                    binarLietotajs.b2 = 1;
                }
                else if (item.PavaditaisLaiksSistema > 8)
                {
                    binarLietotajs.c2 = 1;
                }
                //3
                if (item.PalidzibasApmeklesana <= 4)
                {
                    binarLietotajs.a3 = 1;
                }
                else if (item.PalidzibasApmeklesana > 4 && item.PalidzibasApmeklesana <= 6)
                {
                    binarLietotajs.b3 = 1;
                }
                else if (item.PalidzibasApmeklesana > 6)
                {
                    binarLietotajs.c3 = 1;
                }
                //4
                if (item.VeiktiePasutijumi <= 1)
                {
                    binarLietotajs.a4 = 1;
                }
                else if (item.VeiktiePasutijumi > 1 && item.VeiktiePasutijumi <= 3)
                {
                    binarLietotajs.b4 = 1;
                }
                else if (item.VeiktiePasutijumi > 3)
                {
                    binarLietotajs.c4 = 1;
                }
                //5
                if (item.AtceltiePasutijumi <= 3)
                {
                    binarLietotajs.a5 = 1;
                }
                else if (item.AtceltiePasutijumi > 3 && item.AtceltiePasutijumi <= 6)
                {
                    binarLietotajs.b5 = 1;
                }
                else if (item.AtceltiePasutijumi > 6)
                {
                    binarLietotajs.c5 = 1;
                }
                //6
                if (item.PiesaistiKlienti <= 1)
                {
                    binarLietotajs.a6 = 1;
                }
                else if (item.PiesaistiKlienti > 1 && item.PiesaistiKlienti <= 4)
                {
                    binarLietotajs.b6 = 1;
                }
                else if (item.PiesaistiKlienti > 4)
                {
                    binarLietotajs.c6 = 1;
                }
                binarLietotajs.Klase = item.Klase;
                list.Add(binarLietotajs);
            }
            return list;
        }
    }

}
