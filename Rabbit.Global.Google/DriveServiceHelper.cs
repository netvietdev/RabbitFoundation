using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v2;
using Google.Apis.Services;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Rabbit.Global.Google
{
    public static class DriveServiceHelper
    {
        public static DriveService AuthenticateServiceAccount(string serviceAccountEmail, string keyFilePath, string applicationName)
        {
            if (!File.Exists(keyFilePath))
            {
                throw new FileNotFoundException("Given key file is not found", keyFilePath);
            }

            // Google Drive scopes Documentation:   https://developers.google.com/drive/web/scopes
            string[] scopes = new string[] { DriveService.Scope.Drive,  // view and manage your files and documents
                                             DriveService.Scope.DriveAppdata,  // view and manage its own configuration data
                                             DriveService.Scope.DriveAppsReadonly,   // view your drive apps
                                             DriveService.Scope.DriveFile,   // view and manage files created by this app
                                             DriveService.Scope.DriveMetadataReadonly,   // view metadata for files
                                             DriveService.Scope.DriveReadonly,   // view files and documents on your drive
                                             DriveService.Scope.DriveScripts };  // modify your app scripts     

            var certificate = new X509Certificate2(keyFilePath, "notasecret", X509KeyStorageFlags.Exportable);

            var credential =
                new ServiceAccountCredential(new ServiceAccountCredential.Initializer(serviceAccountEmail)
                {
                    Scopes = scopes
                }.FromCertificate(certificate));

            // Create the service.
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });

            return service;
        }
    }
}
