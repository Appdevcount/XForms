using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XForms.Models.Services.LibraryPOCs
{
    public interface IQRScanningService
    {
        Task<string> ScanAsync();
    }
 
}
