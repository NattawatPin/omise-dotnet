﻿using System.Threading.Tasks;
using System;

namespace Omise.Examples
{
    public class Accounts : Example
    {
        public async Task Retrieve_Retrieve()
        {
            var account = await Client.Account.Get();
            Console.WriteLine($"account: {account.Email}");
        }
    }
}
