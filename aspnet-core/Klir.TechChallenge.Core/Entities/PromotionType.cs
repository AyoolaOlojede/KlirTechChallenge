using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Core.Entities
{
    public enum PromotionType
    {
        [EnumMember(Value = "Buy X Get Y")]
        BuyXGetY = 1,
        [EnumMember(Value = "Buy X For Y")]
        BuyXForY = 2,
        [EnumMember(Value = "regional")]
        Percentage = 3

    }
}
