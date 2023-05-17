using System;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.Interfaces
{
    internal interface IMacroNutrientes
    {
        MacroNutrientesModel CalcularMacroNutrientes(ObjetivoFisicoEnum ObjetivoFisico, double Peso);
    }
}