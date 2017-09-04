using System;

namespace ASP.NetBMI.Services
{
    public interface IBmiService
    {
        double Calculcate(Models.Bmi data);
    }

    public class BmiService : IBmiService
    {
        public double Calculcate(Models.Bmi data)
        {
            return Math.Round(data.Weight / Math.Pow((data.Height / 100), 2), 2);
        }
    }
}
