using System;

// ReSharper disable InconsistentNaming

namespace Samples.Models
{
	[Serializable]
	public class MonitorOdds
	{
		public MonitorOdds()
		{
			
		}
		public int id { get; set; }
		public long oddsId { get; set; }
		public decimal PredictOdds2a { get; set; }
		public decimal PredictOUPoint { get; set; }
		public string RulesApplied { get; set; }
		public decimal Odds1a { get; set; }
		public decimal Odds2a { get; set; }
		public decimal OUPoint { get; set; }
		public decimal MaxBet { get; set; }
		public decimal Forecast0 { get; set; }
		public decimal Forecast1 { get; set; }
		public DateTime Time { get; set; }
		public DateTime CreatedOn { get; set; }
		public decimal CF0_nml { get; set; }
		public decimal CF1_nml { get; set; }
		public decimal CF2_nml { get; set; }
		public decimal CF3_nml { get; set; }
		public decimal CF4_nml { get; set; }
		public string OddsStatus { get; set; }
		public decimal timeSpan { get; set; }
		public decimal e_dif_CF0 { get; set; }
		public decimal e_dif_CF1 { get; set; }
		public decimal v_CF0 { get; set; }
		public decimal v_CF1 { get; set; }
		public decimal slope { get; set; }
		public decimal SyncPoint { get; set; }
		public decimal SyncPrice { get; set; }
		public decimal ToBuy { get; set; }
		public decimal AdvanceTimeInSeconds { get; set; }
		public string NextStrategy { get; set; }
		public string CurrentStrategy { get; set; }
		public string ActionType { get; set; }
		public decimal Win_CF0 { get; set; }
		public decimal Win_CF1 { get; set; }
		public int Surrender { get; set; }
		public decimal x { get; set; }
		public decimal risk_factor { get; set; }

		public MonitorOdds ShallowCopy()
		{
			return (MonitorOdds)MemberwiseClone();
		}
	}
}