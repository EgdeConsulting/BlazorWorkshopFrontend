namespace BlazorWorkshopFrontend.Models
{
    public class BookDto
    {
        /// <summary>
        /// Represents the Author of the Book
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Represents the Name of the Book
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents the Availability status of the Book.
        /// <value>AVAILABLE, RENTED</value>
        /// </summary>
        public string Status { get; set; }
    }
}
