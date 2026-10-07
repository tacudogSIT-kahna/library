namespace library.Models;

// One Book object holds one row of lending.book.
public class Book
{
    public long MemberId { get; set; }
    public string FullName { get; set; } = "";
    public string? email { get; set; }
    public decimal? MemberType { get; set; }
    public DateTime Join_Date { get; set; }
}