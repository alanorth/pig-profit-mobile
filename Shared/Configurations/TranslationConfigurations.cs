using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models;
using CsvHelper;
using System.IO;
using System.Reflection;
using CsvHelper.Configuration;
using System.Globalization;
using System.Linq;

namespace Shared.Configurations
{
    public class TranslationConfigurations : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            Translation[] transArray;
            Assembly assembly = Assembly.GetExecutingAssembly();
            //var translationFilefath = Path.Combine(AppDomain.CurrentDomain., "Resources", "Translations.csv");
            using (Stream stream = assembly.GetManifestResourceStream("Shared.Resources.Translations.csv"))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<Translation>();
                        builder.HasData(records.ToList());
                    }
                }
            }
            builder.HasKey(x => x.RowKey);
        }
    }
}
