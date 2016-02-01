﻿using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class ConnectBKMAuth : ConnectPayment
    {
        public String Token { get; set; }
        public String CallbackUrl { get; set; }
        public String PaymentStatus { get; set; }

        public static Task<ConnectBKMAuth> Retrieve(RetrieveBKMAuthRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<ConnectBKMAuth>(options.BaseUrl + "/payment/iyziconnect/bkm/auth/detail", request);
        }
    }
}