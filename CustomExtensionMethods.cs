using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMerchShopGui {
    static class CustomExtensionMethods {
        public static T? MyNullDefault<T>(this T value, T? customDefault) where T : struct {
            if (value.Equals(default(T))) {
                return customDefault;
            }
            return null;
        }
    }
}
