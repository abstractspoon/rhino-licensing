using System.IO;
using Rhino.Licensing.AdminTool.Model;
using System;
using System.Linq;

namespace Rhino.Licensing.AdminTool.Services
{
    public class ExportService : IExportService
    {
        public void Export(Product product, License license, FileInfo path)
        {
            var generator = new LicenseGenerator(product.PrivateKey);
            var expiration = license.ExpirationDate.GetValueOrDefault(DateTime.MaxValue);

			var attributes = license.Data.ToDictionary(userData => userData.Key, userData => userData.Value);

			attributes["email"] = license.OwnerEmail;
			attributes["plugin_name"] = license.PluginName;
			attributes["plugin_id"] = license.PluginID;

			var key = generator.Generate(license.OwnerEmail, license.ID, expiration, attributes, license.LicenseType);

            File.WriteAllText(path.FullName, key);
        }
    }
}