﻿using ConsoleAppCoreDayfourtask1.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleAppCoreDayfourtask1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<RegDet> dlist = new List<RegDet>();
            var httpclient = new HttpClient();
            var response = await httpclient.GetAsync("https://localhost:44373/api/Regd");
            string result = await response.Content.ReadAsStringAsync();
            dlist = JsonConvert.DeserializeObject<List<RegDet>>(result);

            foreach (var i in dlist)
            {
                Console.WriteLine($"Name:{i.FirstName}\tRID:{i.Rid}\tMAIL ID:{i.Mailid}\tCONTACTNO{i.Contactno}\tSKILLSET:{i.Skillset}");
            }
        }
    }
}