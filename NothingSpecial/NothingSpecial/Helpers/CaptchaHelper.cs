using BotDetect.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// For more information on how I created this captcha, visit: https://captcha.com/doc/aspnet/examples/csharp/asp.net-mvc-5.0-basic-captcha-example.html
namespace NothingSpecial.Helpers
{
    public static class CaptchaHelper
    {
        public static MvcCaptcha GetCustomCaptcha()
        {
            // create the captcha object instance 
            MvcCaptcha customCaptcha = new MvcCaptcha("CustomCaptcha")
            {
                // set up client-side processing of the Captcha code input textbox (found on the Login view)
                UserInputID = "captchaTextBox"
            };

            return customCaptcha;
        }
    }
}