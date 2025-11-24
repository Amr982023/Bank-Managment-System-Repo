using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsOTP
    {
        public static async Task<bool> GenerateUserOtpAsync(int userId, string otp, int expiryMinutes = 5)
        {
            return await clsOTPDataAccessLayer.GenerateUserOtpAsync(userId, otp, expiryMinutes);
        }

        public static async Task<bool> ValidateUserOtpAsync(int userId, string otp)
        {
            return await clsOTPDataAccessLayer.ValidateUserOtpAsync(userId, otp);
        }

    }
}
