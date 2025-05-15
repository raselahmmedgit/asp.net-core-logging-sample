namespace RnD.SerilogSample.Models
{
	public class TreeviewCreateViewModel
    {
        public int? DivisionId { get; set; }
        public int? DistrictId { get; set; }
        public int? UpazilaId { get; set; }
        public int? UnionId { get; set; }
        public int? TypeId { get; set; }
        public int? LevelId { get; set; }
        public DateTime? StartDate { get; set; }
        public string? StartDateStr { get; set; }
        public DateTime? EndDate { get; set; }
        public string? EndDateStr { get; set; }
        public bool IsChecked { get; set; } = false;
    }
}
