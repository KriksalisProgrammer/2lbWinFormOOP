using _2lb.Factorial.SpecialClass2lb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2lb.Factorial
{
   public class Factor:IComparable
    {
        
        public string NameFactorial { get; private set; }
        public uint QuantityWorkings { get; private set; }
        public uint Master { get; private set; }
        public uint QuantityWorkShops { get; private set; }
        public decimal SalaryWorkings { get; private set; }
        public decimal SalaryMasters { get; private set; }
        public decimal SalaryOfMounthWorking { get; private set; }
        public decimal SalaryOfMounthMaster { get; private set; }
        public decimal SalarySumWorkingAndMaster { get; private set; }
        public decimal SumProfite { get; private set; }
        protected long Profit = 2000000;
        public Factor SetName(string Name)
        {
            NameFactorial = Name;
            return this;
        }
        public Factor SetWorking(uint QWorking)
        {
            QuantityWorkings = QWorking;
            return this;
        }
        public Factor SetWorkShop(uint QWorkShop)
        {
            QuantityWorkShops = QWorkShop;
            return this;
        }
        public Factor SetSalaryWorking(decimal SWorking)
        {
            SalaryWorkings = SWorking;
            return this;
        }
        public Factor SetSalaryMaster(decimal SMaster)
        {
            SalaryMasters = SMaster;
            return this;
        }
        public Factor SetSumProfit(decimal money)
        {
            SumProfite =this.SumProfit(money);
            return this;
        }
        public Factor()
        {
           
        }
        public Factor(string NameFac, uint QWorking, uint QWorkShop,uint Master, decimal SalaryWorkings,decimal SalaryMasters)
        {
            NameFactorial = NameFac;
            QuantityWorkings = QWorking;
            QuantityWorkShops = QWorkShop;
           
        }
        public uint QMaster() => Master = QuantityWorkings / 10;//количество мастеров
        public async void AdditionW(int NewWorking)
        {
            QuantityWorkings += (uint)NewWorking;
            int temp = (int)QuantityWorkings / 10;
            if (Master == temp)
                return;
            else if (Master < temp)
            {
                int temp2 = temp - (int)Master;
                Master += (uint)temp2;
               await Task.Run(()=>MessageBox.Show($"В связи с ситуацией.\nНанято рабочих{NewWorking}.\nНанять {temp2} мастера"));

            }
          
        }// нанимание работника
        public async void DismissalW(int Working)
        {
            if (QuantityWorkings >= Working)
            {
                QuantityWorkings -= (uint)Working;
                int temp = (int)QuantityWorkings / 10;
                if (Master == temp)
                    return;
                else if (Master > temp)
                {
                    int temp2 = (int)Master - temp;
                    Master -= (uint)temp2;
                    await Task.Run(() => MessageBox.Show($"В связи с ситуацией.\nНанято рабочих{Working}.\nНанять {temp2} мастера"));
                }
            }
            else
            {
                await Task.Run(() => MessageBox.Show($"Нехватает рабочих"));

            }
        }//увольнение работника
        public decimal SalaryWorking() => SalaryWorkings;
        public decimal SalaryMaster() => SalaryMasters;
        public decimal SalarySum() => SalarySumWorkingAndMaster=(SalaryWorking() * QuantityWorkings) + (SalaryMaster() * Master);//общая сумма денег для зарплаты работников и мастеров
        public decimal ProfitOfMounthWorking()
        {
            return SalaryOfMounthWorking = Profit / (QuantityWorkings * SalaryMasters);
        } //Прибыль за одного рабочего
        public decimal ProfitOfMounthMaster()
        {

            return SalaryOfMounthMaster = Profit / (Master * SalaryMasters); ;
        } //Прибыль за одного мастера
        public static Factor operator +(Factor factor1, Factor factor2) => new Factor($"Слияние двух заводов:{factor1.NameFactorial+factor2.NameFactorial}",
            factor1.QuantityWorkings + factor2.QuantityWorkings,
            factor1.QuantityWorkShops + factor2.QuantityWorkShops,
            factor1.Master+factor2.Master,
            factor1.SalaryWorkings+factor2.SalaryWorkings,
            factor1.SalaryMasters+factor2.SalaryMasters);//слияние
        int IComparable.CompareTo(object obj)
        {
            Factor salary = obj as Factor;
            if (salary != null)
            {
                return this.QuantityWorkings.CompareTo(salary.QuantityWorkings);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Factori");
            }
        }
    }

    namespace SpecialClass2lb
    {
        static class Investment
        {

            public static decimal SumProfit(this Factor salary, decimal sum)
            {

                return (decimal)(((sum / (salary.SalaryWorkings * 10) + salary.SalaryMaster()) / 10 * salary.SalaryMaster() * 50) + ((sum / (salary.SalaryWorkings * 10) + salary.SalaryMaster()) * salary.SalaryWorking() * 75)) / salary.SalarySum();

            }
        }
    }


}
    
