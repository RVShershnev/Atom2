using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Atom.Models2
{
    [Serializable]
    public class Work : ICloneable
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public DateTime Start { get; set; }    
        public DateTime Finish { get; set; }  
        public long Duration { get; set; }

        /// <summary>
        /// 0 бесплатный сдви
        /// n стоимость в рублях
        /// </summary>
        [JsonProperty("progress_min")]
        public long DurationMin { get; set; }

        

        #region Стоимость

        /// <summary>
        /// -1 запрет
        /// 0 бесплатный сдви
        /// n стоимость в рублях
        /// </summary>
        [JsonProperty("price_earlier")]
        public long PriceEarlier { get; set; }

        [JsonProperty("price_late")]
        public long PriceLate { get; set; }

        /// <summary>
        /// -1 запрет
        /// 0 бесплатный сдви
        /// n стоимость в рублях
        /// </summary>
        [JsonProperty("price_durationc_changed")]
        public long PriceDurationChanged { get; set; }

        /// <summary>
        /// ID Веха.
        /// </summary>
        [JsonProperty("stage_id")]
        public string StageId { get; set; }
        [JsonProperty("project_id")]
        public string ProjectId { get; set; }


        #endregion

        #region IClonable
        public object Clone()
        {
            return new Work()
            {
                Id = this.Id,
                Name = this.Name,
                Duration = this.Duration,
                DurationMin = this.DurationMin,
                Finish = this.Finish,
                PriceDurationChanged = this.PriceDurationChanged,
                PriceEarlier = this.PriceEarlier,
                PriceLate = this.PriceLate,
                Start = this.Start
            };
        }
        #endregion
        #region Gant
        [JsonProperty("progress")]
        public double Progress { get => (double)DurationMin/(End - Start).Days *100; }
      
        [JsonProperty("end")]
        public DateTime End { get => Start.AddDays(Duration); }
        #endregion
        public static double GetChangeCost(Work workLast, Work workNew)
        {
            double cost = 0;
            if(workLast.Start < workNew.Start)
            {
                cost = workNew.PriceLate * (workNew.Start - workLast.Start).Days;
            }
            if (workLast.Start > workNew.Start)
            {
                cost = workNew.PriceEarlier * (workLast.Start - workNew.Start).Days;
            }         
            return cost;
        }


    }
}
