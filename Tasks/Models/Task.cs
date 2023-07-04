namespace Tasks.Models
{
    public class Task
    {

        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime Start { get; set;}
        public DateTime End { get; set;}


    }
}
