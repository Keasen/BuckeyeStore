namespace BuckeyeStore.Core
{
    public class Review
    {
        public int Id {get; set; }
         public string Body {get; set; }

         public Rating Rating { get; set; }

    }
}