namespace TestProject.Models
{
    public class Data
    {
        public int[]  ThisWeek { get; set;}
        public int[]  TheLastWeek { get; set;}
        
        public Data()
        {
            ThisWeek = new int[] {2, 3, 4, 5, 6, 7, 8};
            TheLastWeek = new int[] {8, 7, 6, 5, 4, 3, 2, 1};
        }
    }
}