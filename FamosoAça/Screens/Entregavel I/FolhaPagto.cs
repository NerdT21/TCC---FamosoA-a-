using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Screens.Entregavel_I
{
    public class FolhaPagto
    {
        public decimal SalarioHora(decimal salario)
        {

            decimal salarioH = salario / 220;

            return salarioH;
        }

        public decimal ValeTransporte(decimal salario)
        {

            decimal Vale = (salario * 6) / 100;

            return Vale;
        }

        public decimal CalculoINSS(decimal salario, decimal faltas, decimal atrasos, decimal horaExtra50, decimal horaextra100, decimal SDR)
        {

            decimal INSS = salario + horaExtra50 + horaextra100 + SDR - faltas - atrasos;

            if (INSS >= 954 && INSS <= 1693.72m)
            {

                INSS = (salario * 8) / 100;

            }
            if (INSS >= 1693.73m && INSS <= 2822.90m)
            {

                INSS = (salario * 9) / 100;


            }
            if (INSS >= 2822.91m && INSS <= 5645.80m)
            {

                INSS = (salario * 11) / 100;


            }
            return INSS;

        }

        public decimal CalculoFGTS(decimal salario, decimal extra50, decimal extra100)
        {

            decimal FGTS = ((salario + extra50 + extra100) * 8) / 100;

            return FGTS;
        }

        public decimal HoraExtra50(decimal salario, int horas)
        {
            decimal salarioH = (salario / 220);

            decimal hora50 = (salarioH * 50) / 100;

            decimal salario50 = (hora50 + salarioH) * horas;



            return salario50;


        }
        public decimal HoraExtra100(decimal salario, int horas)
        {

            decimal salarioH = (salario / 220);

            decimal hora100 = (salarioH * 50) / 100;

            decimal salario100 = (hora100 + salarioH) * horas;



            return salario100;
        }

        public decimal CalculoImpostoRenda(decimal salario, decimal faltas, decimal atrasos, decimal horaExtra50, decimal horaextra100, decimal SDR)
        {
            decimal SalarioBase = salario + horaExtra50 + horaextra100 + SDR - faltas - atrasos;

            decimal ImpostoRenda = 0;

            decimal Imposto = 0;

            if (SalarioBase <= 1903.98m)
            {

                Imposto = salario;

            }
            if (SalarioBase >= 1903.99m || salario <= 2826.65m)
            {
                ImpostoRenda = (salario * 7.5m) / 100;

                if (ImpostoRenda >= 142.80m)
                {

                    Imposto = ImpostoRenda - 142.80m;

                }


            }
            if (SalarioBase >= 2826.66m || salario <= 3751.05m)
            {

                ImpostoRenda = (salario * 15) / 100;

                if (ImpostoRenda >= 354.80m)
                {

                    Imposto = ImpostoRenda - 354.80m;

                }


            }
            if (SalarioBase >= 3751.06m || salario <= 4664.68m)
            {

                ImpostoRenda = (salario * 22.5m) / 100;

                if (ImpostoRenda >= 636.13m)
                {

                    Imposto = ImpostoRenda - 636.13m;

                }

            }
            if (SalarioBase >= 4664.68m)
            {

                ImpostoRenda = (salario * 27.5m) / 100;

                if (ImpostoRenda >= 869.36m)
                {

                    Imposto = ImpostoRenda - 869.36m;

                }


            }
            return Imposto;

        }
        public decimal CalcularAtrasos(decimal salariohora, int horas)
        {
            decimal valor = salariohora * horas;

            return valor;
        }

        public decimal CalcularDSR(decimal valorExtra, int horas, int domingos)
        {
            decimal saldo = valorExtra * horas;
            decimal dsr = ((saldo / 26) * 4) - domingos;

            return dsr;
        }

        public decimal CalcularFalta(decimal salario, int falta)
        {
            decimal faltas = salario / falta;

            return faltas;
        }
    }
}
