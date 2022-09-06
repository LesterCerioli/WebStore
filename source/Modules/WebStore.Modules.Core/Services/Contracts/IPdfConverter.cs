using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Modules.Core.Services.Contracts
{
    public interface IPdfConverter
    {
        byte[] Convert(string htmlContent);
    }
}
