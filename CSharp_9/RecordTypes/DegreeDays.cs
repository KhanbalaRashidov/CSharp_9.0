
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecordTypes
{
    public abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords);
    

    public record HeatingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature>TempRecords):DegreeDays(BaseTemperature,TempRecords)
    {
        public double DegreeDays => TempRecords.Where(s => s.Mean < BaseTemperature).Sum(s=>BaseTemperature-s.Mean);
       
    }
    public sealed record CoolingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> TempRecords) : DegreeDays(BaseTemperature, TempRecords)
    {
        public double DegreeDays => TempRecords.Where(s => s.Mean > BaseTemperature).Sum(s => s.Mean - BaseTemperature);
    }
}
    
