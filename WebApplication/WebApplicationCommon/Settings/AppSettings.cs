using WebApplicationCommon.Utils;

namespace WebApplicationCommon.Settings
{
    public class AppSettings
    {
        // public string DatabaseConnection
        // {
        //     get => _databaseConnection;
        //     set => _databaseConnection = AesEncryptionService.Decrypt(value);
        // }

        public string DatabaseConnection { get; set; }
    }
}