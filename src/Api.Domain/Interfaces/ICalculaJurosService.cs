using System;
using System.Threading.Tasks;

public interface ICalculaJurosService
{
    Task<double> Get(double valor, int meses);
}
