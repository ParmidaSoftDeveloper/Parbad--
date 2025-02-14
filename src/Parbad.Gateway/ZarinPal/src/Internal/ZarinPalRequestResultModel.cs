// Copyright (c) Parbad. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC License, Version 3.0. See License.txt in the project root for license information.

namespace Parbad.Gateway.ZarinPal.Internal
{
    internal class ZarinPalRequestResultModel
    {
        public ZarinPalRequestResultModelData Data { get; set; }
    }
    
    internal class ZarinPalRequestResultModelData
    {
        public string Authority { set; get; }

        public int Code { set; get; }

        public string PaymentUrl { set; get; }
    }
}
