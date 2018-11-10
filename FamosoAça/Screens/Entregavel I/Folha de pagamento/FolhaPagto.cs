//using FamosoAça.Classes.SalarioFamilia;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FamosoAça.Screens.Entregavel_I
//{
//    public class FolhaPagto
//    {
//        public decimal Salario { private get; set; }
//        public DateTime HoraExtra { private get; set; }
//        public int Percentual { private get; set; }
//        public int Faltas { private get; set; }
//        public DateTime Atrasos { private get; set; }
//        public int Domingos { private get; set; }


//        private decimal CalcularSalarioHora() //OK
//        {
//            decimal salario = this.Salario / 220;
//            return salario;
//        }

//        private decimal CalcularHoraExtra() //OK
//        {
//            int percentual = this.Percentual;
//            decimal horaPorDia = CalcularSalarioHora();
//            decimal AddPorHora = horaPorDia * ((decimal)percentual / 100);

//            int convertToDecimal = this.HoraExtra.Hour;

//            decimal horaExtra = (horaPorDia + AddPorHora) * convertToDecimal; //soma e multiplica
//            return horaExtra;
//        }

//        private decimal CalcularFaltas()
//        {
//            int faltas = this.Faltas;
//            if (faltas > 0)
//            {
//                decimal salario = this.Salario;

//                decimal conta = (salario / 30) * faltas;

//                return conta;
//            }
//            else
//            {
//                return 0;
//            }

//        }

//        private decimal CalcularDSR() //OK
//        {
//            decimal horaExtra = CalcularHoraExtra();
//            int faltas = this.Faltas;
//            int domingos = this.Domingos;

//            int descontoDom = 4 - domingos;
//            int descontoDia = 26 - faltas;

//            decimal dsr = (horaExtra / descontoDia) * descontoDom;
//            return dsr;
//        }

//        private decimal CalcularAtraso()
//        {
//            DateTime atraso = this.Atrasos;
//            decimal horaPorDia = CalcularSalarioHora();

//            int horaAtraso = atraso.Hour;
//            decimal Atraso = horaPorDia * horaAtraso;
//            return Atraso;
//        }

//        private decimal CalcularBaseINSS() // OK - MUDAR O INT NO HORAATRASO que pode dar problema por causa dos minutos
//        {
//            decimal salario = this.Salario;
//            decimal HoraExtra = CalcularHoraExtra();
//            decimal dsr = CalcularDSR();
//            int faltas = this.Faltas;

//            DateTime atraso = this.Atrasos;
//            int horaAtraso = atraso.Hour;

//            decimal baseInss = salario + HoraExtra + dsr - faltas - horaAtraso;
//            return baseInss;

//        }

//        public decimal CalcularINSS() // OK
//        {
//            decimal baseInss = CalcularBaseINSS();

//            if (baseInss <= 1659.38m)
//            {
//                decimal sal = 1659.38m;

//                INSSBusiness buss = new INSSBusiness();
//                INSSDTO dto = buss.Consultar(sal);

//                decimal inss = baseInss * ((decimal)dto.Aliquota / 100);
//                return inss;
//            }
//            else if (baseInss >= 1659.39m && baseInss <= 2765.66m)
//            {
//                decimal sal = 2765.66m;

//                INSSBusiness buss = new INSSBusiness();
//                INSSDTO dto = buss.Consultar(sal);

//                var inss = ((decimal)dto.Aliquota / 100) * baseInss;
//                return inss;
//            }
//            else
//            {
//                decimal sal = 5531.31m;

//                INSSBusiness buss = new INSSBusiness();
//                INSSDTO dto = buss.Consultar(sal);

//                na porcentagem, colocar o(decimal) pra indicar ponto flutuante. . 
//                decimal inss = baseInss * ((decimal)dto.Aliquota / 100);
//                return inss;
//            }
//        }

//        private decimal CalcularBaseIR()
//        {
//            decimal baseInss = CalcularBaseINSS();
//            decimal inss = CalcularINSS();

//            decimal baseIr = baseInss - inss;
//            return baseIr;
//        }

//        public decimal CalcularIR() //OK
//        {
//            decimal baseIr = CalcularBaseIR();

//            if (baseIr <= 1903.98m)
//            {
//                decimal Base = 1903.98m;

//                ImpostoRendaBusiness buss = new ImpostoRendaBusiness();
//                ImpostoRendaDTO dto = buss.Consultar(Base);

//                decimal calculo = baseIr * ((decimal)dto.Aliquota / 100);
//                decimal ir = calculo - dto.Deducao;
//                return ir;
//            }
//            else if (baseIr >= 1903.99m && baseIr <= 2826.65m)
//            {
//                decimal Base = 1903.99m;

//                ImpostoRendaBusiness buss = new ImpostoRendaBusiness();
//                ImpostoRendaDTO dto = buss.Consultar(Base);

//                decimal calculo = baseIr * ((decimal)dto.Aliquota / 100);
//                decimal ir = calculo - dto.Deducao;
//                return ir;
//            }
//            else if (baseIr >= 2826.66m && baseIr <= 3751.05m)
//            {
//                decimal Base = 2826.66m;

//                ImpostoRendaBusiness buss = new ImpostoRendaBusiness();
//                ImpostoRendaDTO dto = buss.Consultar(Base);

//                decimal calculo = baseIr * ((decimal)dto.Aliquota / 100);
//                decimal ir = calculo - dto.Deducao;
//                return ir;
//            }
//            else if (baseIr >= 3751.06m && baseIr <= 4664.68m)
//            {
//                decimal Base = 3751.06m;

//                ImpostoRendaBusiness buss = new ImpostoRendaBusiness();
//                ImpostoRendaDTO dto = buss.Consultar(Base);

//                decimal calculo = baseIr * ((decimal)dto.Aliquota / 100);
//                decimal ir = calculo - dto.Deducao;
//                return ir;
//            }
//            else
//            {
//                decimal Base = 4664.68m;

//                ImpostoRendaBusiness buss = new ImpostoRendaBusiness();
//                ImpostoRendaDTO dto = buss.Consultar(Base);

//                decimal calculo = baseIr * ((decimal)dto.Aliquota / 100);
//                decimal ir = calculo - dto.Deducao;
//                return ir;
//            }
//        }

//        public decimal CalcularFGTS() // não é salário, é a base do INSS
//        {
//            decimal salario = this.Salario;
//            return salario * ((decimal)8 / 100);
//        }

//        public decimal CalcularValeTransporte() //OK
//        {
//            decimal salario = this.Salario;
//            return salario * ((decimal)6 / 100);
//        }

//        public decimal VerificarSalarioFamilia() //OK
//        {
//            decimal salario = this.Salario;

//            if (salario <= 859.88m)
//            {
//                decimal sal = 859.88m;

//                SalarioFamilhaBusiness buss = new SalarioFamilhaBusiness();
//                SalarioFamilhaDTO dto = buss.Consultar(sal);

//                return dto.Valor;
//            }
//            else if (salario >= 859.89m && salario <= 1292.43m)
//            {
//                decimal sal = 1292.43m;

//                SalarioFamilhaBusiness buss = new SalarioFamilhaBusiness();
//                SalarioFamilhaDTO dto = buss.Consultar(sal);

//                return dto.Valor;
//            }
//            else
//            {
//                decimal sal = 1292.44m;

//                SalarioFamilhaBusiness buss = new SalarioFamilhaBusiness();
//                SalarioFamilhaDTO dto = buss.Consultar(sal);

//                return dto.Valor;

//            }


//        }

//        public decimal CalcularSalarioLiquido()
//        {
//            decimal salario = this.Salario;

//            decimal salarioLiquido = salario + CalcularHoraExtra() + CalcularDSR() + VerificarSalarioFamilia() - CalcularAtraso() -
//                CalcularFaltas() - CalcularINSS() - CalcularIR() - CalcularValeTransporte();

//            return salarioLiquido;
//        }
//    }
//}
