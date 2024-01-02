namespace PlaygroundTest.Core.Attributes.ClassAttribute
{
    [Sort(ReverseOrder = true)]
    internal class RetailStoreData
    {

        public int StoreNumber { get; set; }
        public string? BranchName { get; set; }
        public string? SalesRegion { get; set; }
        public bool IsFranchised { get; set; }

    }
}