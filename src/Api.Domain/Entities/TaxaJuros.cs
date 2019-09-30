using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TaxaJuros : ITaxaJuros
    {
        string _MicroserviceURI;
        double _IdcTaxaJuros;
        public TaxaJuros()
        {
            _MicroserviceURI = "https://localhost:44329/taxaJuros";
            _IdcTaxaJuros = 0;
        }

        public string MicroserviceURI { get => _MicroserviceURI; set => _MicroserviceURI = value; }

        public string GetUri()
        {
            return _MicroserviceURI;
        }
    }
}
