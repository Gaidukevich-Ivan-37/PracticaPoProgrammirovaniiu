using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlTaskWPF.Models;

namespace XmlTaskWPF.Interfaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Country country);
        void Delete(string name);
        Country FindBy(string name);
        List<Country> GetAll();
    }
}