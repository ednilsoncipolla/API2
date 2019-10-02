using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        ITaxaJuros _TaxaJuros;
        double Idc;

        public TaxaJurosService(ITaxaJuros taxaJuros)
        {
            _TaxaJuros = taxaJuros;
        }

        public async Task Get()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(_TaxaJuros.GetUri()))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var resposta = await response.Content.ReadAsStringAsync();
                        ;
                        try
                        {
                            Idc = Convert.ToDouble(resposta.Replace(".",","));

                        }
                        catch (Exception e)
                        {
                            throw new Exception ($"Falha na recuperação da taxa de atualização monteária, {e.Message}");
                        }
                    }
                    else
                    {
                        throw new Exception("Não foi possível recuperar a taxa de atualização de valores!");
                    }
                }
            }
        }

        public double GetIdc()
        {
            return Idc;
        }
    }
}
