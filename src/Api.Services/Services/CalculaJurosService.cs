﻿using Domain.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
public class CalculaJurosService : ICalculaJurosService
{
    ITaxaJurosService _taxaJurosService;

    public CalculaJurosService(ITaxaJurosService taxaJurosService)
	{
        _taxaJurosService = taxaJurosService;
    }

    public async Task<double> Get(double valorInical, int meses)
    {
        try
        {
            await _taxaJurosService.Get();
            double idc = _taxaJurosService.GetIdc();
            double ValorFinal = valorInical * Math.Pow(1 + idc, meses); ;
            return (Math.Truncate(ValorFinal * 100) / 100);
        }
        catch (Exception e)
        {
            throw new Exception($"Erro calculando Valor atualizado, {e.Message}");
        }
    }
}
