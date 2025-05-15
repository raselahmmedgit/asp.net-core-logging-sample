namespace RnD.NLogSample.Models
{
	public class TreeviewViewModel
	{
        public int Id { get; set; }
        public string? Name { get; set; }
		public string? Value { get; set; }
        public bool IsChecked { get; set; } = false;
        public string? ChildrenTitle { get; set; }
        public List<TreeviewViewModel> ChildrenList { get; set; } = new List<TreeviewViewModel>();
    }
}
