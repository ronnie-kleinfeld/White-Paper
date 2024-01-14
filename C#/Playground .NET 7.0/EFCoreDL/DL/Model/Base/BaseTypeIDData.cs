namespace EFCoreDL.DL.Model.Base {
    public class BaseTypeIDData : BaseIDData {
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrderBy { get; set; }
        public bool IsDefault { get; set; }
        public bool Disabled { get; set; }
    }
}