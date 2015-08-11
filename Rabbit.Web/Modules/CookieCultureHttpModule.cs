using System;
using System.Globalization;
using System.Threading;
using System.Web;

namespace Rabbit.Web.Modules
{
    public class CookieCultureHttpModule : IHttpModule
    {
        private const string LanguageCookie = "hl";

        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
        }

        private void context_BeginRequest(object sender, EventArgs e)
        {
            var application = (HttpApplication)sender;
            var culture = ResolveCulture(application.Context.Request);

            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
        }

        private CultureInfo ResolveCulture(HttpRequest request)
        {
            CultureInfo culture = null;

            var languageCookie = request.Cookies[LanguageCookie];
            if (languageCookie != null)
            {
                culture = TryCreateCultureInfo(languageCookie.Value);
            }

            var languages = request.UserLanguages;
            if (languages != null && languages.Length > 0)
            {
                var language = languages[0].ToLowerInvariant().Trim();
                culture = TryCreateCultureInfo(language);
            }

            return culture ?? new CultureInfo("en-US");
        }

        private CultureInfo TryCreateCultureInfo(string name)
        {
            try
            {
                return CultureInfo.CreateSpecificCulture(name);
            }
            catch (CultureNotFoundException ex)
            {
                // TODO: log
            }
            catch (NullReferenceException ex)
            {
                // TODO: log
            }

            return null;
        }
    }
}
