using System;
using System.Threading.Tasks;

public interface ICalculaJurosService
{
    double Get(double valor, int meses);
}
