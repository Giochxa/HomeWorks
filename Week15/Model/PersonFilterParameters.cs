namespace Week15.Model
{
    public class PersonFilterParameters
    {
        public string City { get; set; }
        // Add more filter parameters as needed
        public string JobPosition { get; set; }
        public double? MinSalary { get; set; }
        public double? MaxSalary { get; set; }
    }
}
